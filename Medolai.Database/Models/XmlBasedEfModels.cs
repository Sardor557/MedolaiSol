using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GtdXmlEf.Models;

[Table("T1")]
[Description("Декларация (шапка ГТД)")]
public class GtdT1
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public long Id { get; set; }

    [DisplayName("Поле 2")]
    [Column("P2T1")]
    [MaxLength(20)]
    public string? Field2 { get; set; }

    [DisplayName("Поле 3")]
    [Column("P3T1")]
    [MaxLength(20)]
    public string? Field3 { get; set; }

    [DisplayName("Поле 4")]
    [Column("P4T1")]
    public int? Field4 { get; set; }

    [DisplayName("Поле 5")]
    [Column("P5T1")]
    public int? Field5 { get; set; }

    [DisplayName("Поле 6")]
    [Column("P6T1")]
    [MaxLength(30)]
    public string? Field6 { get; set; }

    [DisplayName("Поле 7")]
    [Column("P7T1")]
    [MaxLength(100)]
    public string? Field7 { get; set; }

    [DisplayName("Поле 8")]
    [Column("P8T1")]
    [MaxLength(20)]
    public string? Field8 { get; set; }

    [DisplayName("Поле 10")]
    [Column("P10T1")]
    public int? Field10 { get; set; }

    [DisplayName("Поле 12")]
    [Column("P12T1")]
    [MaxLength(20)]
    public string? Field12 { get; set; }

    [DisplayName("Поле 14")]
    [Column("P14T1")]
    [MaxLength(30)]
    public string? Field14 { get; set; }

    [DisplayName("Поле 17")]
    [Column("P17T1")]
    public int? Field17 { get; set; }

    [DisplayName("Поле 18")]
    [Column("P18T1")]
    public decimal? Field18 { get; set; }

    [DisplayName("Поле 19")]
    [Column("P19T1")]
    public int? Field19 { get; set; }

    [DisplayName("Поле 21")]
    [Column("P21T1")]
    [MaxLength(20)]
    public string? Field21 { get; set; }

    [DisplayName("Поле 22")]
    [Column("P22T1")]
    [MaxLength(20)]
    public string? Field22 { get; set; }

    [DisplayName("Поле 23")]
    [Column("P23T1")]
    [MaxLength(80)]
    public string? Field23 { get; set; }

    [DisplayName("Поле 25")]
    [Column("P25T1")]
    public int? Field25 { get; set; }

    [DisplayName("Поле 26")]
    [Column("P26T1")]
    public int? Field26 { get; set; }

    [DisplayName("Поле 27")]
    [Column("P27T1")]
    public int? Field27 { get; set; }

    [DisplayName("Поле 29")]
    [Column("P29T1")]
    public int? Field29 { get; set; }

    [DisplayName("Поле 30")]
    [Column("P30T1")]
    [MaxLength(150)]
    public string? Field30 { get; set; }

    [DisplayName("Поле 31")]
    [Column("P31T1")]
    public int? Field31 { get; set; }

    [DisplayName("Поле 32")]
    [Column("P32T1")]
    [MaxLength(80)]
    public string? Field32 { get; set; }

    [DisplayName("Поле 37")]
    [Column("P37T1")]
    public decimal? Field37 { get; set; }

    [DisplayName("Поле 38")]
    [Column("P38T1")]
    public int? Field38 { get; set; }

    [DisplayName("Поле 39")]
    [Column("P39T1")]
    [MaxLength(30)]
    public string? Field39 { get; set; }

    [DisplayName("Поле 40")]
    [Column("P40T1")]
    [MaxLength(30)]
    public string? Field40 { get; set; }

    [DisplayName("Поле 41")]
    [Column("P41T1")]
    public int? Field41 { get; set; }

    [DisplayName("Поле 42")]
    [Column("P42T1")]
    public int? Field42 { get; set; }

    [DisplayName("Поле 44")]
    [Column("P44T1")]
    [MaxLength(255)]
    public string? Field44 { get; set; }

    [DisplayName("Поле 48")]
    [Column("P48T1")]
    public int? Field48 { get; set; }

    [DisplayName("Поле 53")]
    [Column("P53T1")]
    public int? Field53 { get; set; }

    [DisplayName("Поле 57")]
    [Column("P57T1")]
    [MaxLength(20)]
    public string? Field57 { get; set; }

    [DisplayName("Поле 58")]
    [Column("P58T1")]
    public decimal? Field58 { get; set; }

    [DisplayName("Поле 59")]
    [Column("P59T1")]
    public decimal? Field59 { get; set; }

    [DisplayName("Поле 61")]
    [Column("P61T1")]
    public int? Field61 { get; set; }

    [DisplayName("Поле 63")]
    [Column("P63T1")]
    public int? Field63 { get; set; }

    [DisplayName("Поле 64")]
    [Column("P64T1")]
    public int? Field64 { get; set; }

    [DisplayName("Поле 67")]
    [Column("P67T1")]
    public int? Field67 { get; set; }

    [DisplayName("Поле 87")]
    [Column("P87T1")]
    [MaxLength(20)]
    public string? Field87 { get; set; }

    [DisplayName("Поле 96")]
    [Column("P96T1")]
    public int? Field96 { get; set; }

    [DisplayName("Поле 97")]
    [Column("P97T1")]
    public int? Field97 { get; set; }

    [DisplayName("Поле 98")]
    [Column("P98T1")]
    [MaxLength(20)]
    public string? Field98 { get; set; }

    [DisplayName("Поле 99")]
    [Column("P99T1")]
    [MaxLength(20)]
    public string? Field99 { get; set; }

    [DisplayName("Поле 115")]
    [Column("P115T1")]
    public decimal? Field115 { get; set; }

    [DisplayName("Поле 221")]
    [Column("P221T1")]
    public int? Field221 { get; set; }

    [DisplayName("Поле 222")]
    [Column("P222T1")]
    public int? Field222 { get; set; }

    [DisplayName("Поле 240")]
    [Column("P240T1")]
    public int? Field240 { get; set; }

    [DisplayName("Поле 244")]
    [Column("P244T1")]
    [MaxLength(20)]
    public string? Field244 { get; set; }

    [DisplayName("Импортер Email")]
    [Column("P_IMPORTER_EMAIL")]
    [MaxLength(30)]
    public string? ImporterEmail { get; set; }

    [DisplayName("Импортер Телефон")]
    [Column("P_IMPORTER_PHONE")]
    [MaxLength(20)]
    public string? ImporterPhone { get; set; }

    public ICollection<GtdT2> T2Rows { get; set; } = new List<GtdT2>();

}

