

namespace BaseLibrary.Entities
{
    public class ProductBreak
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
         public BreakDown  BreakDown { get; set; }
        public int BreakId { get; set; }

    }
}
