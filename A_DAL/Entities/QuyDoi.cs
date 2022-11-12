namespace A_DAL.Entities
{
    public class QuyDoi
    {
        public QuyDoi()
        {
            LichSuDiemTieuDungs = new HashSet<LichSuDiemTieuDung>();
        }
        public Guid Id { get; set; }
        public string MaQuyDoi { get; set; } = null!;
        public float TiLeQuyDoi { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;

        public ICollection<LichSuDiemTieuDung> LichSuDiemTieuDungs { get; set; }
    }
}
