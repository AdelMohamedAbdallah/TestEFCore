using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestEFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddCreationDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Work");

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "Work",
                columns: table => new
                {
                    Clintid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clientfname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Clientlname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Clintid);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "Work",
                columns: table => new
                {
                    Departmentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Departmentid);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                schema: "Work",
                columns: table => new
                {
                    Projectid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Projectname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Clientid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Projectid);
                    table.ForeignKey(
                        name: "FK_Project_Client",
                        column: x => x.Clientid,
                        principalSchema: "Work",
                        principalTable: "Clients",
                        principalColumn: "Clintid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "Work",
                columns: table => new
                {
                    Employeeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, defaultValue: 3000m),
                    NewSalary = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true, computedColumnSql: "([Salary]*(0.05)+[Salary])"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employeeid);
                    table.CheckConstraint("CK_Salary", "[Salary] between 1000 and 10000");
                    table.ForeignKey(
                        name: "FK_Department_Eployee",
                        column: x => x.DepartmentId,
                        principalSchema: "Work",
                        principalTable: "Departments",
                        principalColumn: "Departmentid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                schema: "Work",
                columns: table => new
                {
                    Employeeid = table.Column<int>(type: "int", nullable: false),
                    Projectid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => new { x.Projectid, x.Employeeid });
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_Employeeid",
                        column: x => x.Employeeid,
                        principalSchema: "Work",
                        principalTable: "Employees",
                        principalColumn: "Employeeid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_Projectid",
                        column: x => x.Projectid,
                        principalSchema: "Work",
                        principalTable: "Projects",
                        principalColumn: "Projectid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IN_ContactNumber",
                schema: "Work",
                table: "Clients",
                column: "ContactNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_Employeeid",
                schema: "Work",
                table: "EmployeeProjects",
                column: "Employeeid");

            migrationBuilder.CreateIndex(
                name: "IN_EmployeeId",
                schema: "Work",
                table: "Employees",
                column: "Employeeid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                schema: "Work",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PhoneNumber",
                schema: "Work",
                table: "Employees",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Clientid",
                schema: "Work",
                table: "Projects",
                column: "Clientid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjects",
                schema: "Work");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "Work");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "Work");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "Work");

            migrationBuilder.DropTable(
                name: "Clients",
                schema: "Work");
        }
    }
}
