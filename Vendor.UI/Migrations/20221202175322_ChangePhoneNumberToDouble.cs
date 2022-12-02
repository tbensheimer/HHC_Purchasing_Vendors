using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class ChangePhoneNumberToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Phone_Number",
                table: "Authorized_Contacts",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Authorized_Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phone_Number",
                value: 31754524.0);

            migrationBuilder.UpdateData(
                table: "Authorized_Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phone_Number",
                value: 315455666.0);

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 2, 12, 53, 20, 219, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 2, 12, 53, 20, 219, DateTimeKind.Local).AddTicks(2177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone_Number",
                table: "Authorized_Contacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Authorized_Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phone_Number",
                value: 31754524);

            migrationBuilder.UpdateData(
                table: "Authorized_Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phone_Number",
                value: 315455666);

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 1, 8, 56, 7, 482, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 12, 1, 8, 56, 7, 482, DateTimeKind.Local).AddTicks(1803));
        }
    }
}
