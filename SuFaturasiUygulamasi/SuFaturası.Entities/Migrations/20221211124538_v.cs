using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuFaturası.Entities.Migrations
{
    public partial class v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SonIndex = table.Column<double>(type: "float", nullable: false),
                    IlkIndex = table.Column<double>(type: "float", nullable: false),
                    KullanimYeri = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "SuFaturasilar",
                columns: table => new
                {
                    SuFaturasiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuFaturasilar", x => x.SuFaturasiID);
                    table.ForeignKey(
                        name: "FK_SuFaturasilar_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuFaturasilar_KullaniciID",
                table: "SuFaturasilar",
                column: "KullaniciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuFaturasilar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
