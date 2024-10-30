using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 335, DateTimeKind.Local).AddTicks(7771), "Movies" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 335, DateTimeKind.Local).AddTicks(7775), "Music" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 335, DateTimeKind.Local).AddTicks(7836), "Computers, Shoes & Automotive" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 54, 46, 337, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 54, 46, 337, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 54, 46, 337, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 54, 46, 337, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 338, DateTimeKind.Local).AddTicks(1867), "İnventore illo yaptı quia karşıdakine.", "Voluptatem." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 338, DateTimeKind.Local).AddTicks(1899), "Vel açılmadan consectetur dicta kalemi.", "Dignissimos ipsam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 338, DateTimeKind.Local).AddTicks(1946), "Consequatur gazete quia doğru ut.", "Ratione magnam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 339, DateTimeKind.Local).AddTicks(9721), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2.650820731249660m, 814.22m, "Rustic Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 54, 46, 339, DateTimeKind.Local).AddTicks(9743), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9.322216669781790m, 83.04m, "Generic Rubber Mouse" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 443, DateTimeKind.Local).AddTicks(1066), "Automotive, Grocery & Shoes" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 443, DateTimeKind.Local).AddTicks(1081), "Movies & Home" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 443, DateTimeKind.Local).AddTicks(1091), "Grocery & Games" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 47, 51, 444, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 47, 51, 444, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 47, 51, 444, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 47, 51, 444, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 446, DateTimeKind.Local).AddTicks(2607), "Otobüs aliquid et quasi sayfası.", "Autem." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 446, DateTimeKind.Local).AddTicks(2724), "Okuma cesurca voluptate sıfat eaque.", "Beatae magnam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 446, DateTimeKind.Local).AddTicks(2750), "Voluptatem beatae tv qui sıradanlıktan.", "Autem quia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 448, DateTimeKind.Local).AddTicks(4628), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0.4972394194038990m, 709.84m, "Generic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 47, 51, 448, DateTimeKind.Local).AddTicks(4651), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 7.218958112228980m, 821.50m, "Incredible Wooden Towels" });
        }
    }
}
