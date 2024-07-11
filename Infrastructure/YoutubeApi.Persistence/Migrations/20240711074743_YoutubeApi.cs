using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class YoutubeApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 47, 43, 785, DateTimeKind.Local).AddTicks(1175), "Toys, Music & Health" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 47, 43, 785, DateTimeKind.Local).AddTicks(1189), "Automotive" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 47, 43, 785, DateTimeKind.Local).AddTicks(1198), "Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 11, 10, 47, 43, 789, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 11, 10, 47, 43, 789, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 11, 10, 47, 43, 789, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 11, 10, 47, 43, 789, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 47, 43, 792, DateTimeKind.Local).AddTicks(3516), "Çobanın patlıcan eum dolore anlamsız.", "Düşünüyor." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 47, 43, 792, DateTimeKind.Local).AddTicks(3577), "Telefonu öyle nesciunt corporis dağılımı.", "Voluptatem sed." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 47, 43, 792, DateTimeKind.Local).AddTicks(3639), "Sevindi veritatis consequuntur dicta praesentium.", "Ona iure." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 11, 10, 47, 43, 795, DateTimeKind.Local).AddTicks(2400), "Ürün 1 Açıklaması", 10m, false, 100m, "Ürün 1" },
                    { 2, 2, new DateTime(2024, 7, 11, 10, 47, 43, 795, DateTimeKind.Local).AddTicks(2403), "Ürün 2 Açıklaması", 15m, false, 200m, "Ürün 2" },
                    { 30, 1, new DateTime(2024, 7, 11, 10, 47, 43, 795, DateTimeKind.Local).AddTicks(2096), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2.299628415369520m, false, 197.17m, "Generic Wooden Hat" },
                    { 40, 3, new DateTime(2024, 7, 11, 10, 47, 43, 795, DateTimeKind.Local).AddTicks(2136), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0.4410795668002380m, false, 449.05m, "Ergonomic Fresh Chips" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 45, 51, 568, DateTimeKind.Local).AddTicks(686), "Automotive, Baby & Games" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 45, 51, 568, DateTimeKind.Local).AddTicks(692), "Industrial" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 45, 51, 568, DateTimeKind.Local).AddTicks(697), "Movies" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 45, 51, 571, DateTimeKind.Local).AddTicks(5326), "Totam sit quis ratione quaerat.", "Masanın." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 45, 51, 571, DateTimeKind.Local).AddTicks(5448), "Praesentium voluptas architecto lambadaki öyle.", "Karşıdakine çünkü." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 45, 51, 571, DateTimeKind.Local).AddTicks(5482), "Umut iusto yaptı consectetur autem.", "Ekşili ullam." });
        }
    }
}
