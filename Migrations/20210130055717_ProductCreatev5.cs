using Microsoft.EntityFrameworkCore.Migrations;

namespace RPG_Project.Migrations
{
    public partial class ProductCreatev5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId1",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductGroupId1",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductGroup");

            migrationBuilder.DropColumn(
                name: "ProductGroupId1",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGroupId",
                table: "Product",
                column: "ProductGroupId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId",
                table: "Product",
                column: "ProductGroupId",
                principalTable: "ProductGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductGroupId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductGroupId1",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGroupId1",
                table: "Product",
                column: "ProductGroupId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId1",
                table: "Product",
                column: "ProductGroupId1",
                principalTable: "ProductGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
