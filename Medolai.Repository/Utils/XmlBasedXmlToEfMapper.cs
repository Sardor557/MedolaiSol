using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using GtdXmlEf.Models;

namespace Medolai.Repository.Utils;

/// <summary>
/// Маппинг XML -> EF модели, созданные по структуре XML (T1/T2/T4/...).
/// Заполняет свойства по атрибутам [Column("P..T..")] и строит связи по вложенности элементов T*.
/// </summary>
public static class XmlToEfMapper
{
    private static readonly CultureInfo Invariant = CultureInfo.InvariantCulture;

    public static GtdT1 ParseFile(string filePath)
        => Parse(XDocument.Load(filePath, LoadOptions.PreserveWhitespace | LoadOptions.SetLineInfo));

    public static GtdT1 ParseXml(string xml)
        => Parse(XDocument.Parse(xml, LoadOptions.PreserveWhitespace | LoadOptions.SetLineInfo));

    public static GtdT1 Parse(XDocument doc)
    {
        var t1 = doc.Descendants("T1").FirstOrDefault()
                 ?? throw new InvalidOperationException("Не найден элемент <T1>.");

        var root = new GtdT1();
        MapColumns(root, t1);

        foreach (var childTable in t1.Elements().Where(IsTableElement))
            ParseAndAttachRecursive(root, childTable);

        return root;
    }

    private static void ParseAndAttachRecursive(object parent, XElement tableElement)
    {
        var tag = tableElement.Name.LocalName;
        var childType = GetTypeByTableTag(tag);
        if (childType is null) return;

        var child = Activator.CreateInstance(childType)
                   ?? throw new InvalidOperationException($"Не удалось создать экземпляр {childType.FullName} для {tag}.");

        MapColumns(child, tableElement);
        AttachChild(parent, child);

        foreach (var subTable in tableElement.Elements().Where(IsTableElement))
            ParseAndAttachRecursive(child, subTable);
    }

    private static bool IsTableElement(XElement e)
    {
        var n = e.Name.LocalName;
        if (n.Length < 2) return false;
        if (n[0] != 'T' && n[0] != 't') return false;
        return n.Skip(1).All(char.IsDigit);
    }

    private static readonly ConcurrentDictionary<string, Type?> TagToTypeCache = new(StringComparer.OrdinalIgnoreCase);
    private static readonly Lazy<Dictionary<string, Type>> TagToType = new(BuildTagToType);

    private static Dictionary<string, Type> BuildTagToType()
    {
        var asm = typeof(GtdT1).Assembly;
        var map = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

        foreach (var t in asm.GetTypes())
        {
            var table = t.GetCustomAttribute<TableAttribute>();
            if (table?.Name is null) continue;

            if (!map.ContainsKey(table.Name))
                map.Add(table.Name, t);
        }

        return map;
    }

    private static Type? GetTypeByTableTag(string tag)
    {
        if (TagToTypeCache.TryGetValue(tag, out var cached))
            return cached;

        TagToType.Value.TryGetValue(tag, out var t);
        TagToTypeCache[tag] = t;
        return t;
    }

    private sealed record ColProp(PropertyInfo Prop, string ColumnName, Type TargetType);
    private static readonly ConcurrentDictionary<Type, List<ColProp>> ColumnPropsCache = new();

    private static List<ColProp> GetColumnProps(Type t)
    {
        return ColumnPropsCache.GetOrAdd(t, static type =>
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(p => (p, col: p.GetCustomAttribute<ColumnAttribute>()))
                .Where(x => x.col?.Name is not null && x.p.CanWrite)
                .Select(x => new ColProp(x.p, x.col!.Name!, x.p.PropertyType))
                .ToList();
        });
    }

    private static void MapColumns(object target, XElement element)
    {
        var props = GetColumnProps(target.GetType());

        foreach (var cp in props)
        {
            if (cp.ColumnName.Equals("ID", StringComparison.OrdinalIgnoreCase)) continue;
            if (cp.ColumnName.EndsWith("_ID", StringComparison.OrdinalIgnoreCase)) continue;

            var node = element.Element(cp.ColumnName);
            if (node is null) continue;

            var raw = (node.Value ?? string.Empty).Trim();
            if (raw.Length == 0) continue;

            if (TryConvert(raw, cp.TargetType, out var value))
                cp.Prop.SetValue(target, value);
        }
    }

    private static bool TryConvert(string raw, Type targetType, out object? value)
    {
        value = null;
        var u = Nullable.GetUnderlyingType(targetType) ?? targetType;

        if (u == typeof(string)) { value = raw; return true; }

        var normalized = raw.Replace(',', '.');

        if (u == typeof(int))
        {
            if (int.TryParse(normalized, NumberStyles.Any, Invariant, out var v)) { value = v; return true; }
            return false;
        }
        if (u == typeof(long))
        {
            if (long.TryParse(normalized, NumberStyles.Any, Invariant, out var v)) { value = v; return true; }
            return false;
        }
        if (u == typeof(decimal))
        {
            if (decimal.TryParse(normalized, NumberStyles.Any, Invariant, out var v)) { value = v; return true; }
            return false;
        }
        if (u == typeof(DateTime))
        {
            if (DateTime.TryParseExact(raw, "yyyy-MM-dd", Invariant, DateTimeStyles.None, out var dt))
            {
                value = dt;
                return true;
            }
            if (DateTime.TryParse(raw, Invariant, DateTimeStyles.AssumeLocal, out dt))
            {
                value = dt;
                return true;
            }
            return false;
        }
        return false;
    }

    private static void AttachChild(object parent, object child)
    {
        var parentType = parent.GetType();
        var childType = child.GetType();

        var navToParent = childType.GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .FirstOrDefault(p => p.CanWrite && p.PropertyType == parentType);

        navToParent?.SetValue(child, parent);

        var collProp = parentType.GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .FirstOrDefault(p =>
                p.PropertyType.IsGenericType
                && p.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)
                && p.PropertyType.GetGenericArguments()[0] == childType);

        if (collProp is not null)
        {
            var coll = collProp.GetValue(parent);
            var add = coll?.GetType().GetMethod("Add", new[] { childType });
            add?.Invoke(coll, new[] { child });
        }
    }
}
