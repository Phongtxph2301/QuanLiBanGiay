namespace A_DAL.Entities
{
    public class MauSac
    {
        public MauSac()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }
        public Guid Id { get; set; }
        public string MaMauSac { get; set; } = null!;
        public string TenMauSac { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
