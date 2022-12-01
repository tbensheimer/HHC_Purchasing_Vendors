using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class FixNotifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 29, 15, 49, 40, 367, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "NotificationsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 29, 15, 49, 40, 367, DateTimeKind.Local).AddTicks(3464));
        }
    }
}
