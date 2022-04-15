using Microsoft.EntityFrameworkCore.Migrations;

namespace PayxApi.Migrations
{
    public partial class enteyau879 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BDStatus",
                table: "Salaries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BDStatus",
                table: "Salaries");
        }
    }
}
