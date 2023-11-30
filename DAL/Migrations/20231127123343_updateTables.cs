using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAdvance.DAL.Migrations
{
  public partial class updateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "Float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "NVarChar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "PPPPP",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "NText",
                maxLength: 100,
                nullable: false,
                defaultValue: "XXXXXX",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "Float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVarChar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "PPPPP");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NText",
                oldMaxLength: 100,
                oldDefaultValue: "XXXXXX");
        }}
}
