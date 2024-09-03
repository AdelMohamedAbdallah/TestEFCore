using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEFCore.Models;

namespace TestEFCore.Configuration
{
    public class EmployeeProjectTypeConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.HasKey(empproj => new { empproj.Projectid, empproj.Employeeid });

            builder.HasOne(empproj => empproj.Project)
                .WithMany(proj => proj.EmployeeProjects)
                .HasForeignKey(empproj => empproj.Projectid)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(empproj => empproj.Employee)
                .WithMany(proj => proj.EmployeeProjects)
                .HasForeignKey(empproj => empproj.Employeeid)
                .OnDelete(DeleteBehavior.Restrict);


            builder.ToTable("EmployeeProjects", schema: "Work");
        }
    }
}
