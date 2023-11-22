﻿// <auto-generated />
using EFCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore_CodeFirst.Migrations
{
    [DbContext(typeof(EmployeeManagementDBContext))]
    [Migration("20231122073949_addedClientInfoTablenew")]
    partial class addedClientInfoTablenew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore_CodeFirst.Models.ClientInfo", b =>
                {
                    b.Property<int>("clientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clientId"));

                    b.Property<string>("clientLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("clientId");

                    b.ToTable("ClientInfo");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Models.EmployeeInfo", b =>
                {
                    b.Property<int>("empNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empNo"));

                    b.Property<int>("empDept")
                        .HasColumnType("int");

                    b.Property<bool>("empIsPermenant")
                        .HasColumnType("bit");

                    b.Property<string>("empName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("empSalary")
                        .HasColumnType("float");

                    b.HasKey("empNo");

                    b.ToTable("EmployeeInfo");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Models.deptInfo", b =>
                {
                    b.Property<int>("deptNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("deptNo"));

                    b.Property<string>("deptLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("deptNo");

                    b.ToTable("DepartmentInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
