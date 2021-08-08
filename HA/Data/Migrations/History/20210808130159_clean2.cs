using Microsoft.EntityFrameworkCore.Migrations;

namespace HA.Data.Migrations
{
    public partial class clean2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Rebates");

            migrationBuilder.DropColumn(
                name: "RetailerName",
                table: "Rebates");

            migrationBuilder.DropColumn(
                name: "RetailerName",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Rebates",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RetailerId",
                table: "Rebates",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RetailerId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleId1",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "AspNetUserClaims",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rebates_CustomerId",
                table: "Rebates",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rebates_RetailerId",
                table: "Rebates",
                column: "RetailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RetailerId",
                table: "Products",
                column: "RetailerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId1",
                table: "AspNetUserClaims",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId1",
                table: "AspNetUserClaims",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_RetailerId",
                table: "Products",
                column: "RetailerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rebates_AspNetUsers_CustomerId",
                table: "Rebates",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rebates_AspNetUsers_RetailerId",
                table: "Rebates",
                column: "RetailerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId1",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_RetailerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Rebates_AspNetUsers_CustomerId",
                table: "Rebates");

            migrationBuilder.DropForeignKey(
                name: "FK_Rebates_AspNetUsers_RetailerId",
                table: "Rebates");

            migrationBuilder.DropIndex(
                name: "IX_Rebates_CustomerId",
                table: "Rebates");

            migrationBuilder.DropIndex(
                name: "IX_Rebates_RetailerId",
                table: "Rebates");

            migrationBuilder.DropIndex(
                name: "IX_Products_RetailerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_UserId1",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Rebates");

            migrationBuilder.DropColumn(
                name: "RetailerId",
                table: "Rebates");

            migrationBuilder.DropColumn(
                name: "RetailerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AspNetUserClaims");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Rebates",
                type: "nvarchar(320)",
                maxLength: 320,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RetailerName",
                table: "Rebates",
                type: "nvarchar(320)",
                maxLength: 320,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RetailerName",
                table: "Products",
                type: "nvarchar(320)",
                maxLength: 320,
                nullable: false,
                defaultValue: "");
        }
    }
}
