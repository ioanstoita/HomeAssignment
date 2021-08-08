using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Data.Migrations
{
    public partial class rebpte0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RebatePercent",
                table: "Rebates");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Rebates",
                type: "nvarchar(320)",
                maxLength: 320,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(320)",
                oldMaxLength: 320);

            migrationBuilder.AddColumn<byte>(
                name: "RebateType",
                table: "Rebates",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RebateType",
                table: "Rebates");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Rebates",
                type: "nvarchar(320)",
                maxLength: 320,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(320)",
                oldMaxLength: 320,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RebatePercent",
                table: "Rebates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
