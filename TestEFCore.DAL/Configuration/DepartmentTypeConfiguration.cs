using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEFCore.Models;

namespace TestEFCore.Configuration
{
    internal class DepartmentTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(e => e.Departmentid).ValueGeneratedOnAdd()
                .HasAnnotation("Identity:", (1, 1));
            builder.Property(e => e.Name).HasMaxLength(15);

            builder.ToTable("Departments", schema: "Work");
            builder.Property(emp => emp.Departmentid).HasColumnType("int");

        }
    }
}
