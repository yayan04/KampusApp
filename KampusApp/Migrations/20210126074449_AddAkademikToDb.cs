using Microsoft.EntityFrameworkCore.Migrations;

namespace KampusApp.Migrations
{
    public partial class AddAkademikToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Akademik",
                columns: table => new
                {
                    IDAkademik = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIM = table.Column<int>(nullable: false),
                    NamaMahasiswa = table.Column<string>(nullable: true),
                    IDMatakuliah = table.Column<int>(nullable: false),
                    NamaMatakuliah = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Akademik", x => x.IDAkademik);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Akademik");
        }
    }
}
