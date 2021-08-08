using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "test",
                table: "Rebates",
                type: "float",
                nullable: false,
                defaultValue: 5.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Rebates");
        }
    }
}
