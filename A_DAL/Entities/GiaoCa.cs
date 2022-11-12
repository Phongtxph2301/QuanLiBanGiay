namespace A_DAL.Entities
{
    public class GiaoCa
    {
        public GiaoCa()
        {

        }
        public Guid Id { get; set; }
        public Guid IdNhanVien { get; set; }
        public Guid IdNhanVienTiepQuan { get; set; }
        public string MaGiaoCa { get; set; } = null!;
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public float TienLai { get; set; } = 0!;
        public float TienDuTru { get; set; } = 0!;
        public float TienPhatSinh { get; set; } = 0!;
        public string ChuThich { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;

        public NhanVien IdNhanVienNavigation { get; set; } = null!;
        public NhanVien IdNhanVienTiepQuanNavigation { get; set; } = null!;
    }
}
