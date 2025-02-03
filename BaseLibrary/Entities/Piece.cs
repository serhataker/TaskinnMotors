
namespace BaseLibrary.Entities
{
    public class Piece:BaseEntity
    {
        public string SKUCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string StockCode {  get; set; }
        

    }
}
