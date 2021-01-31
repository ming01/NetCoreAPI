using Microsoft.EntityFrameworkCore.Migrations;

namespace RPG_Project.Migrations
{
    public partial class ProductCreatev4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroup_Product_ProductId",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroup_ProductId",
                table: "ProductGroup");

            migrationBuilder.AddColumn<int>(
                name: "ProductGroupId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductGroupId1",
                table: "Product",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId1",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductGroupId1",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductGroupId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductGroupId1",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroup_ProductId",
                table: "ProductGroup",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductGroup_Product_ProductId",
                table: "ProductGroup",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
