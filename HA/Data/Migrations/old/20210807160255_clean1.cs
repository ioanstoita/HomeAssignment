using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Data.Migrations
{
    public partial class clean1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StandardPrice",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StandardPrice",
                table: "Products");
        }
    }
}