[Table("T2")]
[Description("Товарные позиции декларации")]
public class GtdT2
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public long Id { get; set; }

    [DisplayName("ID родителя T1")]
    [Column("T1_ID")]
    public long T1Id { get; set; }

    public GtdT1? T1 { get; set; }

    [DisplayName("Поле 3")]
    [Column("P3T2")]
    public int? Field3 { get; set; }

    [DisplayName("Поле 4")]
    [Column("P4T2")]
    [MaxLength(50)]
    public string? Field4 { get; set; }

    [DisplayName("Поле 5")]
    [Column("P5T2")]
    public int? Field5 { get; set; }

    [DisplayName("Поле 8")]
    [Column("P8T2")]
    public int? Field8 { get; set; }

    [DisplayName("Поле 9")]
    [Column("P9T2")]
    public long? Field9 { get; set; }

    [DisplayName("Поле 10")]
    [Column("P10T2")]
    public int? Field10 { get; set; }

    [DisplayName("Поле 11")]
    [Column("P11T2")]
    public decimal? Field11 { get; set; }

    [DisplayName("Поле 13")]
    [Column("P13T2")]
    public int? Field13 { get; set; }

    [DisplayName("Поле 16")]
    [Column("P16T2")]
    [MaxLength(20)]
    public string? Field16 { get; set; }

    [DisplayName("Поле 17")]
    [Column("P17T2")]
    [MaxLength(20)]
    public string? Field17 { get; set; }

    [DisplayName("Поле 18")]
    [Column("P18T2")]
    public decimal? Field18 { get; set; }

    [DisplayName("Поле 21")]
    [Column("P21T2")]
    public decimal? Field21 { get; set; }

    [DisplayName("Поле 22")]
    [Column("P22T2")]
    public decimal? Field22 { get; set; }

    [DisplayName("Поле 23")]
    [Column("P23T2")]
    public int? Field23 { get; set; }

    [DisplayName("Поле 25")]
    [Column("P25T2")]
    public decimal? Field25 { get; set; }

    [DisplayName("Поле 26")]
    [Column("P26T2")]
    public decimal? Field26 { get; set; }

    [DisplayName("Поле 30")]
    [Column("P30T2")]
    [MaxLength(20)]
    public string? Field30 { get; set; }

    [DisplayName("Поле 37")]
    [Column("P37T2")]
    public decimal? Field37 { get; set; }

    [DisplayName("Поле 213")]
    [Column("P213T2")]
    [MaxLength(20)]
    public string? Field213 { get; set; }

    [DisplayName("Поле 214")]
    [Column("P214T2")]
    [MaxLength(20)]
    public string? Field214 { get; set; }

    public ICollection<GtdT4> T4Rows { get; set; } = new List<GtdT4>();

    public ICollection<GtdT7> T7Rows { get; set; } = new List<GtdT7>();

    public ICollection<GtdT9> T9Rows { get; set; } = new List<GtdT9>();

}

