﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechBoard.Data;

#nullable disable

namespace TechBoard.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230830125203_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechBoard.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TextBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadRefId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ThreadRefId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TextBody = "Nvidia blabalbla",
                            ThreadRefId = 1,
                            Title = "Nvidia",
                            UserName = "GPUuser"
                        },
                        new
                        {
                            Id = 2,
                            TextBody = "Windows blabalbla",
                            ThreadRefId = 2,
                            Title = "Windows",
                            UserName = "OSuser"
                        },
                        new
                        {
                            Id = 3,
                            TextBody = "Shaman blabalbla",
                            ThreadRefId = 3,
                            Title = "Shaman",
                            UserName = "WOWuser"
                        });
                });

            modelBuilder.Entity("TechBoard.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Hardware"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Software"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Games"
                        });
                });

            modelBuilder.Entity("TechBoard.Models.Thread", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectRefId");

                    b.ToTable("Thread");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Heading = "GPU",
                            SubjectRefId = 1
                        },
                        new
                        {
                            Id = 2,
                            Heading = "OS",
                            SubjectRefId = 2
                        },
                        new
                        {
                            Id = 3,
                            Heading = "WorldOfWarcraft",
                            SubjectRefId = 3
                        });
                });

            modelBuilder.Entity("TechBoard.Models.Post", b =>
                {
                    b.HasOne("TechBoard.Models.Thread", "Thread")
                        .WithMany()
                        .HasForeignKey("ThreadRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Thread");
                });

            modelBuilder.Entity("TechBoard.Models.Thread", b =>
                {
                    b.HasOne("TechBoard.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}
