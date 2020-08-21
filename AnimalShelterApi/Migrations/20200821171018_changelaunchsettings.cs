using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace animalshelterapi.Migrations
{
    public partial class changelaunchsettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 535, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 10, 10, 18, 537, DateTimeKind.Local).AddTicks(4852));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 157, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13,
                column: "DateOfAdmittance",
                value: new DateTime(2020, 8, 21, 9, 24, 10, 158, DateTimeKind.Local).AddTicks(8102));
        }
    }
}
