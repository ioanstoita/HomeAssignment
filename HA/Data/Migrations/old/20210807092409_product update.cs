using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Data.Migrations
{
    public partial class productupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "retailerName",
                table: "Products",
                type: "nvarchar(320)",
                maxLength: 320,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "retailerName",
                table: "Products");
        }
    }
}
