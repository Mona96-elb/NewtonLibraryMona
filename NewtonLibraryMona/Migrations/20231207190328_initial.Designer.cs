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
    [Migration("20231207190328_initial")]
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

                    b.Property<int?>("BorowerCardID")
                        .HasColumnType("int");

                    b.Property<double?>("Grade")
                        .HasColumnType("float");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("IsBn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("BorowerCardID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BookLoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("BorowerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookID")
                        .IsUnique();

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

                    b.HasKey("BorowerID");

                    b.ToTable("Borowers");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BorowerCard", b =>
                {
                    b.Property<int>("BorowerCardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorowerCardID"));

                    b.Property<int>("BorowerID")
                        .HasColumnType("int");

                    b.Property<string>("LibraryCardNummber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryCardPin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BorowerCardID");

                    b.HasIndex("BorowerID")
                        .IsUnique();

                    b.ToTable("BorowerCard");
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
                    b.HasOne("NewtonLibraryMona.Models.BorowerCard", null)
                        .WithMany("Books")
                        .HasForeignKey("BorowerCardID");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BookLoan", b =>
                {
                    b.HasOne("NewtonLibraryMona.Models.Book", "Book")
                        .WithOne("BookLoan")
                        .HasForeignKey("NewtonLibraryMona.Models.BookLoan", "BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewtonLibraryMona.Models.Borower", "Borower")
                        .WithMany("BookLoans")
                        .HasForeignKey("BorowerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Borower");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BorowerCard", b =>
                {
                    b.HasOne("NewtonLibraryMona.Models.Borower", "borower")
                        .WithOne("BorowerCard")
                        .HasForeignKey("NewtonLibraryMona.Models.BorowerCard", "BorowerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("borower");
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.Book", b =>
                {
                    b.Navigation("BookLoan")
                        .IsRequired();
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.Borower", b =>
                {
                    b.Navigation("BookLoans");

                    b.Navigation("BorowerCard")
                        .IsRequired();
                });

            modelBuilder.Entity("NewtonLibraryMona.Models.BorowerCard", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}