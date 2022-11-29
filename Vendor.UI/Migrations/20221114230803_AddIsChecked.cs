using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class AddIsChecked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authorized_Contacts_Authorized_Contacts_Authorized_ContactsId",
                table: "Authorized_Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Authorized_Contacts_Authorized_ContactsId",
                table: "Authorized_Contacts");

            migrationBuilder.DropColumn(
                name: "Authorized_ContactsId",
                table: "Authorized_Contacts");

            migrationBuilder.AddColumn<bool>(
                name: "Is_Checked",
                table: "Business_Types",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Checked",
                table: "Business_Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 14, 18, 8, 0, 945, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 14, 18, 8, 0, 945, DateTimeKind.Local).AddTicks(3349));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Checked",
                table: "Business_Types");

            migrationBuilder.DropColumn(
                name: "Is_Checked",
                table: "Business_Categories");

            migrationBuilder.AddColumn<int>(
                name: "Authorized_ContactsId",
                table: "Authorized_Contacts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 9, 8, 36, 31, 479, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 9, 8, 36, 31, 479, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.CreateIndex(
                name: "IX_Authorized_Contacts_Authorized_ContactsId",
                table: "Authorized_Contacts",
                column: "Authorized_ContactsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorized_Contacts_Authorized_Contacts_Authorized_ContactsId",
                table: "Authorized_Contacts",
                column: "Authorized_ContactsId",
                principalTable: "Authorized_Contacts",
                principalColumn: "Id");
        }
    }
}
