using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendor.UI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", maxLength: 100000000, nullable: false),
                    Date_Sent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Reoccuring_Notification = table.Column<bool>(type: "bit", nullable: true),
                    Days_Reoccuring = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Business_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_Id = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Category_Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Business_Categories_Business_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Business_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Sign_Up = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fed_Id_SSN = table.Column<int>(type: "int", nullable: false),
                    Supplier_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diversity_Certification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other_Diversity_Certification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Goods_Services = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Disabled_From_Notifications = table.Column<bool>(type: "bit", nullable: false),
                    Business_CategoriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Business_Categories_Business_CategoriesId",
                        column: x => x.Business_CategoriesId,
                        principalTable: "Business_Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Address_1 = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Address_2 = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    City = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postal_Code = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authorized_Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_Number = table.Column<int>(type: "int", nullable: false),
                    Authorized_ContactsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorized_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authorized_Contacts_Authorized_Contacts_Authorized_ContactsId",
                        column: x => x.Authorized_ContactsId,
                        principalTable: "Authorized_Contacts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Authorized_Contacts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Company_Types_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_Types_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Types_Categories_Business_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Business_Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Company_Types_Categories_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notification_Recipients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationsId = table.Column<int>(type: "int", nullable: false),
                    Type_Id = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    CategegoryId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Recipients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Recipients_Business_Categories_CategegoryId",
                        column: x => x.CategegoryId,
                        principalTable: "Business_Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notification_Recipients_Business_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Business_Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notification_Recipients_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notification_Recipients_Notifications_NotificationsId",
                        column: x => x.NotificationsId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Business_Categories",
                columns: new[] { "Id", "Category_Name", "TypeId", "Type_Id" },
                values: new object[,]
                {
                    { 1, "Cars", null, 1 },
                    { 2, "Tires", null, 1 },
                    { 3, "Meds", null, 2 },
                    { 4, "Supplies", null, 2 },
                    { 5, "Tools", null, 3 },
                    { 6, "Contractors", null, 3 },
                    { 7, "Trade", null, 4 },
                    { 8, "Finance", null, 4 },
                    { 9, "SupplyChain", null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Business_Types",
                columns: new[] { "Id", "Type_Name" },
                values: new object[,]
                {
                    { 1, "Transportation" },
                    { 2, "Medical" },
                    { 3, "Construction" },
                    { 4, "Business" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Business_CategoriesId", "Description_Goods_Services", "Disabled_From_Notifications", "Diversity_Certification", "Fed_Id_SSN", "Name", "Other_Diversity_Certification", "Sign_Up", "Supplier_Category", "Website" },
                values: new object[,]
                {
                    { 1, null, "Products", false, "None", 444444, "HP Inc", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US Entity", "www.HP.com" },
                    { 2, null, "Product cars", false, "DutyCert", 44454, "Lambo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foreign Entity", "www.lambo.com" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Body", "Created_By", "Date_Sent", "Days_Reoccuring", "Reoccuring_Notification", "Title" },
                values: new object[,]
                {
                    { 1, "HP please send us some supplies.", "Bill", new DateTime(2022, 11, 3, 20, 6, 8, 80, DateTimeKind.Local).AddTicks(7243), null, false, "Need Supplies" },
                    { 2, "Lambo we need 10 cars by next month. Will pay once delivered.", "Bill", new DateTime(2022, 11, 3, 20, 6, 8, 80, DateTimeKind.Local).AddTicks(7280), 7, true, "Need Cars" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CompanyId", "Email", "Password" },
                values: new object[,]
                {
                    { 1, 1, "HP@gmail.com", "123456" },
                    { 2, 2, "Lambo@yahoo.com", "1232455" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Address_1", "Address_2", "City", "CompanyId", "Country", "Postal_Code", "State" },
                values: new object[,]
                {
                    { 1, "127 Beechwood Dr", null, "Weldoe", 1, "USA", 46879, "New York" },
                    { 2, "1255 Dutchwood Dr", null, "Weldoe", 2, "USA", 46879, "New York" }
                });

            migrationBuilder.InsertData(
                table: "Authorized_Contacts",
                columns: new[] { "Id", "Authorized_ContactsId", "CompanyId", "Email", "FirstName", "LastName", "Phone_Number" },
                values: new object[,]
                {
                    { 1, null, 1, "bs@gmail.com", "Bob", "Shonpu", 31754524 },
                    { 2, null, 2, "mh@yahoo.com", "Max", "Hardshoe", 315455666 }
                });

            migrationBuilder.InsertData(
                table: "Company_Types_Categories",
                columns: new[] { "Id", "CategoryId", "Category_Id", "CompanyId" },
                values: new object[,]
                {
                    { 1, null, 2, 1 },
                    { 2, null, 3, 1 },
                    { 3, null, 4, 1 },
                    { 4, null, 1, 2 },
                    { 5, null, 6, 2 },
                    { 6, null, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "Notification_Recipients",
                columns: new[] { "Id", "CategegoryId", "Category_Id", "CompanyId", "NotificationsId", "TypeId", "Type_Id" },
                values: new object[,]
                {
                    { 1, null, 4, 1, 1, null, 2 },
                    { 2, null, 0, 2, 2, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CompanyId",
                table: "Accounts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CompanyId",
                table: "Addresses",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorized_Contacts_Authorized_ContactsId",
                table: "Authorized_Contacts",
                column: "Authorized_ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Authorized_Contacts_CompanyId",
                table: "Authorized_Contacts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_Categories_TypeId",
                table: "Business_Categories",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Business_CategoriesId",
                table: "Companies",
                column: "Business_CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_Types_Categories_CategoryId",
                table: "Company_Types_Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_Types_Categories_CompanyId",
                table: "Company_Types_Categories",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Recipients_CategegoryId",
                table: "Notification_Recipients",
                column: "CategegoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Recipients_CompanyId",
                table: "Notification_Recipients",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Recipients_NotificationsId",
                table: "Notification_Recipients",
                column: "NotificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Recipients_TypeId",
                table: "Notification_Recipients",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Authorized_Contacts");

            migrationBuilder.DropTable(
                name: "Company_Types_Categories");

            migrationBuilder.DropTable(
                name: "Notification_Recipients");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Business_Categories");

            migrationBuilder.DropTable(
                name: "Business_Types");
        }
    }
}
