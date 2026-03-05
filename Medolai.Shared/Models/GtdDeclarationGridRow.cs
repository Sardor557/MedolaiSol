using System.Collections.Generic;
using System.ComponentModel;

namespace Medolai.Shared.Models
{
    public sealed class GtdDeclarationGridRow
    {
        public long Id { get; set; }

        [DisplayName("Тип декларации")]
        public string DeclarationType { get; set; }        // T1.P2T1

        [DisplayName("Импортер")]
        public string ImporterName { get; set; }           // T1.P22T1

        [DisplayName("Адрес импортера")]
        public string ImporterAddress { get; set; }        // T1.P23T1 / P32T1

        [DisplayName("Телефон (из XML)")]
        public string ImporterPhone { get; set; }          // T1.P12T1 / P244T1

        [DisplayName("Email (из XML)")]
        public string ImporterEmail { get; set; }          // T1.P14T1

        [DisplayName("Контрагент/экспортер")]
        public string ExporterName { get; set; }           // T1.P39T1

        [DisplayName("Сумма (из XML)")]
        public decimal? TotalAmount { get; set; }           // T1.P37T1

        [DisplayName("Кол-во товаров")]
        public int GoodsCount { get; set; }

        [DisplayName("Товары (кратко)")]
        public string GoodsSummary { get; set; }

        [DisplayName("Документы (кратко)")]
        public string DocumentsSummary { get; set; }

        [DisplayName("Платежи (кратко)")]
        public string PaymentsSummary { get; set; }

        [DisplayName("Товары")]
        public List<GtdGoodsGridRow> Goods { get; set; } = new();
    }
}
