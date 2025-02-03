
namespace BaseLibrary.Entities
{
    public class ProcessProductDetail
    {
        public Process Process { get; set; }
        public int ProcessId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

    }
}
