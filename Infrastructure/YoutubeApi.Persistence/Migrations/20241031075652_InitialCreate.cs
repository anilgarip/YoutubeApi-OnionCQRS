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
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 547, DateTimeKind.Local).AddTicks(5865), "Health & Movies" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 547, DateTimeKind.Local).AddTicks(5871), "Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 547, DateTimeKind.Local).AddTicks(5885), "Outdoors, Tools & Kids" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 56, 52, 548, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 56, 52, 548, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 56, 52, 548, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 56, 52, 548, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 550, DateTimeKind.Local).AddTicks(183), "Koyun voluptatem sıla neque camisi.", "Ea." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 550, DateTimeKind.Local).AddTicks(214), "Exercitationem masaya non ipsum quis.", "Numquam esse." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 550, DateTimeKind.Local).AddTicks(240), "Hesap açılmadan patlıcan quis kutusu.", "Masaya ipsa." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 551, DateTimeKind.Local).AddTicks(5596), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 7.130263589705850m, 729.05m, "Intelligent Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 56, 52, 551, DateTimeKind.Local).AddTicks(5622), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 7.117452822930320m, 270.28m, "Unbranded Plastic Sausages" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 589, DateTimeKind.Local).AddTicks(5720), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 589, DateTimeKind.Local).AddTicks(5767), "Sports & Beauty" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 589, DateTimeKind.Local).AddTicks(5776), "Kids & Toys" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 49, 50, 590, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 49, 50, 590, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 49, 50, 590, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 10, 49, 50, 590, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 591, DateTimeKind.Local).AddTicks(7633), "Koşuyorlar quia sit autem eos.", "Makinesi." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 591, DateTimeKind.Local).AddTicks(7661), "Kalemi dolor aut sequi ipsam.", "Sed çorba." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 591, DateTimeKind.Local).AddTicks(7688), "Otobüs vel laudantium velit modi.", "Anlamsız gül." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 593, DateTimeKind.Local).AddTicks(2221), "The Football Is Good For Training And Recreational Purposes", 7.325572845161340m, 415.50m, "Ergonomic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 31, 10, 49, 50, 593, DateTimeKind.Local).AddTicks(2240), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2.765383580430050m, 96.12m, "Awesome Fresh Chair" });
        }
    }
}
