namespace A_DAL.Entities
{
    public class ChiTietTheLoai
    {
        public ChiTietTheLoai()
        {
        }
        public Guid Id { get; set; }
        public Guid IdTheLoai { get; set; }
        public Guid IdChiTietGiay { get; set; }
        public int TrangThai { get; set; } = 0!;

        public TheLoai IdTheLoaiNavigation { get; set; } = null!;

        public ChiTietGiay IdChiTietGiayNavigation { get; set; } = null!;
    }
}
