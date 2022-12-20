using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class EncryptFedId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fed_Id_SSN",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Business_CategoriesId", "Business_TypesId", "Description_Goods_Services", "Disabled_From_Notifications", "Diversity_Certification", "Fed_Id_SSN", "Is_Checked", "Is_Deleted", "Name", "Other_Diversity_Certification", "Sign_Up", "Supplier_Category", "Website" },
                values: new object[] { 1163, null, null, "Products", false, "None", "DL/FKp7ZRNb9G1DNEa7S+Q==", false, false, "Bees", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US Entity", "www.HP.com" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.AlterColumn<int>(
                name: "Fed_Id_SSN",
                table: "Companies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fed_Id_SSN",
                value: 444444);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fed_Id_SSN",
                value: 44454);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fed_Id_SSN",
                value: 444444);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fed_Id_SSN",
                value: 44454);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fed_Id_SSN",
                value: 444444);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fed_Id_SSN",
                value: 44454);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fed_Id_SSN",
                value: 444444);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fed_Id_SSN",
                value: 44454);

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
    }
}
