namespace A_DAL.Entities
{
    public class Size
    {
        public Size()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }
        public Guid Id { get; set; }

        public string MaSize { get; set; } = null!;
        public string TenSize { get; set; } = null!;
        public int SoSize { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
