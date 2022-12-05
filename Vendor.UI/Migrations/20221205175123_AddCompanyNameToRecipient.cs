using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class AddCompanyNameToRecipient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Notification_Recipients",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Notification_Recipients");

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
    }
}
