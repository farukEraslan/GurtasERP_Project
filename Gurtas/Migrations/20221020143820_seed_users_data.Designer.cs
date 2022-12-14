// <auto-generated />
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
    [Migration("20221020143820_seed_users_data")]
    partial class seed_users_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                });

            modelBuilder.Entity("Gurtas.DAL.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

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
                            ModifiedDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3294),
                            Password = "qu4lity",
                            RecordDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3281),
                            Username = "farukeraslan"
                        },
                        new
                        {
                            UserId = 2,
                            ModifiedDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3298),
                            Password = "own3r",
                            RecordDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3297),
                            Username = "aykutozgur"
                        },
                        new
                        {
                            UserId = 3,
                            ModifiedDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3301),
                            Password = "pr0duction",
                            RecordDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3300),
                            Username = "aliyilmaz"
                        },
                        new
                        {
                            UserId = 4,
                            ModifiedDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3304),
                            Password = "acc0ntting",
                            RecordDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3303),
                            Username = "cemgulpinar"
                        },
                        new
                        {
                            UserId = 5,
                            ModifiedDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3307),
                            Password = "purch4sing",
                            RecordDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3306),
                            Username = "orhanozgur"
                        },
                        new
                        {
                            UserId = 6,
                            ModifiedDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3310),
                            Password = "log1stic",
                            RecordDate = new DateTime(2022, 10, 20, 17, 38, 20, 495, DateTimeKind.Local).AddTicks(3309),
                            Username = "farukkurtoglu"
                        });
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
#pragma warning restore 612, 618
        }
    }
}
