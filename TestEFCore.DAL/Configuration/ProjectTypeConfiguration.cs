using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEFCore.Models;

namespace TestEFCore.Configuration
{
    public class ProjectTypeConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(proj => proj.Projectid);
            builder.Property(proj => proj.Projectid).ValueGeneratedOnAdd();
            builder.Property(proj => proj.Projectname).HasMaxLength(100).IsRequired();

            builder.OwnsOne(proj => proj.TimeSlot, ts =>
            {
                ts.Property(ts => ts.Startdate).HasColumnName("Startdate").IsRequired();
                ts.Property(ts => ts.Enddate).HasColumnName("Enddate").IsRequired();
            });

            builder.HasOne(proj => proj.Client)
                .WithMany(cli => cli.Projects)
                .HasForeignKey(proj => proj.Clientid)
                .HasConstraintName("FK_Project_Client")
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);


            builder.ToTable("Projects", schema: "Work");
        }
    }
}
