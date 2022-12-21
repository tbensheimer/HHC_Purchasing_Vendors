using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Data.Models
{
    public class VendorDataDbContext : DbContext
    {

        private readonly IEncryptionProvider _provider;

        public VendorDataDbContext(
           DbContextOptions<VendorDataDbContext> options) : base(options) {
  

            this._provider = new GenerateEncryptionProvider("asdfasdfasdfasdf");  //need to create own 128 bit encryption key AND it only encrypts strings

        }

        public DbSet<Company> Companies { get; set; } = default!;
        public DbSet<VendorAccount> Accounts { get; set; } = default!;
        public DbSet<Address> Addresses { get; set; } = default!;
        public DbSet<Authorized_Contacts> Authorized_Contacts { get; set; } = default!;
        public DbSet<Business_Categories> Business_Categories { get; set; } = default!;
        public DbSet<Business_Types> Business_Types { get; set; } = default!;

        public DbSet<Company_Types_Categories> Company_Types_Categories { get; set; } = default!;
        public DbSet<Notifications> NotificationsList { get; set; } = default!;
        public DbSet<Notification_Recipient> Notification_Recipients { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseEncryption(this._provider);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "HP Inc", Fed_Id_SSN = "444444", Website = "www.HP.com", Diversity_Certification = "None", Supplier_Category = "US Entity", Description_Goods_Services = "Products" },
                new Company { Id = 2, Name = "Lambo", Fed_Id_SSN = "44454", Website = "www.lambo.com", Diversity_Certification = "DutyCert", Supplier_Category = "Foreign Entity", Description_Goods_Services = "Product cars" },
                 new Company { Id = 3, Name = "HP Inc", Fed_Id_SSN = "444444", Website = "www.HP.com", Diversity_Certification = "None", Supplier_Category = "US Entity", Description_Goods_Services = "Products" },
                new Company { Id = 4, Name = "Lambo", Fed_Id_SSN = "44454", Website = "www.lambo.com", Diversity_Certification = "DutyCert", Supplier_Category = "Foreign Entity", Description_Goods_Services = "Product cars" },
                 new Company { Id = 5, Name = "HP Inc", Fed_Id_SSN = "444444", Website = "www.HP.com", Diversity_Certification = "None", Supplier_Category = "US Entity", Description_Goods_Services = "Products" },
                new Company { Id = 6, Name = "Lambo", Fed_Id_SSN = "44454", Website = "www.lambo.com", Diversity_Certification = "DutyCert", Supplier_Category = "Foreign Entity", Description_Goods_Services = "Product cars" },
                 new Company { Id = 7, Name = "HP Inc", Fed_Id_SSN = "444444", Website = "www.HP.com", Diversity_Certification = "None", Supplier_Category = "US Entity", Description_Goods_Services = "Products" },
                new Company { Id = 8, Name = "Lambo", Fed_Id_SSN = "44454", Website = "www.lambo.com", Diversity_Certification = "DutyCert", Supplier_Category = "Foreign Entity", Description_Goods_Services = "Product cars" }
                );


            modelBuilder.Entity<VendorAccount>().HasData(
                new VendorAccount { Id = 1, CompanyId = 1, Email = "HP@gmail.com", Password = "123456" },
                new VendorAccount { Id = 2, CompanyId = 2, Email = "Lambo@yahoo.com", Password = "1232455"}
                );

            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 1, CompanyId = 1, Address_1 = "127 Beechwood Dr", City = "Weldoe", State = "New York", Postal_Code = "46879", Country = "USA"},
                new Address { Id = 2, CompanyId = 2, Address_1 = "1255 Dutchwood Dr", City = "Weldoe", State = "New York", Postal_Code = "46879", Country = "USA" }
                );

            modelBuilder.Entity<Authorized_Contacts>().HasData(
                new Authorized_Contacts { Id = 1, CompanyId = 1, FirstName = "Bob", LastName = "Shonpu", Email = "bs@gmail.com", Phone_Number = 31754524 },
                new Authorized_Contacts { Id = 2, CompanyId = 2, FirstName = "Max", LastName = "Hardshoe", Email = "mh@yahoo.com", Phone_Number = 315455666} 
                );

            modelBuilder.Entity<Business_Types>().HasData(
                new Business_Types { Id = 1, Type_Name = "Transportation"},
                new Business_Types { Id = 2, Type_Name = "Medical" },
                new Business_Types { Id = 3, Type_Name = "Construction" },
                new Business_Types { Id = 4, Type_Name = "Business" }
                );

            modelBuilder.Entity<Business_Categories>().HasData(
                new Business_Categories {  Id = 1, Type_Id = 1, Category_Name = "Cars" },
                new Business_Categories { Id = 2, Type_Id = 1, Category_Name = "Tires" },
                new Business_Categories { Id =  3, Type_Id = 2, Category_Name = "Meds" },
                new Business_Categories { Id = 4, Type_Id = 2, Category_Name = "Supplies" },
                new Business_Categories { Id = 5, Type_Id = 3, Category_Name = "Tools" },
                new Business_Categories { Id = 6, Type_Id = 3, Category_Name = "Contractors" },
                new Business_Categories { Id = 7, Type_Id = 4, Category_Name = "Trade" },
                new Business_Categories { Id = 8, Type_Id = 4, Category_Name = "Finance" },
                new Business_Categories { Id = 9, Type_Id = 4, Category_Name = "SupplyChain" }
                );

            modelBuilder.Entity<Company_Types_Categories>().HasData(
                new Company_Types_Categories {  Id = 1, CompanyId = 1, Category_Id = 2},
                new Company_Types_Categories { Id = 2, CompanyId = 1, Category_Id = 3 },
                new Company_Types_Categories { Id = 3, CompanyId = 1, Category_Id = 4 },
                new Company_Types_Categories { Id = 4, CompanyId = 2, Category_Id = 1 },
                new Company_Types_Categories { Id = 5, CompanyId = 2, Category_Id = 6 },
                new Company_Types_Categories { Id = 6, CompanyId = 2, Category_Id = 5 }
                );

            modelBuilder.Entity<Notifications>().HasData(
                new Notifications { Id = 1, Title = "Need Supplies", Body = "HP please send us some supplies.", Date_Sent = DateTime.Now, Created_By = "Bill"},
                new Notifications { Id = 2, Title = "Need Cars", Body = "Lambo we need 10 cars by next month. Will pay once delivered.", Date_Sent = DateTime.Now, Created_By = "Bill" }
                );

            modelBuilder.Entity<Notification_Recipient>().HasData(
                new Notification_Recipient { Id = 1, NotificationsId = 1, Type_Id = 2, Category_Id = 4, CompanyId = 1 },
                new Notification_Recipient { Id = 2, NotificationsId = 2, CompanyId = 2 }
                );
        }

    }
}
