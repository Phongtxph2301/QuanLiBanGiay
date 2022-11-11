namespace A_DAL.Entities
{
    public class LichSuDiemTieuDung
    {
        public LichSuDiemTieuDung()
        {
        }
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdDiemTieuDung { get; set; }
        public Guid IdQuyDoi { get; set; }
        public float GiaTriQuyDoi { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;

        public HoaDon IdHoaDonNavigation { get; set; } = null!;

        public DiemTieuDung IdDiemTieuDungNavigation { get; set; } = null!;

        public QuyDoi IdQuyDoiNavigation { get; set; } = null!;
    }
}
