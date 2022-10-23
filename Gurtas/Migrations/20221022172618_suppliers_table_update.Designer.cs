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
    [Migration("20221022172618_suppliers_table_update")]
    partial class suppliers_table_update
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
                            ModifiedDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(5935),
                            NextCalibrationDate = new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(5926),
                            SerialNumber = "B22084436",
                            ToolName = "Kumpas",
                            Type = "Dijital",
                            UserId = 1
                        });
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
                            ModifiedDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1025),
                            Name = "Faruk",
                            Password = "qu4lity",
                            RecordDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1013),
                            Surname = "Eraslan",
                            Username = "farukeraslan"
                        },
                        new
                        {
                            UserId = 2,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1027),
                            Name = "Aykut",
                            Password = "own3r",
                            RecordDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1027),
                            Surname = "Özgür",
                            Username = "aykutozgur"
                        },
                        new
                        {
                            UserId = 3,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1029),
                            Name = "Ali",
                            Password = "pr0duction",
                            RecordDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1029),
                            Surname = "Yılmaz",
                            Username = "aliyilmaz"
                        },
                        new
                        {
                            UserId = 4,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1031),
                            Name = "Cem",
                            Password = "acc0ntting",
                            RecordDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1030),
                            Surname = "Gülpınar",
                            Username = "cemgulpinar"
                        },
                        new
                        {
                            UserId = 5,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1032),
                            Name = "Orhan",
                            Password = "purch4sing",
                            RecordDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1032),
                            Surname = "Özgür",
                            Username = "orhanozgur"
                        },
                        new
                        {
                            UserId = 6,
                            Gender = "Erkek",
                            ModifiedDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1034),
                            Name = "Faruk",
                            Password = "log1stic",
                            RecordDate = new DateTime(2022, 10, 22, 20, 26, 17, 651, DateTimeKind.Local).AddTicks(1033),
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

            modelBuilder.Entity("Gurtas.DAL.Entities.Suppliers", b =>
                {
                    b.HasOne("Gurtas.DAL.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
