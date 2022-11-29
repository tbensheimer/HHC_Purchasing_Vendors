using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class ChangeNotificationsListContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Recipients_Notifications_NotificationsId",
                table: "Notification_Recipients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "NotificationsList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationsList",
                table: "NotificationsList",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Recipients_NotificationsList_NotificationsId",
                table: "Notification_Recipients",
                column: "NotificationsId",
                principalTable: "NotificationsList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Recipients_NotificationsList_NotificationsId",
                table: "Notification_Recipients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationsList",
                table: "NotificationsList");

            migrationBuilder.RenameTable(
                name: "NotificationsList",
                newName: "Notifications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 29, 8, 38, 5, 168, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 29, 8, 38, 5, 168, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Recipients_Notifications_NotificationsId",
                table: "Notification_Recipients",
                column: "NotificationsId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
