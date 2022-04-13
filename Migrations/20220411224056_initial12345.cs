using Microsoft.EntityFrameworkCore.Migrations;

namespace PayxApi.Migrations
{
    public partial class initial12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "GrossPay",
                table: "Payrolls",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AddColumn<int>(
                name: "BDStatus",
                table: "OtherDeductions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BDStatus",
                table: "Bonus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BDStatus",
                table: "OtherDeductions");

            migrationBuilder.DropColumn(
                name: "BDStatus",
                table: "Bonus");

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossPay",
                table: "Payrolls",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);
        }
    }
}
