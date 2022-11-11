namespace A_DAL.Entities
{
    public class TheLoai
    {
        public TheLoai()
        {
            ChiTietTheLoais = new HashSet<ChiTietTheLoai>();
        }
        public Guid Id { get; set; }

        public string MaTheLoai { get; set; } = null!;
        public string TenTheLoai { get; set; } = null!;
        public Guid IdPhanCap { get; set; }
        public int TrangThai { get; set; } = 0!;

        public ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
    }
}
