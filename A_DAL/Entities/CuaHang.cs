namespace A_DAL.Entities
{
    public class CuaHang
    {
        public CuaHang()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public Guid Id { get; set; }

        public string MaCuaHang { get; set; } = null!;
        public string TenCuaHang { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;

        public ICollection<NhanVien> NhanViens { get; set; }
    }
}