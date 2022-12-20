using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class EncryptAccountPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "iLY0nGsyXvvcyA4dPl7xoQ==");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "DPcztWjIEh3Bka4U2KZcbw==");

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
                value: new DateTime(2022, 12, 20, 16, 1, 8, 875, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 20, 16, 1, 8, 875, DateTimeKind.Local).AddTicks(3578));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "123456");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "1232455");

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
                value: new DateTime(2022, 12, 20, 15, 5, 14, 455, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 20, 15, 5, 14, 455, DateTimeKind.Local).AddTicks(1066));
        }
    }
}
