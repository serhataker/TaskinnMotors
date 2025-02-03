

namespace BaseLibrary.Entities
{
    public class CustomerProduct
    {
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }


    }
}
