using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class FixToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fed_Id_SSN",
                value: "444444");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fed_Id_SSN",
                value: "44454");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fed_Id_SSN",
                value: "444444");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fed_Id_SSN",
                value: "44454");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fed_Id_SSN",
                value: "444444");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fed_Id_SSN",
                value: "44454");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fed_Id_SSN",
                value: "444444");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fed_Id_SSN",
                value: "44454");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1163,
                column: "Fed_Id_SSN",
                value: "444444");

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 20, 13, 50, 46, 686, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 20, 13, 50, 46, 686, DateTimeKind.Local).AddTicks(4284));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fed_Id_SSN",
                value: "DL/FKp7ZRNb9G1DNEa7S+Q==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fed_Id_SSN",
                value: "30hQ70pyWr6lD+YK7tm6Xw==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fed_Id_SSN",
                value: "DL/FKp7ZRNb9G1DNEa7S+Q==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fed_Id_SSN",
                value: "30hQ70pyWr6lD+YK7tm6Xw==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fed_Id_SSN",
                value: "DL/FKp7ZRNb9G1DNEa7S+Q==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fed_Id_SSN",
                value: "30hQ70pyWr6lD+YK7tm6Xw==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fed_Id_SSN",
                value: "DL/FKp7ZRNb9G1DNEa7S+Q==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fed_Id_SSN",
                value: "30hQ70pyWr6lD+YK7tm6Xw==");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1163,
                column: "Fed_Id_SSN",
                value: "DL/FKp7ZRNb9G1DNEa7S+Q==");

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 20, 12, 57, 29, 242, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 20, 12, 57, 29, 242, DateTimeKind.Local).AddTicks(6615));
        }
    }
}
