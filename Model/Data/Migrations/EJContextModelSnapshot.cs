﻿// <auto-generated />
using System;
using EloctrnicJournal_EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EloctrnicJournal_EF.Migrations
{
    [DbContext(typeof(EJContext))]
    partial class EJContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parent");
                });

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Passes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatePass")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("StudenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Passes");
                });

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Ratings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateRating")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Student", b =>
                {
                    b.HasOne("EloctrnicJournal_EF.Model.Parent", "Parent")
                        .WithMany("Student")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EloctrnicJournal_EF.Model.Teacher", "Teacher")
                        .WithMany("Student")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Parent", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("EloctrnicJournal_EF.Model.Teacher", b =>
                {
                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
