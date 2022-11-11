namespace A_DAL.Entities
{
    public class HoaDonChiTiet
    {
        public HoaDonChiTiet()
        {
        }
        public Guid Id { get; set; }
        public Guid IdChiTietGiay { get; set; }
        public Guid IdHoaDon { get; set; }
        public float DonGia { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;

        public ChiTietGiay IdChiTietGiayNavigation { get; set; } = null!;

        public HoaDon IdHoaDonNavigation { get; set; } = null!;
    }
}
