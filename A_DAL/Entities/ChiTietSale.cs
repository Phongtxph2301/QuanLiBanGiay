namespace A_DAL.Entities
{
    public class ChiTietSale
    {
        public ChiTietSale()
        {
        }
        public Guid Id { get; set; }
        public Guid IdSale { get; set; }
        public Guid IdChiTietGiay { get; set; }
        public int TrangThai { get; set; } = 0!;

        public Sale IdSaleNavigation { get; set; } = null!;

        public ChiTietGiay IdChiTietGiayNavigation { get; set; } = null!;
    }
}
