
namespace BaseLibrary.Entities
{
    public class SupplierPiece
    {

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public Piece Piece { get; set; }
        public int PieceId { get; set; }
    }
}
