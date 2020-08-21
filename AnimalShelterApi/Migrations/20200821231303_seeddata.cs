using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace animalshelterapi.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "DateOfAdmittance", "Gender", "Name", "Species", "Url" },
                values: new object[,]
                {
                    { 1, 7, "Alpine", new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(4993), "Female", "Catname", "Woolly Mammoth", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 2, 7, "Alpine", new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(5488), "Female", "Cat3name", "Woolly Mammoth", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
                });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 33, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 9,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 11,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 12,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 13,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 13, 3, 35, DateTimeKind.Local).AddTicks(1742));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 107, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 9,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 11,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 12,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 13,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4948));
        }
    }
}
