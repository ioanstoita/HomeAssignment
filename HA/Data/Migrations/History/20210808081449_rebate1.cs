using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Data.Migrations
{
    public partial class rebate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rebates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RetailerName = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    RebateType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)0),
                    RebateValue = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rebates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rebates");
        }
    }
}
