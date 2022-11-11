namespace A_DAL.Entities
{
    public class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }
        public Guid Id { get; set; }

        public string MaChucVu { get; set; } = null!;
        public string TenChucVu { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;

        public ICollection<NhanVien> NhanViens { get; set; }
    }
}
