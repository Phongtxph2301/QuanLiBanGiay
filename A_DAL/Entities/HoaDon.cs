namespace A_DAL.Entities
{
    public class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            LichSuDiemTieuDungs = new HashSet<LichSuDiemTieuDung>();
            ChiTietThanhToans = new HashSet<ChiTietThanhToan>();
        }
        public Guid Id { get; set; }
        public string MaHoaDon { get; set; } = null!;
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public float GiamGia { get; set; } = 0!;
        public string GhiChu { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;

        public KhachHang IdKhachHangNavigation { get; set; } = null!;

        public NhanVien IdNhanVienNavigation { get; set; } = null!;

        public ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

        public ICollection<LichSuDiemTieuDung> LichSuDiemTieuDungs { get; set; }
        public ICollection<ChiTietThanhToan> ChiTietThanhToans { get; set; }
    }
}
