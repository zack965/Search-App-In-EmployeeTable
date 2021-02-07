﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tp02skito.Data;

namespace tp02skito.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210207082909_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("tp02skito.Models.Employee", b =>
                {
                    b.Property<int>("empId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("empAge")
                        .HasColumnType("int");

                    b.Property<string>("empName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empPrenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empId");

                    b.ToTable("employee");
                });
#pragma warning restore 612, 618
        }
    }
}
