namespace A_DAL.Entities
{
    public class ChiTietThanhToan
    {
        public ChiTietThanhToan()
        {
        }
        public Guid Id { get; set; }
        public Guid IdPhuongThucThanhToan { get; set; }
        public Guid IdHoaDon { get; set; }
        public float SoTienThanhToan { get; set; } = 0!;
        public string GhiChu { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;

        public PhuongThucThanhToan IdPhuongThucThanhToanNavigation { get; set; } = null!;

        public HoaDon IdHoaDonNavigation { get; set; } = null!;
    }
}
