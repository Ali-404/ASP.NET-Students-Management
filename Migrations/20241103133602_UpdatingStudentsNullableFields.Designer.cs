﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsManagement.Data;

#nullable disable

namespace StudentsManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241103133602_UpdatingStudentsNullableFields")]
    partial class UpdatingStudentsNullableFields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("StudentsManagement.Models.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("StudentsManagement.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirdDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("FinalMark")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentClasseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentClasseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentsManagement.Models.Student", b =>
                {
                    b.HasOne("StudentsManagement.Models.Classe", "StudentClasse")
                        .WithMany("Students")
                        .HasForeignKey("StudentClasseId");

                    b.Navigation("StudentClasse");
                });

            modelBuilder.Entity("StudentsManagement.Models.Classe", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
