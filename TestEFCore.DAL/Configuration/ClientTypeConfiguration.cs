using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEFCore.Models;

namespace TestEFCore.Configuration
{
    public class ClientTypeConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(cli => cli.Clintid);
            builder.Property(cli => cli.Clintid).ValueGeneratedOnAdd().IsRequired();
            builder.Property(cli => cli.Clientfname).HasMaxLength(25).IsRequired();
            builder.Property(cli => cli.Clientlname).HasMaxLength(25).IsRequired();
            builder.Property(cli => cli.ContactNumber).HasMaxLength(20).IsRequired();
            builder.HasIndex(cli => cli.ContactNumber, "IN_ContactNumber").IsUnique();
            builder.ToTable("Clients", schema: "Work");
        }
    }
}
