

namespace BaseLibrary.Entities
{
    public class Process : BaseEntity
    {
        public float ProcessTime { get; set; }
        public string ProcessDescription { get; set; }
        public string ProcessType { get; set; }
        public decimal UnitPrice { get; set; }
        public Piece Piece { get; set; }
        public string PieceId { get; set; }
    }
}