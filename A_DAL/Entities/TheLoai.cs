namespace A_DAL.Entities
{
    public class TheLoai
    {
        public TheLoai()
        {
            ChiTietTheLoais = new HashSet<ChiTietTheLoai>();
            TheLoais = new HashSet<TheLoai>();
        }
        public Guid Id { get; set; }

        public string MaTheLoai { get; set; } = null!;
        public string TenTheLoai { get; set; } = null!;
        public Guid IdPhanCap { get; set; }
        public int TrangThai { get; set; } = 0!;
        public TheLoai IdTheLoaiNavigation { get; set; } = null!;
        public ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
        public ICollection<TheLoai> TheLoais { get; set; }
    }
}
