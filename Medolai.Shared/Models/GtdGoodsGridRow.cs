using System.ComponentModel;

namespace Medolai.Shared.Models
{
    public sealed class GtdGoodsGridRow
    {
        public long Id { get; set; }

        [DisplayName("№ товара")]
        public int? ItemNo { get; set; }                    // T2.P3T2

        [DisplayName("ТН ВЭД")]
        public long? HsCode { get; set; }                 // T2.P9T2

        [DisplayName("Наименование товара")]
        public string? Name { get; set; }                   // T2.P4T2

        [DisplayName("Количество (из XML)")]
        public decimal? Quantity { get; set; }              // T2.P11T2 (по заполненности)

        [DisplayName("Вес/параметр (из XML)")]
        public decimal? WeightOrParam { get; set; }         // T2.P18T2 (по заполненности)

        [DisplayName("Платежи по товару")]
        public string? PaymentsSummary { get; set; }

        [DisplayName("Документы по товару")]
        public string? DocumentsSummary { get; set; }
    }
}
