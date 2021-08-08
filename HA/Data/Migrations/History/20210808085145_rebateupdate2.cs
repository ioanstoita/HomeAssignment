using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Data.Migrations
{
    public partial class rebateupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RebateType",
                table: "Rebates");

            migrationBuilder.RenameColumn(
                name: "RebateValue",
                table: "Rebates",
                newName: "RebatePercent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RebatePercent",
                table: "Rebates",
                newName: "RebateValue");

            migrationBuilder.AddColumn<byte>(
                name: "RebateType",
                table: "Rebates",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
