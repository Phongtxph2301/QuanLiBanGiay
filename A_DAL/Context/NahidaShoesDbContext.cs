using A_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Context
{
    public class NahidaShoesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Đổi connectionString để connect với co sở dữ liệu của mình
            _ = optionsBuilder.UseSqlServer("Data Source=ACER\\SQLEXPRESS;Initial Catalog=NahidaShoes;User ID=sa;Password=191023;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.Entity<ChieuCaoDeGiay>().HasKey(c => c.Id);
            _ = builder.Entity<ChieuCaoDeGiay>().Property(c => c.Id);
            _ = builder.Entity<ChieuCaoDeGiay>().HasIndex(c => c.MaKichCo).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietGiay>().HasKey(c => c.Id);
            _ = builder.Entity<ChiTietGiay>().Property(c => c.Id);
            _ = builder.Entity<ChiTietGiay>().HasIndex(c => new { c.IdMauSac, c.IdSize, c.IdNsx, c.IdHangGiay, c.IdChieuCaoDeGiay, c.IdGiay }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietSale>().HasKey(c => c.Id);
            _ = builder.Entity<ChiTietSale>().Property(c => c.Id);
            _ = builder.Entity<ChiTietSale>().HasIndex(c => new { c.IdChiTietGiay, c.IdSale }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietTheLoai>().HasKey(c => c.Id);
            _ = builder.Entity<ChiTietTheLoai>().Property(c => c.Id);
            _ = builder.Entity<ChiTietTheLoai>().HasIndex(c => new { c.IdChiTietGiay, c.IdTheLoai }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChucVu>().HasKey(c => c.Id);
            _ = builder.Entity<ChucVu>().Property(c => c.Id);
            _ = builder.Entity<ChucVu>().HasIndex(c => c.MaChucVu).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<CuaHang>().HasKey(c => c.Id);
            _ = builder.Entity<CuaHang>().Property(c => c.Id);
            _ = builder.Entity<CuaHang>().HasIndex(c => c.MaCuaHang).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<DiemTieuDung>().HasKey(c => c.Id);
            _ = builder.Entity<DiemTieuDung>().Property(c => c.Id);
            _ = builder.Entity<DiemTieuDung>().HasIndex(c => c.MaDiemTieuDung).IsUnique(true);
            _ = builder.Entity<DiemTieuDung>().HasIndex(c => c.IdKhachHang).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<GiaoCa>().HasKey(c => c.Id);
            _ = builder.Entity<GiaoCa>().Property(c => c.Id);
            _ = builder.Entity<GiaoCa>().HasIndex(c => c.MaGiaoCa).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Giay>().HasKey(c => c.Id);
            _ = builder.Entity<Giay>().Property(c => c.Id);
            _ = builder.Entity<Giay>().HasIndex(c => c.MaGiay).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<HangGiay>().HasKey(c => c.Id);
            _ = builder.Entity<HangGiay>().Property(c => c.Id);
            _ = builder.Entity<HangGiay>().HasIndex(c => c.MaHangGiay).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<HoaDon>().HasKey(c => c.Id);
            _ = builder.Entity<HoaDon>().Property(c => c.Id);
            _ = builder.Entity<HoaDon>().HasIndex(c => c.MaHoaDon).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<HoaDonChiTiet>().HasKey(c => c.Id);
            _ = builder.Entity<HoaDonChiTiet>().Property(c => c.Id);
            _ = builder.Entity<HoaDonChiTiet>().HasIndex(c => new { c.IdChiTietGiay, c.IdHoaDon }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<KhachHang>().HasKey(c => c.Id);
            _ = builder.Entity<KhachHang>().Property(c => c.Id);
            _ = builder.Entity<KhachHang>().HasIndex(c => c.MaKhachHang).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<LichSuDiemTieuDung>().HasKey(c => c.Id);
            _ = builder.Entity<LichSuDiemTieuDung>().Property(c => c.Id);
            _ = builder.Entity<LichSuDiemTieuDung>().HasIndex(c => new { c.IdHoaDon, c.IdDiemTieuDung, c.IdQuyDoi }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<MauSac>().HasKey(c => c.Id);
            _ = builder.Entity<MauSac>().Property(c => c.Id);
            _ = builder.Entity<MauSac>().HasIndex(c => c.MaMauSac).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<NhanVien>().HasKey(c => c.Id);
            _ = builder.Entity<NhanVien>().Property(c => c.Id);
            _ = builder.Entity<NhanVien>().HasIndex(c => c.MaNhanVien).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Nsx>().HasKey(c => c.Id);
            _ = builder.Entity<Nsx>().Property(c => c.Id);
            _ = builder.Entity<Nsx>().HasIndex(c => c.MaNsx).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<QuyDoi>().HasKey(c => c.Id);
            _ = builder.Entity<QuyDoi>().Property(c => c.Id);
            _ = builder.Entity<QuyDoi>().HasIndex(c => c.MaQuyDoi).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Sale>().HasKey(c => c.Id);
            _ = builder.Entity<Sale>().Property(c => c.Id);
            _ = builder.Entity<Sale>().HasIndex(c => c.MaGiamGia).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Size>().HasKey(c => c.Id);
            _ = builder.Entity<Size>().Property(c => c.Id);
            _ = builder.Entity<Size>().HasIndex(c => c.MaSize).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<TheLoai>().HasKey(c => c.Id);
            _ = builder.Entity<TheLoai>().Property(c => c.Id);
            _ = builder.Entity<TheLoai>().HasIndex(c => c.MaTheLoai).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietGiay>().HasOne<MauSac>(s => s.IdMauSacNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdMauSac).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<Nsx>(s => s.IdNsxNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdNsx).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<Size>(s => s.IdSizeNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdSize).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<HangGiay>(s => s.IdHangGiayNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdHangGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<ChieuCaoDeGiay>(s => s.IdChieuCaoDeGiayNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdChieuCaoDeGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<Giay>(s => s.IdGiayNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdGiay).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<ChiTietSale>().HasOne<ChiTietGiay>(s => s.IdChiTietGiayNavigation).WithMany(g => g.ChiTietSales).HasForeignKey(s => s.IdChiTietGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietSale>().HasOne<Sale>(s => s.IdSaleNavigation).WithMany(g => g.ChiTietSales).HasForeignKey(s => s.IdSale).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<ChiTietTheLoai>().HasOne<ChiTietGiay>(s => s.IdChiTietGiayNavigation).WithMany(g => g.ChiTietTheLoais).HasForeignKey(s => s.IdChiTietGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietTheLoai>().HasOne<TheLoai>(s => s.IdTheLoaiNavigation).WithMany(g => g.ChiTietTheLoais).HasForeignKey(s => s.IdTheLoai).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<HoaDonChiTiet>().HasOne<ChiTietGiay>(s => s.IdChiTietGiayNavigation).WithMany(g => g.HoaDonChiTiets).HasForeignKey(s => s.IdChiTietGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<HoaDonChiTiet>().HasOne<HoaDon>(s => s.IdHoaDonNavigation).WithMany(g => g.HoaDonChiTiets).HasForeignKey(s => s.IdHoaDon).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<LichSuDiemTieuDung>().HasOne<DiemTieuDung>(s => s.IdDiemTieuDungNavigation).WithMany(g => g.LichSuDiemTieuDungs).HasForeignKey(s => s.IdDiemTieuDung).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<LichSuDiemTieuDung>().HasOne<QuyDoi>(s => s.IdQuyDoiNavigation).WithMany(g => g.LichSuDiemTieuDungs).HasForeignKey(s => s.IdQuyDoi).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<LichSuDiemTieuDung>().HasOne<HoaDon>(s => s.IdHoaDonNavigation).WithMany(g => g.LichSuDiemTieuDungs).HasForeignKey(s => s.IdHoaDon).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<HoaDon>().HasOne<KhachHang>(s => s.IdKhachHangNavigation).WithMany(g => g.HoaDons).HasForeignKey(s => s.IdKhachHang).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<HoaDon>().HasOne<NhanVien>(s => s.IdNhanVienNavigation).WithMany(g => g.HoaDons).HasForeignKey(s => s.IdNhanVien).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<GiaoCa>().HasOne<NhanVien>(s => s.IdNhanVienNavigation).WithMany(g => g.GiaoCas).HasForeignKey(s => s.IdNhanVien).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<GiaoCa>().HasOne<NhanVien>(s => s.IdNhanVienTiepQuanNavigation).WithMany(g => g.GiaoCaTiepQuans).HasForeignKey(s => s.IdNhanVienTiepQuan).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<NhanVien>().HasOne<ChucVu>(s => s.IdChucVuNavigation).WithMany(g => g.NhanViens).HasForeignKey(s => s.IdChucVu).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<NhanVien>().HasOne<CuaHang>(s => s.IdCuaHangNavigation).WithMany(g => g.NhanViens).HasForeignKey(s => s.IdCuaHang).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<DiemTieuDung>().HasOne<KhachHang>(s => s.KhachHang).WithOne(g => g.DiemTieuDung).HasForeignKey<DiemTieuDung>(s => s.IdKhachHang).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<TheLoai>().HasOne<TheLoai>(s => s.IdTheLoaiNavigation).WithMany(g => g.TheLoais).HasForeignKey(s => s.IdPhanCap).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<ChiTietThanhToan>().HasOne<HoaDon>(s => s.IdHoaDonNavigation).WithMany(g => g.ChiTietThanhToans).HasForeignKey(s => s.IdHoaDon).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietThanhToan>().HasOne<PhuongThucThanhToan>(s => s.IdPhuongThucThanhToanNavigation).WithMany(g => g.ChiTietThanhToans).HasForeignKey(s => s.IdPhuongThucThanhToan).OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<MauSac> MauSac { get; set; }
        public DbSet<Nsx> Nsx { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Giay> Giay { get; set; }
        public DbSet<HangGiay> HangGiay { get; set; }
        public DbSet<ChieuCaoDeGiay> ChieuCaoDeGiay { get; set; }
        public DbSet<ChiTietGiay> ChiTietGiay { get; set; }
        public DbSet<ChiTietSale> ChiTietSale { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<ChiTietTheLoai> ChiTietTheLoai { get; set; }
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<CuaHang> CuaHang { get; set; }
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<GiaoCa> GiaoCa { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LichSuDiemTieuDung> LichSuDiemTieuDung { get; set; }
        public DbSet<QuyDoi> QuyDoi { get; set; }
        public DbSet<DiemTieuDung> DiemTieuDung { get; set; }
    }
}
