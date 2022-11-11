namespace A_DAL.Entities
{
    public class ChieuCaoDeGiay
    {
        public ChieuCaoDeGiay()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }
        public Guid Id { get; set; }
        public string MaKichCo { get; set; } = null!;
        public int KichCo { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
