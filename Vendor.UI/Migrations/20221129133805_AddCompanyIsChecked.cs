using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class AddCompanyIsChecked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Is_Checked",
                table: "Companies",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Checked",
                table: "Companies");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 17, 8, 26, 19, 701, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 17, 8, 26, 19, 701, DateTimeKind.Local).AddTicks(7796));
        }
    }
}
