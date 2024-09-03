using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEFCore.Models;

namespace TestEFCore.Configuration
{
    public class GetEmployeeTypeConfiguration : IEntityTypeConfiguration<GetEmployee>
    {
        public void Configure(EntityTypeBuilder<GetEmployee> builder)
        {
            builder.HasNoKey();

        }
    }
}
