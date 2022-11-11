namespace A_DAL.Entities
{
    public class Giay
    {
        public Giay()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }
        public Guid Id { get; set; }
        public string MaGiay { get; set; } = null!;
        public string TenGiay { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
