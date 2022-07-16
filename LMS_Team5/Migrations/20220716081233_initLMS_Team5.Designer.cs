﻿// <auto-generated />
using System;
using LMS_Team5.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LMS_Team5.Migrations
{
    [DbContext(typeof(DataAccessLayerDB))]
    [Migration("20220716081233_initLMS_Team5")]
    partial class initLMS_Team5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LMS_Team5.Model.AppliedLeaveDB", b =>
                {
                    b.Property<int>("Applied_Leave_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Leave_Id")
                        .HasColumnType("int");

                    b.Property<string>("Leave_Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leave_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leave_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("No_OfDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Applied_Leave_Id");

                    b.ToTable("appliedLeaves");
                });

            modelBuilder.Entity("LMS_Team5.Model.EmployeeDB", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Emp_Dept")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Emp_Doj")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emp_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Emp_LeaveBal")
                        .HasColumnType("int");

                    b.Property<string>("Emp_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Emp_Phone")
                        .HasColumnType("bigint");

                    b.HasKey("Emp_Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("LMS_Team5.Model.LeaveDetailsDB", b =>
                {
                    b.Property<int>("Leave_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Applied_On")
                        .HasColumnType("datetime2");

                    b.Property<int>("Emp_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Leave_Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leave_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leave_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager_Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("No_OfDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Leave_Id");

                    b.HasIndex("Emp_Id");

                    b.ToTable("leaveDetails");
                });

            modelBuilder.Entity("LMS_Team5.Model.ManagerDB", b =>
                {
                    b.Property<int>("Man_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Man_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Man_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Man_Phone")
                        .HasColumnType("bigint");

                    b.HasKey("Man_Id");

                    b.ToTable("managers");
                });

            modelBuilder.Entity("LMS_Team5.Model.LeaveDetailsDB", b =>
                {
                    b.HasOne("LMS_Team5.Model.EmployeeDB", "EmployeeDB")
                        .WithMany()
                        .HasForeignKey("Emp_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeDB");
                });
#pragma warning restore 612, 618
        }
    }
}
