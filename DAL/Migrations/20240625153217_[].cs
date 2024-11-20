using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHATLIEU",
                columns: table => new
                {
                    ID_CHATLIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCHATLIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHATLIEU__3912AF289F0644BF", x => x.ID_CHATLIEU);
                });

            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    ID_CHUCVU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCHUCVU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHUCVU__ACDE8E29231C707F", x => x.ID_CHUCVU);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    ID_KHACHHANG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HOVATEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__769C0DEB06885947", x => x.ID_KHACHHANG);
                });

            migrationBuilder.CreateTable(
                name: "KHUYENMAI",
                columns: table => new
                {
                    ID_KHUYENMAI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENKHUYENMAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAYTAO = table.Column<DateOnly>(type: "date", nullable: true),
                    NGAYHETHAN = table.Column<DateOnly>(type: "date", nullable: true),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SOPHANTRAMKHUYENMAI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    NGAYBATDAU = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHUYENMA__C2E0A21097623CEC", x => x.ID_KHUYENMAI);
                });

            migrationBuilder.CreateTable(
                name: "KICHTHUOC",
                columns: table => new
                {
                    ID_KICHTHUOC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIZE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KICHTHUO__854A5CB7E88DA72D", x => x.ID_KICHTHUOC);
                });

            migrationBuilder.CreateTable(
                name: "LOAISANPHAM",
                columns: table => new
                {
                    ID_LOAISANPHAM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENLOAISANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAISANP__D4D52375024DF897", x => x.ID_LOAISANPHAM);
                });

            migrationBuilder.CreateTable(
                name: "MAU",
                columns: table => new
                {
                    ID_MAU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENMAU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MAU__276D397D5D626397", x => x.ID_MAU);
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    ID_THUONGHIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTHUONGHIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THUONGHI__1A0670700CC3CDDC", x => x.ID_THUONGHIEU);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    ID_NHANVIEN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HOVATEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GIOITINH = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SDT = table.Column<int>(type: "int", nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ID_CHUCVU = table.Column<int>(type: "int", nullable: true),
                    NGAYSINH = table.Column<DateOnly>(type: "date", nullable: true),
                    MATKHAU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__DE90FCA31084BD1E", x => x.ID_NHANVIEN);
                    table.ForeignKey(
                        name: "FK__NHANVIEN__ID_CHU__33D4B598",
                        column: x => x.ID_CHUCVU,
                        principalTable: "CHUCVU",
                        principalColumn: "ID_CHUCVU");
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    ID_HOADON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TONGTIEN = table.Column<double>(type: "float", nullable: true),
                    ID_KHACHHANG = table.Column<int>(type: "int", nullable: true),
                    ID_KHUYENMAI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADON__018FF0B57137B976", x => x.ID_HOADON);
                    table.ForeignKey(
                        name: "FK__HOADON__ID_KHACH__403A8C7D",
                        column: x => x.ID_KHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "ID_KHACHHANG");
                    table.ForeignKey(
                        name: "FK__HOADON__ID_KHUYE__412EB0B6",
                        column: x => x.ID_KHUYENMAI,
                        principalTable: "KHUYENMAI",
                        principalColumn: "ID_KHUYENMAI");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    ID_SANPHAM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_THUONGHIEU = table.Column<int>(type: "int", nullable: true),
                    TENSANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__216A05531AAF96E4", x => x.ID_SANPHAM);
                    table.ForeignKey(
                        name: "FK__SANPHAM__ID_THUO__36B12243",
                        column: x => x.ID_THUONGHIEU,
                        principalTable: "THUONGHIEU",
                        principalColumn: "ID_THUONGHIEU");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMCT",
                columns: table => new
                {
                    ID_SANPHAMCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_KICHTHUOC = table.Column<int>(type: "int", nullable: true),
                    ID_MAU = table.Column<int>(type: "int", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    ID_CHATLIEU = table.Column<int>(type: "int", nullable: true),
                    ID_SANPHAM = table.Column<int>(type: "int", nullable: true),
                    DONGIA = table.Column<double>(type: "float", nullable: true),
                    ID_LOAISANPHAM = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAMC__99B856117AD9B018", x => x.ID_SANPHAMCT);
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__ID_CH__3B75D760",
                        column: x => x.ID_CHATLIEU,
                        principalTable: "CHATLIEU",
                        principalColumn: "ID_CHATLIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__ID_KI__398D8EEE",
                        column: x => x.ID_KICHTHUOC,
                        principalTable: "KICHTHUOC",
                        principalColumn: "ID_KICHTHUOC");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__ID_LO__3D5E1FD2",
                        column: x => x.ID_LOAISANPHAM,
                        principalTable: "LOAISANPHAM",
                        principalColumn: "ID_LOAISANPHAM");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__ID_MA__3A81B327",
                        column: x => x.ID_MAU,
                        principalTable: "MAU",
                        principalColumn: "ID_MAU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__ID_SA__3C69FB99",
                        column: x => x.ID_SANPHAM,
                        principalTable: "SANPHAM",
                        principalColumn: "ID_SANPHAM");
                });

            migrationBuilder.CreateTable(
                name: "HOADONCT",
                columns: table => new
                {
                    ID_HOADONCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    GIASP = table.Column<double>(type: "float", nullable: true),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ID_SANPHAMCT = table.Column<int>(type: "int", nullable: true),
                    ID_HOADON = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADONCT__CB5C3B207A9A076B", x => x.ID_HOADONCT);
                    table.ForeignKey(
                        name: "FK__HOADONCT__ID_HOA__5CD6CB2B",
                        column: x => x.ID_HOADON,
                        principalTable: "HOADON",
                        principalColumn: "ID_HOADON");
                    table.ForeignKey(
                        name: "FK__HOADONCT__ID_SAN__5BE2A6F2",
                        column: x => x.ID_SANPHAMCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "ID_SANPHAMCT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_ID_KHACHHANG",
                table: "HOADON",
                column: "ID_KHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_ID_KHUYENMAI",
                table: "HOADON",
                column: "ID_KHUYENMAI");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCT_ID_HOADON",
                table: "HOADONCT",
                column: "ID_HOADON");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCT_ID_SANPHAMCT",
                table: "HOADONCT",
                column: "ID_SANPHAMCT");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_ID_CHUCVU",
                table: "NHANVIEN",
                column: "ID_CHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_ID_THUONGHIEU",
                table: "SANPHAM",
                column: "ID_THUONGHIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_ID_CHATLIEU",
                table: "SANPHAMCT",
                column: "ID_CHATLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_ID_KICHTHUOC",
                table: "SANPHAMCT",
                column: "ID_KICHTHUOC");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_ID_LOAISANPHAM",
                table: "SANPHAMCT",
                column: "ID_LOAISANPHAM");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_ID_MAU",
                table: "SANPHAMCT",
                column: "ID_MAU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_ID_SANPHAM",
                table: "SANPHAMCT",
                column: "ID_SANPHAM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HOADONCT");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "SANPHAMCT");

            migrationBuilder.DropTable(
                name: "CHUCVU");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "KHUYENMAI");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropTable(
                name: "KICHTHUOC");

            migrationBuilder.DropTable(
                name: "LOAISANPHAM");

            migrationBuilder.DropTable(
                name: "MAU");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");
        }
    }
}
