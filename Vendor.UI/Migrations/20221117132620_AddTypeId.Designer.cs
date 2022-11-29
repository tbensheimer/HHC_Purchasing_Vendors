﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vendor.Data.Models;

#nullable disable

namespace Vendor.UI.Migrations
{
    [DbContext(typeof(VendorDataDbContext))]
    [Migration("20221117132620_AddTypeId")]
    partial class AddTypeId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vendor.Data.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Email = "HP@gmail.com",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            Email = "Lambo@yahoo.com",
                            Password = "1232455"
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address_1")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("Address_2")
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<int?>("Postal_Code")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address_1 = "127 Beechwood Dr",
                            City = "Weldoe",
                            CompanyId = 1,
                            Country = "USA",
                            Postal_Code = 46879,
                            State = "New York"
                        },
                        new
                        {
                            Id = 2,
                            Address_1 = "1255 Dutchwood Dr",
                            City = "Weldoe",
                            CompanyId = 2,
                            Country = "USA",
                            Postal_Code = 46879,
                            State = "New York"
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Authorized_Contacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<bool>("Contact_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<int?>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Authorized_Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Contact_Deleted = false,
                            Email = "bs@gmail.com",
                            FirstName = "Bob",
                            LastName = "Shonpu",
                            Phone_Number = 31754524
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            Contact_Deleted = false,
                            Email = "mh@yahoo.com",
                            FirstName = "Max",
                            LastName = "Hardshoe",
                            Phone_Number = 315455666
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Business_Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Is_Checked")
                        .HasColumnType("bit");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("Type_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Business_Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category_Name = "Cars",
                            Is_Checked = false,
                            Type_Id = 1
                        },
                        new
                        {
                            Id = 2,
                            Category_Name = "Tires",
                            Is_Checked = false,
                            Type_Id = 1
                        },
                        new
                        {
                            Id = 3,
                            Category_Name = "Meds",
                            Is_Checked = false,
                            Type_Id = 2
                        },
                        new
                        {
                            Id = 4,
                            Category_Name = "Supplies",
                            Is_Checked = false,
                            Type_Id = 2
                        },
                        new
                        {
                            Id = 5,
                            Category_Name = "Tools",
                            Is_Checked = false,
                            Type_Id = 3
                        },
                        new
                        {
                            Id = 6,
                            Category_Name = "Contractors",
                            Is_Checked = false,
                            Type_Id = 3
                        },
                        new
                        {
                            Id = 7,
                            Category_Name = "Trade",
                            Is_Checked = false,
                            Type_Id = 4
                        },
                        new
                        {
                            Id = 8,
                            Category_Name = "Finance",
                            Is_Checked = false,
                            Type_Id = 4
                        },
                        new
                        {
                            Id = 9,
                            Category_Name = "SupplyChain",
                            Is_Checked = false,
                            Type_Id = 4
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Business_Types", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Is_Checked")
                        .HasColumnType("bit");

                    b.Property<string>("Type_Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Business_Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Is_Checked = false,
                            Type_Name = "Transportation"
                        },
                        new
                        {
                            Id = 2,
                            Is_Checked = false,
                            Type_Name = "Medical"
                        },
                        new
                        {
                            Id = 3,
                            Is_Checked = false,
                            Type_Name = "Construction"
                        },
                        new
                        {
                            Id = 4,
                            Is_Checked = false,
                            Type_Name = "Business"
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Business_CategoriesId")
                        .HasColumnType("int");

                    b.Property<int?>("Business_TypesId")
                        .HasColumnType("int");

                    b.Property<string>("Description_Goods_Services")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Disabled_From_Notifications")
                        .HasColumnType("bit");

                    b.Property<string>("Diversity_Certification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Fed_Id_SSN")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("Is_Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("Other_Diversity_Certification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Sign_Up")
                        .HasColumnType("datetime2");

                    b.Property<string>("Supplier_Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Business_CategoriesId");

                    b.HasIndex("Business_TypesId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description_Goods_Services = "Products",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "None",
                            Fed_Id_SSN = 444444,
                            Is_Deleted = false,
                            Name = "HP Inc",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "US Entity",
                            Website = "www.HP.com"
                        },
                        new
                        {
                            Id = 2,
                            Description_Goods_Services = "Product cars",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "DutyCert",
                            Fed_Id_SSN = 44454,
                            Is_Deleted = false,
                            Name = "Lambo",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "Foreign Entity",
                            Website = "www.lambo.com"
                        },
                        new
                        {
                            Id = 3,
                            Description_Goods_Services = "Products",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "None",
                            Fed_Id_SSN = 444444,
                            Is_Deleted = false,
                            Name = "HP Inc",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "US Entity",
                            Website = "www.HP.com"
                        },
                        new
                        {
                            Id = 4,
                            Description_Goods_Services = "Product cars",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "DutyCert",
                            Fed_Id_SSN = 44454,
                            Is_Deleted = false,
                            Name = "Lambo",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "Foreign Entity",
                            Website = "www.lambo.com"
                        },
                        new
                        {
                            Id = 5,
                            Description_Goods_Services = "Products",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "None",
                            Fed_Id_SSN = 444444,
                            Is_Deleted = false,
                            Name = "HP Inc",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "US Entity",
                            Website = "www.HP.com"
                        },
                        new
                        {
                            Id = 6,
                            Description_Goods_Services = "Product cars",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "DutyCert",
                            Fed_Id_SSN = 44454,
                            Is_Deleted = false,
                            Name = "Lambo",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "Foreign Entity",
                            Website = "www.lambo.com"
                        },
                        new
                        {
                            Id = 7,
                            Description_Goods_Services = "Products",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "None",
                            Fed_Id_SSN = 444444,
                            Is_Deleted = false,
                            Name = "HP Inc",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "US Entity",
                            Website = "www.HP.com"
                        },
                        new
                        {
                            Id = 8,
                            Description_Goods_Services = "Product cars",
                            Disabled_From_Notifications = false,
                            Diversity_Certification = "DutyCert",
                            Fed_Id_SSN = 44454,
                            Is_Deleted = false,
                            Name = "Lambo",
                            Sign_Up = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Supplier_Category = "Foreign Entity",
                            Website = "www.lambo.com"
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Company_Types_Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("Type_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Company_Types_Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category_Id = 2,
                            CompanyId = 1,
                            Type_Id = 0
                        },
                        new
                        {
                            Id = 2,
                            Category_Id = 3,
                            CompanyId = 1,
                            Type_Id = 0
                        },
                        new
                        {
                            Id = 3,
                            Category_Id = 4,
                            CompanyId = 1,
                            Type_Id = 0
                        },
                        new
                        {
                            Id = 4,
                            Category_Id = 1,
                            CompanyId = 2,
                            Type_Id = 0
                        },
                        new
                        {
                            Id = 5,
                            Category_Id = 6,
                            CompanyId = 2,
                            Type_Id = 0
                        },
                        new
                        {
                            Id = 6,
                            Category_Id = 5,
                            CompanyId = 2,
                            Type_Id = 0
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Notification_Recipient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategegoryId")
                        .HasColumnType("int");

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("NotificationsId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("Type_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategegoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NotificationsId");

                    b.HasIndex("TypeId");

                    b.ToTable("Notification_Recipients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category_Id = 4,
                            CompanyId = 1,
                            NotificationsId = 1,
                            Type_Id = 2
                        },
                        new
                        {
                            Id = 2,
                            Category_Id = 0,
                            CompanyId = 2,
                            NotificationsId = 2,
                            Type_Id = 0
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Notifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(100000000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created_By")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Date_Sent")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Days_Reoccuring")
                        .HasColumnType("int");

                    b.Property<bool?>("Reoccuring_Notification")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "HP please send us some supplies.",
                            Created_By = "Bill",
                            Date_Sent = new DateTime(2022, 11, 17, 8, 26, 19, 701, DateTimeKind.Local).AddTicks(7760),
                            Reoccuring_Notification = false,
                            Title = "Need Supplies"
                        },
                        new
                        {
                            Id = 2,
                            Body = "Lambo we need 10 cars by next month. Will pay once delivered.",
                            Created_By = "Bill",
                            Date_Sent = new DateTime(2022, 11, 17, 8, 26, 19, 701, DateTimeKind.Local).AddTicks(7796),
                            Days_Reoccuring = 7,
                            Reoccuring_Notification = true,
                            Title = "Need Cars"
                        });
                });

            modelBuilder.Entity("Vendor.Data.Models.Account", b =>
                {
                    b.HasOne("Vendor.Data.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Vendor.Data.Models.Address", b =>
                {
                    b.HasOne("Vendor.Data.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Vendor.Data.Models.Authorized_Contacts", b =>
                {
                    b.HasOne("Vendor.Data.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Vendor.Data.Models.Business_Categories", b =>
                {
                    b.HasOne("Vendor.Data.Models.Business_Types", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Vendor.Data.Models.Company", b =>
                {
                    b.HasOne("Vendor.Data.Models.Business_Categories", null)
                        .WithMany("Companies")
                        .HasForeignKey("Business_CategoriesId");

                    b.HasOne("Vendor.Data.Models.Business_Types", null)
                        .WithMany("Companies")
                        .HasForeignKey("Business_TypesId");
                });

            modelBuilder.Entity("Vendor.Data.Models.Company_Types_Categories", b =>
                {
                    b.HasOne("Vendor.Data.Models.Business_Categories", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Vendor.Data.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Vendor.Data.Models.Notification_Recipient", b =>
                {
                    b.HasOne("Vendor.Data.Models.Business_Categories", "Categegory")
                        .WithMany()
                        .HasForeignKey("CategegoryId");

                    b.HasOne("Vendor.Data.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vendor.Data.Models.Notifications", "Notifications")
                        .WithMany()
                        .HasForeignKey("NotificationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vendor.Data.Models.Business_Types", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Categegory");

                    b.Navigation("Company");

                    b.Navigation("Notifications");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Vendor.Data.Models.Business_Categories", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("Vendor.Data.Models.Business_Types", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
