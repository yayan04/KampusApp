using Microsoft.EntityFrameworkCore.Migrations;

namespace KampusApp.Migrations
{
    public partial class AddSKSMatakuliahToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SKS",
                table: "Matakuliah",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKS",
                table: "Matakuliah");
        }
    }
}
