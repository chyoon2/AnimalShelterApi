using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace animalshelterapi.Migrations
{
    public partial class seeddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "DateOfAdmittance", "Gender", "Name", "Species", "Url" },
                values: new object[,]
                {
                    { 1, 7, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 157, DateTimeKind.Local).AddTicks(334), "Female", "Matilda", "Woolly Mammoth", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 2, 10, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8054), "Female", "Rexie", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 3, 2, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8071), "Female", "Matilda", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 4, 4, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8074), "Male", "Pip", "Shark", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 5, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8077), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 6, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8081), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 7, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8084), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 8, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8087), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 9, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8090), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 10, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8094), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 11, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8097), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 12, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8099), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 13, 22, "Alpine", new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8102), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);
        }
    }
}
