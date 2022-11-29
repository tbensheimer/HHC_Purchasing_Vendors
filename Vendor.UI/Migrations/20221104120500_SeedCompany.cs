using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class SeedCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Business_TypesId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Business_CategoriesId", "Business_TypesId", "Description_Goods_Services", "Disabled_From_Notifications", "Diversity_Certification", "Fed_Id_SSN", "Name", "Other_Diversity_Certification", "Sign_Up", "Supplier_Category", "Website" },
                values: new object[,]
                {
                    { 3, null, null, "Products", false, "None", 444444, "HP Inc", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US Entity", "www.HP.com" },
                    { 4, null, null, "Product cars", false, "DutyCert", 44454, "Lambo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foreign Entity", "www.lambo.com" },
                    { 5, null, null, "Products", false, "None", 444444, "HP Inc", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US Entity", "www.HP.com" },
                    { 6, null, null, "Product cars", false, "DutyCert", 44454, "Lambo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foreign Entity", "www.lambo.com" },
                    { 7, null, null, "Products", false, "None", 444444, "HP Inc", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US Entity", "www.HP.com" },
                    { 8, null, null, "Product cars", false, "DutyCert", 44454, "Lambo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foreign Entity", "www.lambo.com" }
                });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 4, 8, 4, 57, 897, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 4, 8, 4, 57, 897, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Business_TypesId",
                table: "Companies",
                column: "Business_TypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Business_Types_Business_TypesId",
                table: "Companies",
                column: "Business_TypesId",
                principalTable: "Business_Types",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Business_Types_Business_TypesId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_Business_TypesId",
                table: "Companies");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Business_TypesId",
                table: "Companies");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 3, 20, 6, 8, 80, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_Sent",
                value: new DateTime(2022, 11, 3, 20, 6, 8, 80, DateTimeKind.Local).AddTicks(7280));
        }
    }
}
