using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Rukavice", "rukavice" },
                    { 2, "camera-slr", "Kacige", "kacige" },
                    { 3, "aperture", "Kostobrani", "kostobrani" },
                    { 4, "book", "Kikovi", "kikovi" },
                    { 5, "book", "Kimona", "kimona" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DatuUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 14, 9, 44, 18, 95, DateTimeKind.Local).AddTicks(4745), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rukavice za boks 10oz", "https://www.pride.hr/images/thumbs/0000925_4033-pride-pro-training-and-sparring-gloves_1000.jpeg", false, false, 19.99m, 9.99m, "Rukavice" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DatuUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 2, 1, new DateTime(2022, 8, 14, 9, 44, 18, 102, DateTimeKind.Local).AddTicks(3089), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rukavice marke Adidas 12oz", "https://www.pride.hr/images/thumbs/0001782_a7150-adidas-boxing-gloves-speed-50_1000.jpeg", false, false, 19.99m, 9.99m, "Rukavice Adidas" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DatuUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 3, 1, new DateTime(2022, 8, 14, 9, 44, 18, 102, DateTimeKind.Local).AddTicks(3183), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rukavice marke Adidas 14oz", "https://www.pride.hr/images/thumbs/0001782_a7150-adidas-boxing-gloves-speed-50_1000.jpeg", false, false, 19.99m, 9.99m, "Rukavice Adidas 14oz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
