using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductShop.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShopppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\phone1-small.jpg", "\\Images\\phone1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\phone2-small.jpg", "\\Images\\phone2.jpg" });

           //migrationBuilder.UpdateData(
           //    table: "Products",
           //    keyColumn: "ProductId",
           //    keyValue: 3,
           //    columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
           //    values: new object[] { "\\Images\\thumbnails\\phone13-small.jpg", "\\Images\\phone13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\laptop1-small.jpg", "\\Images\\laptop1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\laptop2-small.jpg", "\\Images\\laptop2.jpg" });

           // migrationBuilder.UpdateData(
           //     table: "Products",
           //     keyColumn: "ProductId",
           //     keyValue: 6,
           //     columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
           //     values: new object[] { "\\Images\\thumbnails\\laptop13-small.jpg", "\\Images\\laptop13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\dress1-small.jpg", "\\Images\\dress1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\dress2-small.jpg", "\\Images\\dress2.jpg" });

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "ProductId",
            //    keyValue: 9,
            //    columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
            //    values: new object[] { "\\Images\\thumbnails\\dress13-small.jpg", "\\Images\\dress13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\shoe1-small.jpg", "\\Images\\shoe1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\shoe2-small.jpg", "\\Images\\shoe2.jpg" });

          //  migrationBuilder.UpdateData(
          //      table: "Products",
          //      keyColumn: "ProductId",
          //      keyValue: 12,
          //      columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
          //      values: new object[] { "\\Images\\thumbnails\\shoe13-small.jpg", "\\Images\\shoe13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\jacket1-small.jpg", "\\Images\\jacket1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\jacket2-small.jpg", "\\Images\\jacket2.jpg" });

           // migrationBuilder.UpdateData(
           //     table: "Products",
           //     keyColumn: "ProductId",
           //     keyValue: 15,
           //     columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
           //     values: new object[] { "\\Images\\thumbnails\\jacket13-small.jpg", "\\Images\\jacket13.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_ShopppingCartItems_ProductId",
                table: "ShopppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopppingCartItems");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\phone1-small.jpg", "~\\Images\\phone1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\phone2-small.jpg", "~\\Images\\phone2.jpg" });

           // migrationBuilder.UpdateData(
           //     table: "Products",
           //     keyColumn: "ProductId",
           //     keyValue: 3,
           //     columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
           //     values: new object[] { "~\\Images\\thumbnails\\phone13-small.jpg", "~\\Images\\phone13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\laptop1-small.jpg", "~\\Images\\laptop1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\laptop2-small.jpg", "~\\Images\\laptop2.jpg" });

           // migrationBuilder.UpdateData(
           //     table: "Products",
           //     keyColumn: "ProductId",
           //     keyValue: 6,
           //     columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
           //     values: new object[] { "~\\Images\\thumbnails\\laptop13-small.jpg", "~\\Images\\laptop13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\dress1-small.jpg", "~\\Images\\dress1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\dress2-small.jpg", "~\\Images\\dress2.jpg" });

           // migrationBuilder.UpdateData(
           //     table: "Products",
           //     keyColumn: "ProductId",
           //     keyValue: 9,
           //     columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
           //     values: new object[] { "~\\Images\\thumbnails\\dress13-small.jpg", "~\\Images\\dress13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\shoe1-small.jpg", "~\\Images\\shoe1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\shoe2-small.jpg", "~\\Images\\shoe2.jpg" });

           // migrationBuilder.UpdateData(
           //     table: "Products",
           //     keyColumn: "ProductId",
           //     keyValue: 12,
           //     columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
           //     values: new object[] { "~\\Images\\thumbnails\\shoe13-small.jpg", "~\\Images\\shoe13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\jacket1-small.jpg", "~\\Images\\jacket1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\thumbnails\\jacket2-small.jpg", "~\\Images\\jacket2.jpg" });

            //migrationBuilder.UpdateData(
            //    table: "Products",
            //    keyColumn: "ProductId",
            //    keyValue: 15,
            //    columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
            //    values: new object[] { "~\\Images\\thumbnails\\jacket13-small.jpg", "~\\Images\\jacket13.jpg" });
        }
    }
}
