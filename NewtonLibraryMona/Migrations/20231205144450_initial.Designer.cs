﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewtonLibraryMona.Data;

#nullable disable

namespace NewtonLibraryMona.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231205144450_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookID")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorID", "BooksBookID");

                    b.HasIndex("BooksBookID");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<int?>("BookLoanId")
                        .HasColumnType("int");

                    b.Property<double?>("Grade")
                        .HasColumnType("float");

                    b.Property<string>("IsBn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("BookLoanId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BookLoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BorowerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BorowerID");

                    b.ToTable("BookLoans");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.Borower", b =>
                {
                    b.Property<int>("BorowerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorowerID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryCardNummber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryCardPin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BorowerID");

                    b.ToTable("Borowers");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("NewtonLibraryMona.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewtonLibraryMona.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.Book", b =>
                {
                    b.HasOne("NewtonLibraryMona.Models.BookLoan", "BookLoan")
                        .WithMany("Books")
                        .HasForeignKey("BookLoanId");

                    b.Navigation("BookLoan");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BookLoan", b =>
                {
                    b.HasOne("NewtonLibraryMona.Models.Borower", "Borower")
                        .WithMany("BookLoan")
                        .HasForeignKey("BorowerID");

                    b.Navigation("Borower");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BookLoan", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.Borower", b =>
                {
                    b.Navigation("BookLoan");
                });
#pragma warning restore 612, 618
        }
    }
}
