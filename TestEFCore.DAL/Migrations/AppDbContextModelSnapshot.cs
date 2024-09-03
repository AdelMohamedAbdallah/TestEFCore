﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestEFCore.ConnectionData;

#nullable disable

namespace TestEFCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestEFCore.Models.Client", b =>
                {
                    b.Property<int>("Clintid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Clintid"));

                    b.Property<string>("Clientfname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Clientlname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Clintid");

                    b.HasIndex(new[] { "ContactNumber" }, "IN_ContactNumber")
                        .IsUnique();

                    b.ToTable("Clients", "Work");
                });

            modelBuilder.Entity("TestEFCore.Models.DataofEmployees", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Enddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("NewSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Projectname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("datetime2");

                    b.ToTable((string)null);

                    b.ToView("DataOfEmployees", "Work");
                });

            modelBuilder.Entity("TestEFCore.Models.Department", b =>
                {
                    b.Property<int>("Departmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Identity:", (1, 1));

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Departmentid"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Departmentid");

                    b.ToTable("Departments", "Work");
                });

            modelBuilder.Entity("TestEFCore.Models.Employee", b =>
                {
                    b.Property<int>("Employeeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employeeid"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("FName");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("LName");

                    b.Property<decimal?>("NewSalary")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasComputedColumnSql("([Salary]*(0.05)+[Salary])");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<decimal>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasDefaultValue(3000m);

                    b.HasKey("Employeeid");

                    b.HasIndex(new[] { "Employeeid" }, "IN_EmployeeId");

                    b.HasIndex(new[] { "DepartmentId" }, "IX_Employees_DepartmentId");

                    b.HasIndex(new[] { "PhoneNumber" }, "IX_Employees_PhoneNumber")
                        .IsUnique();

                    b.ToTable("Employees", "Work", t =>
                        {
                            t.HasCheckConstraint("CK_Salary", "[Salary] between 1000 and 10000");
                        });
                });

            modelBuilder.Entity("TestEFCore.Models.EmployeeProject", b =>
                {
                    b.Property<int>("Projectid")
                        .HasColumnType("int");

                    b.Property<int>("Employeeid")
                        .HasColumnType("int");

                    b.HasKey("Projectid", "Employeeid");

                    b.HasIndex("Employeeid");

                    b.ToTable("EmployeeProjects", "Work");
                });

            modelBuilder.Entity("TestEFCore.Models.Project", b =>
                {
                    b.Property<int>("Projectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Projectid"));

                    b.Property<int?>("Clientid")
                        .HasColumnType("int");

                    b.Property<string>("Projectname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Projectid");

                    b.HasIndex("Clientid");

                    b.ToTable("Projects", "Work");
                });

            modelBuilder.Entity("TestEFCore.Models.Employee", b =>
                {
                    b.HasOne("TestEFCore.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Department_Eployee");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TestEFCore.Models.EmployeeProject", b =>
                {
                    b.HasOne("TestEFCore.Models.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("Employeeid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestEFCore.Models.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("Projectid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TestEFCore.Models.Project", b =>
                {
                    b.HasOne("TestEFCore.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("Clientid")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK_Project_Client");

                    b.OwnsOne("TestEFCore.Models.TimeSlot", "TimeSlot", b1 =>
                        {
                            b1.Property<int>("Projectid")
                                .HasColumnType("int");

                            b1.Property<DateTime>("Enddate")
                                .HasColumnType("datetime2")
                                .HasColumnName("Enddate");

                            b1.Property<DateTime>("Startdate")
                                .HasColumnType("datetime2")
                                .HasColumnName("Startdate");

                            b1.HasKey("Projectid");

                            b1.ToTable("Projects", "Work");

                            b1.WithOwner()
                                .HasForeignKey("Projectid");
                        });

                    b.Navigation("Client");

                    b.Navigation("TimeSlot")
                        .IsRequired();
                });

            modelBuilder.Entity("TestEFCore.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("TestEFCore.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("TestEFCore.Models.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("TestEFCore.Models.Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });
#pragma warning restore 612, 618
        }
    }
}