using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADAL.Migrations
{
    /// <inheritdoc />
    public partial class createdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "ChieuCaoDeGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKichCo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KichCo = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChieuCaoDeGiay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCuaHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCuaHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_CuaHang", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Giay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Giay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "HangGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHangGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHangGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_HangGiay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoCCCD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaMauSac = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNsx = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "QuyDoi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaQuyDoi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiaTriQuyDoi = table.Column<float>(type: "real", nullable: false),
                    GiaTriSauQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_QuyDoi", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiamGia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuaChonGiamGia = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Sale", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSize = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoSize = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Size", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPhanCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_TheLoai", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCuaHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_NhanVien", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IdCuaHang",
                        column: x => x.IdCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "DiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDiemTieuDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoDiem = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DiemTieuDung", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_DiemTieuDung_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChiTietGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChieuCaoDeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaBan = table.Column<float>(type: "real", nullable: false),
                    GiaNhap = table.Column<float>(type: "real", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChiTietGiay", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_ChieuCaoDeGiay_IdChieuCaoDeGiay",
                        column: x => x.IdChieuCaoDeGiay,
                        principalTable: "ChieuCaoDeGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Giay_IdGiay",
                        column: x => x.IdGiay,
                        principalTable: "Giay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_HangGiay_IdHangGiay",
                        column: x => x.IdHangGiay,
                        principalTable: "HangGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Nsx_IdNsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "GiaoCa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiaoCa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienLai = table.Column<float>(type: "real", nullable: false),
                    TienDuTru = table.Column<float>(type: "real", nullable: false),
                    TienPhatSinh = table.Column<float>(type: "real", nullable: false),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_GiaoCa", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiamGia = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_HoaDon", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChiTietSale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSale = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChiTietSale", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietSale_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietSale_Sale_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChiTietTheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChiTietTheLoai", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietTheLoai_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietTheLoai_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "LichSuDiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiemTieuDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuyDoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaTriQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_LichSuDiemTieuDung", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_DiemTieuDung_IdDiemTieuDung",
                        column: x => x.IdDiemTieuDung,
                        principalTable: "DiemTieuDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_QuyDoi_IdQuyDoi",
                        column: x => x.IdQuyDoi,
                        principalTable: "QuyDoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChieuCaoDeGiay_MaKichCo",
                table: "ChieuCaoDeGiay",
                column: "MaKichCo",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdChieuCaoDeGiay",
                table: "ChiTietGiay",
                column: "IdChieuCaoDeGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdGiay",
                table: "ChiTietGiay",
                column: "IdGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdHangGiay",
                table: "ChiTietGiay",
                column: "IdHangGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdMauSac_IdSize_IdNsx_IdHangGiay_IdChieuCaoDeGiay_IdGiay",
                table: "ChiTietGiay",
                columns: new[] { "IdMauSac", "IdSize", "IdNsx", "IdHangGiay", "IdChieuCaoDeGiay", "IdGiay" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdNsx",
                table: "ChiTietGiay",
                column: "IdNsx");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdSize",
                table: "ChiTietGiay",
                column: "IdSize");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdChiTietGiay_IdSale",
                table: "ChiTietSale",
                columns: new[] { "IdChiTietGiay", "IdSale" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdSale",
                table: "ChiTietSale",
                column: "IdSale");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdChiTietGiay_IdTheLoai",
                table: "ChiTietTheLoai",
                columns: new[] { "IdChiTietGiay", "IdTheLoai" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdTheLoai",
                table: "ChiTietTheLoai",
                column: "IdTheLoai");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChucVu_MaChucVu",
                table: "ChucVu",
                column: "MaChucVu",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_CuaHang_MaCuaHang",
                table: "CuaHang",
                column: "MaCuaHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_IdKhachHang",
                table: "DiemTieuDung",
                column: "IdKhachHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_MaDiemTieuDung",
                table: "DiemTieuDung",
                column: "MaDiemTieuDung",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVien",
                table: "GiaoCa",
                column: "IdNhanVien");

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_MaGiaoCa",
                table: "GiaoCa",
                column: "MaGiaoCa",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Giay_MaGiay",
                table: "Giay",
                column: "MaGiay",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HangGiay_MaHangGiay",
                table: "HangGiay",
                column: "MaHangGiay",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHoaDon",
                table: "HoaDon",
                column: "MaHoaDon",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietGiay_IdHoaDon",
                table: "HoaDonChiTiet",
                columns: new[] { "IdChiTietGiay", "IdHoaDon" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            _ = migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaKhachHang",
                table: "KhachHang",
                column: "MaKhachHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdDiemTieuDung",
                table: "LichSuDiemTieuDung",
                column: "IdDiemTieuDung");

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdHoaDon_IdDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                columns: new[] { "IdHoaDon", "IdDiemTieuDung", "IdQuyDoi" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                column: "IdQuyDoi");

            _ = migrationBuilder.CreateIndex(
                name: "IX_MauSac_MaMauSac",
                table: "MauSac",
                column: "MaMauSac",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCuaHang",
                table: "NhanVien",
                column: "IdCuaHang");

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaNhanVien",
                table: "NhanVien",
                column: "MaNhanVien",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Nsx_MaNsx",
                table: "Nsx",
                column: "MaNsx",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_QuyDoi_MaQuyDoi",
                table: "QuyDoi",
                column: "MaQuyDoi",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Sale_MaGiamGia",
                table: "Sale",
                column: "MaGiamGia",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Size_MaSize",
                table: "Size",
                column: "MaSize",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_TheLoai_MaTheLoai",
                table: "TheLoai",
                column: "MaTheLoai",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "ChiTietSale");

            _ = migrationBuilder.DropTable(
                name: "ChiTietTheLoai");

            _ = migrationBuilder.DropTable(
                name: "GiaoCa");

            _ = migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            _ = migrationBuilder.DropTable(
                name: "LichSuDiemTieuDung");

            _ = migrationBuilder.DropTable(
                name: "Sale");

            _ = migrationBuilder.DropTable(
                name: "TheLoai");

            _ = migrationBuilder.DropTable(
                name: "ChiTietGiay");

            _ = migrationBuilder.DropTable(
                name: "DiemTieuDung");

            _ = migrationBuilder.DropTable(
                name: "HoaDon");

            _ = migrationBuilder.DropTable(
                name: "QuyDoi");

            _ = migrationBuilder.DropTable(
                name: "ChieuCaoDeGiay");

            _ = migrationBuilder.DropTable(
                name: "Giay");

            _ = migrationBuilder.DropTable(
                name: "HangGiay");

            _ = migrationBuilder.DropTable(
                name: "MauSac");

            _ = migrationBuilder.DropTable(
                name: "Nsx");

            _ = migrationBuilder.DropTable(
                name: "Size");

            _ = migrationBuilder.DropTable(
                name: "KhachHang");

            _ = migrationBuilder.DropTable(
                name: "NhanVien");

            _ = migrationBuilder.DropTable(
                name: "ChucVu");

            _ = migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
