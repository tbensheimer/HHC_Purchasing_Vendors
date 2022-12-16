using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class ChangePostalCodeToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Postal_Code",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Postal_Code",
                value: "46879");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Postal_Code",
                value: "46879");

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 16, 11, 50, 7, 628, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 16, 11, 50, 7, 628, DateTimeKind.Local).AddTicks(3240));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Postal_Code",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Postal_Code",
                value: 46879);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Postal_Code",
                value: 46879);

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 5, 12, 51, 21, 371, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 5, 12, 51, 21, 371, DateTimeKind.Local).AddTicks(6749));
        }
    }
}
