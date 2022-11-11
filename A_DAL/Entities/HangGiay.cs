namespace A_DAL.Entities
{
    public class HangGiay
    {
        public HangGiay()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }
        public Guid Id { get; set; }
        public string MaHangGiay { get; set; } = null!;
        public string TenHangGiay { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