[Table("T4")]
[Description("Платежи по товару")]
public class GtdT4
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public long Id { get; set; }

    [DisplayName("ID родителя T2")]
    [Column("T2_ID")]
    public long T2Id { get; set; }

    public GtdT2? T2 { get; set; }

    [DisplayName("Поле 3")]
    [Column("P3T4")]
    public int? Field3 { get; set; }

    [DisplayName("Поле 4")]
    [Column("P4T4")]
    public decimal? Field4 { get; set; }

    [DisplayName("Поле 5")]
    [Column("P5T4")]
    public decimal? Field5 { get; set; }

    [DisplayName("Поле 6")]
    [Column("P6T4")]
    public decimal? Field6 { get; set; }

    [DisplayName("Поле 7")]
    [Column("P7T4")]
    public int? Field7 { get; set; }

    [DisplayName("Поле 8")]
    [Column("P8T4")]
    [MaxLength(20)]
    public string? Field8 { get; set; }

    [DisplayName("Поле 9")]
    [Column("P9T4")]
    public decimal? Field9 { get; set; }

}

[Table("T7")]
[Description("Описание/характеристики товара (31 графа)")]
public class GtdT7
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public long Id { get; set; }

    [DisplayName("ID родителя T2")]
    [Column("T2_ID")]
    public long T2Id { get; set; }

    public GtdT2? T2 { get; set; }

    [DisplayName("Поле 3")]
    [Column("P3T7")]
    public int? Field3 { get; set; }

    [DisplayName("Поле 4")]
    [Column("P4T7")]
    [MaxLength(50)]
    public string? Field4 { get; set; }

    [DisplayName("Поле 5")]
    [Column("P5T7")]
    public decimal? Field5 { get; set; }

}

[Table("T9")]
[Description("Документы по товарной позиции (приложенные/подтверждающие документы)")]
public class GtdT9
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public long Id { get; set; }

    [DisplayName("ID родителя T2")]
    [Column("T2_ID")]
    public long T2Id { get; set; }

    public GtdT2? T2 { get; set; }

    [DisplayName("Поле 4")]
    [Column("P4T9")]
    [MaxLength(20)]
    public string? Field4 { get; set; }

    [DisplayName("Поле 6")]
    [Column("P6T9")]
    [MaxLength(20)]
    public string? Field6 { get; set; }

    [DisplayName("Поле 7")]
    [Column("P7T9")]
    [MaxLength(20)]
    public string? Field7 { get; set; }

    [DisplayName("Поле 8")]
    [Column("P8T9")]
    public DateTime? Field8 { get; set; }

    [DisplayName("Поле 12")]
    [Column("P12T9")]
    [MaxLength(50)]
    public string? Field12 { get; set; }

    [DisplayName("Поле 200")]
    [Column("P200T9")]
    [MaxLength(20)]
    public string? Field200 { get; set; }
}
