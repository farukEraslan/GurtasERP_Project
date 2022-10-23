﻿// <auto-generated />
using System;
using Gurtas.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gurtas.Migrations
{
    [DbContext(typeof(GurtasContext))]
    [Migration("20221023182125_order_table_supplier_contact")]
    partial class order_table_supplier_contact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gurtas.DAL.Entities.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("City")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Country")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.MeasureTools", b =>
                {
                    b.Property<int>("ToolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToolId"), 1L, 1);

                    b.Property<string>("Accuracy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CalibrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificateNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Manufacturer")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MeasureRange")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Model")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NextCalibrationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerialNumber")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ToolName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ToolId");

                    b.HasIndex("UserId");

                    b.ToTable("MeasureTools");

                    b.HasData(
                        new
                        {
                            ToolId = 1,
                            Accuracy = "0,01",
                            CalibrationDate = new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CertificateNumber = "22-4791",
                            Manufacturer = "Mitutoyo",
                            MeasureRange = "0-150",
                            Model = "",
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(2737),
                            NextCalibrationDate = new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(2734),
                            SerialNumber = "B22084436",
                            ToolName = "Kumpas",
                            Type = "Dijital",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("BidNumber")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DeliveryTime")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Material")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PackagingDetail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PaymentTerm")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingDetail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Projects", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ProjectNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Suppliers", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("CompanyRating")
                        .HasColumnType("int");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Goods")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaxOfficeAndNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SupplierId");

                    b.HasIndex("UserId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            Address = "Karadenizliler mah. Ordulu Cad.",
                            CompanyName = "Gürtaş",
                            CompanyRating = 100,
                            ContactName = "Faruk Eraslan",
                            Goods = "Makine İmalatı",
                            IsApproved = true,
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 466, DateTimeKind.Local).AddTicks(176),
                            Phone = "0262 123 45 67",
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 466, DateTimeKind.Local).AddTicks(172),
                            TaxOfficeAndNumber = "1234567890",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(409),
                            Name = "Faruk",
                            Password = "qu4lity",
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(398),
                            Surname = "Eraslan",
                            Username = "farukeraslan"
                        },
                        new
                        {
                            UserId = 2,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(411),
                            Name = "Aykut",
                            Password = "own3r",
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(411),
                            Surname = "Özgür",
                            Username = "aykutozgur"
                        },
                        new
                        {
                            UserId = 3,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(413),
                            Name = "Ali",
                            Password = "pr0duction",
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(412),
                            Surname = "Yılmaz",
                            Username = "aliyilmaz"
                        },
                        new
                        {
                            UserId = 4,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(414),
                            Name = "Cem",
                            Password = "acc0ntting",
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(414),
                            Surname = "Gülpınar",
                            Username = "cemgulpinar"
                        },
                        new
                        {
                            UserId = 5,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(416),
                            Name = "Orhan",
                            Password = "purch4sing",
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(416),
                            Surname = "Özgür",
                            Username = "orhanozgur"
                        },
                        new
                        {
                            UserId = 6,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(418),
                            Name = "Faruk",
                            Password = "log1stic",
                            RecordDate = new DateTime(2022, 10, 23, 21, 21, 25, 465, DateTimeKind.Local).AddTicks(417),
                            Surname = "Kurtoğlu",
                            Username = "farukkurtoglu"
                        });
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Customers", b =>
                {
                    b.HasOne("Gurtas.DAL.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.MeasureTools", b =>
                {
                    b.HasOne("Gurtas.DAL.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Orders", b =>
                {
                    b.HasOne("Gurtas.DAL.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Projects", b =>
                {
                    b.HasOne("Gurtas.DAL.Entities.Customers", "Customer")
                        .WithMany("Projects")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gurtas.DAL.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Suppliers", b =>
                {
                    b.HasOne("Gurtas.DAL.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Customers", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
