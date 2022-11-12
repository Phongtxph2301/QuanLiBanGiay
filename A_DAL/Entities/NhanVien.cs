namespace A_DAL.Entities
{
    public class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            GiaoCas = new HashSet<GiaoCa>();
        }
        public Guid Id { get; set; }
        public Guid IdChucVu { get; set; }
        public Guid IdCuaHang { get; set; }
        public string MaNhanVien { get; set; } = null!;
        public string TenNhanVien { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public int GioiTinh { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;

        public ChucVu IdChucVuNavigation { get; set; } = null!;

        public CuaHang IdCuaHangNavigation { get; set; } = null!;

        public ICollection<HoaDon> HoaDons { get; set; }
        public ICollection<GiaoCa> GiaoCas { get; set; }
        public ICollection<GiaoCa> GiaoCaTiepQuans { get; set; }
    }
}
