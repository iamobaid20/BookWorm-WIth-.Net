﻿// <auto-generated />
using System;
using Bookworm_cs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookworm_cs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240226081923_gammaIntegration")]
    partial class gammaIntegration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookWorm_cs.Models.ProductType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"));

                    b.Property<string>("TypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("BookWorm_cs.Models.Shelf", b =>
                {
                    b.Property<int>("ShelfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShelfId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int");

                    b.HasKey("ShelfId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Shelfs");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Beneficiary", b =>
                {
                    b.Property<int>("BenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BenId"));

                    b.Property<string>("AccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BenId");

                    b.ToTable("Beneficiaries");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float?>("InvoiceAmount")
                        .HasColumnType("real");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Bookworm_cs.Models.InvoiceDetails", b =>
                {
                    b.Property<int>("InvDtlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvDtlId"));

                    b.Property<double?>("BasePrice")
                        .HasColumnType("float");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("RentingDays")
                        .HasColumnType("int");

                    b.Property<double?>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<int?>("TransactionTypeId")
                        .HasColumnType("int");

                    b.HasKey("InvDtlId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<string>("LanguageDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Bookworm_cs.Models.LibraryPackage", b =>
                {
                    b.Property<int>("LibraryPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibraryPackageId"));

                    b.Property<int>("MaxBooks")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfDays")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("LibraryPackageId");

                    b.ToTable("LibraryPackages");
                });

            modelBuilder.Entity("Bookworm_cs.Models.PackageProduct", b =>
                {
                    b.Property<int>("packageProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("packageProductId"));

                    b.Property<int>("LibrarypackageId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("packageProductId");

                    b.HasIndex("LibrarypackageId");

                    b.HasIndex("ProductId");

                    b.ToTable("PackageProducts");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BasePrice")
                        .HasColumnType("float");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsLibrary")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRentable")
                        .HasColumnType("bit");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("LongDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MinRentDays")
                        .HasColumnType("int");

                    b.Property<string>("OfferExpDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("OfferPrice")
                        .HasColumnType("float");

                    b.Property<string>("ProductEngName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("RentPerDay")
                        .HasColumnType("float");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SpecialCost")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Bookworm_cs.Models.ProductBeneficiary", b =>
                {
                    b.Property<int>("ProdBenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdBenId"));

                    b.Property<int>("BenId")
                        .HasColumnType("int");

                    b.Property<int>("BeneficiaryBenId")
                        .HasColumnType("int");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProdBenId");

                    b.HasIndex("BeneficiaryBenId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductBeneficiaries");
                });

            modelBuilder.Entity("Bookworm_cs.Models.RoyaltyCalculation", b =>
                {
                    b.Property<int>("RoycalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoycalId"));

                    b.Property<double>("Baseprice")
                        .HasColumnType("float");

                    b.Property<int>("BenId")
                        .HasColumnType("int");

                    b.Property<int>("BeneficiaryBenId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProdId")
                        .HasColumnType("int");

                    b.Property<double>("RoyaltyOnBasePrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("RoycalTrandate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Saleprice")
                        .HasColumnType("float");

                    b.Property<int>("Trantype")
                        .HasColumnType("int");

                    b.HasKey("RoycalId");

                    b.HasIndex("BeneficiaryBenId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("RoyaltyCalculations");
                });

            modelBuilder.Entity("Bookworm_cs.Models.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionTypeId"));

                    b.Property<string>("TransactionDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionType");
                });

            modelBuilder.Entity("BookWorm_cs.Models.Shelf", b =>
                {
                    b.HasOne("Bookworm_cs.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookworm_cs.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookworm_cs.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Invoice", b =>
                {
                    b.HasOne("Bookworm_cs.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Bookworm_cs.Models.InvoiceDetails", b =>
                {
                    b.HasOne("Bookworm_cs.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId");

                    b.HasOne("Bookworm_cs.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("Bookworm_cs.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId");

                    b.Navigation("Invoice");

                    b.Navigation("Product");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Bookworm_cs.Models.PackageProduct", b =>
                {
                    b.HasOne("Bookworm_cs.Models.LibraryPackage", "LibraryPackage")
                        .WithMany()
                        .HasForeignKey("LibrarypackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookworm_cs.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LibraryPackage");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Bookworm_cs.Models.Product", b =>
                {
                    b.HasOne("Bookworm_cs.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.HasOne("BookWorm_cs.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");

                    b.Navigation("Language");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Bookworm_cs.Models.ProductBeneficiary", b =>
                {
                    b.HasOne("Bookworm_cs.Models.Beneficiary", "Beneficiary")
                        .WithMany()
                        .HasForeignKey("BeneficiaryBenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookworm_cs.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beneficiary");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Bookworm_cs.Models.RoyaltyCalculation", b =>
                {
                    b.HasOne("Bookworm_cs.Models.Beneficiary", "Beneficiary")
                        .WithMany()
                        .HasForeignKey("BeneficiaryBenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookworm_cs.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beneficiary");

                    b.Navigation("Invoice");
                });
#pragma warning restore 612, 618
        }
    }
}
