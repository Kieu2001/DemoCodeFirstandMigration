﻿// <auto-generated />
using Demo1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo1.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20230519014138_intialDB")]
    partial class intialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Demo1.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Demo1.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Demo1.Models.PersonCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Current")
                        .HasColumnType("bit");

                    b.Property<int>("FromYear")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RefToCompany")
                        .HasColumnType("int");

                    b.Property<int>("RefToPerson")
                        .HasColumnType("int");

                    b.Property<int>("ToYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RefToCompany");

                    b.HasIndex("RefToPerson");

                    b.ToTable("PersonCompany");
                });

            modelBuilder.Entity("Demo1.Models.PersonCompany", b =>
                {
                    b.HasOne("Demo1.Models.Company", "Company")
                        .WithMany("People")
                        .HasForeignKey("RefToCompany")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Models.Person", "Person")
                        .WithMany("Companies")
                        .HasForeignKey("RefToPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Demo1.Models.Company", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("Demo1.Models.Person", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}