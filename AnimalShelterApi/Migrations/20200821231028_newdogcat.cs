using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace animalshelterapi.Migrations
{
    public partial class newdogcat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    DateOfAdmittance = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    DateOfAdmittance = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "DateOfAdmittance", "Gender", "Name", "Species", "Url" },
                values: new object[,]
                {
                    { 1, 7, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 107, DateTimeKind.Local).AddTicks(8109), "Female", "Matilda", "Woolly Mammoth", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 2, 10, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4902), "Female", "Rexie", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 3, 2, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4918), "Female", "Matilda", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 4, 4, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4921), "Male", "Pip", "Shark", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 5, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4924), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 6, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4927), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 7, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4930), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 8, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4933), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 9, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4936), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 10, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4939), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 11, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4942), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 12, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4945), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 13, 22, "Alpine", new DateTime(2020, 8, 21, 16, 10, 28, 109, DateTimeKind.Local).AddTicks(4948), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Breed = table.Column<string>(nullable: true),
                    DateOfAdmittance = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "DateOfAdmittance", "Gender", "Name", "Species", "Url" },
                values: new object[,]
                {
                    { 1, 7, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 311, DateTimeKind.Local).AddTicks(2544), "Female", "Matilda", "Woolly Mammoth", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 2, 10, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9649), "Female", "Rexie", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 3, 2, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9664), "Female", "Matilda", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 4, 4, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9668), "Male", "Pip", "Shark", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 5, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9670), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 6, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9673), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 7, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9676), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 8, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9679), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 9, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9682), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 10, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9685), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 11, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9688), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 12, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9692), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" },
                    { 13, 22, "Alpine", new DateTime(2020, 8, 21, 13, 49, 36, 312, DateTimeKind.Local).AddTicks(9695), "Male", "Bartholomew", "Dinosaur", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2020/07/1024/512/iStock-466395505.jpg?ve=1&tl=1" }
                });
        }
    }
}
