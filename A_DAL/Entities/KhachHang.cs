namespace A_DAL.Entities
{
    public class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        public Guid Id { get; set; }
        public string MaKhachHang { get; set; } = null!;
        public string TenKhachHang { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string SoCCCD { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;

        public ICollection<HoaDon> HoaDons { get; set; }
        public DiemTieuDung DiemTieuDung { get; set; } = null!;
    }
}
