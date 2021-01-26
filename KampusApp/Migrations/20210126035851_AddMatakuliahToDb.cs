using Microsoft.EntityFrameworkCore.Migrations;

namespace KampusApp.Migrations
{
    public partial class AddMatakuliahToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matakuliah",
                columns: table => new
                {
                    IdMatakuliah = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama_Matakuliah = table.Column<string>(nullable: false),
                    NIM = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matakuliah", x => x.IdMatakuliah);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matakuliah");
        }
    }
}
