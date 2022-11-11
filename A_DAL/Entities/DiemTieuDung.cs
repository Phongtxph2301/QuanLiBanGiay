namespace A_DAL.Entities
{
    public class DiemTieuDung
    {
        public DiemTieuDung()
        {
            LichSuDiemTieuDungs = new HashSet<LichSuDiemTieuDung>();
        }
        public Guid Id { get; set; }

        public string MaDiemTieuDung { get; set; } = null!;
        public Guid IdKhachHang { get; set; }
        public float SoDiem { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;
        public KhachHang KhachHang { get; set; } = null!;
        public ICollection<LichSuDiemTieuDung> LichSuDiemTieuDungs { get; set; }
    }
}
