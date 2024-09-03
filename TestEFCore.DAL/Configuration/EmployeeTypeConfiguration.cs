using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEFCore.Models;

namespace TestEFCore.Configuration
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasIndex(e => e.Employeeid, "IN_EmployeeId");

            builder.HasIndex(e => e.DepartmentId, "IX_Employees_DepartmentId");

            builder.HasIndex(e => e.PhoneNumber, "IX_Employees_PhoneNumber").IsUnique();

            builder.Property(e => e.Employeeid).ValueGeneratedOnAdd();
            builder.Property(e => e.Email).HasMaxLength(30);
            builder.Property(e => e.Fname)
                .HasMaxLength(10)
                .HasColumnName("FName");
            builder.Property(e => e.Lname)
                .HasMaxLength(10)
                .HasColumnName("LName");
            builder.Property(e => e.NewSalary)
                .HasComputedColumnSql("([Salary]*(0.05)+[Salary])")
                .HasPrecision(10, 2);


            builder.Property(e => e.PhoneNumber).HasMaxLength(18);

            builder.Property(e => e.Salary)
                .HasDefaultValue(3000m)
                .HasPrecision(10, 2);

            builder.ToTable("Employees", schema: "Work");

            builder.ToTable(emp => emp.HasCheckConstraint("CK_Salary", "[Salary] between 1000 and 10000"));

            //builder.UseTphMappingStrategy();


            //builder.Property("EmployeeType")
            //    .HasColumnType("VARCHAR")
            //    .HasMaxLength(9);


            builder.HasOne(emp => emp.Department)
                .WithMany(emp => emp.Employees)
                .HasForeignKey(emp => emp.DepartmentId)
                .HasConstraintName("FK_Department_Eployee")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(emp => emp.Employeeid).HasColumnType("int");
        }
    }
}
