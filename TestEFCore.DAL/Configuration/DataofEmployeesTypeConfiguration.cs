using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestEFCore.Models;

namespace TestEFCore.Configuration
{
    internal class DataofEmployeesTypeConfiguration : IEntityTypeConfiguration<DataofEmployees>
    {
        public void Configure(EntityTypeBuilder<DataofEmployees> builder)
        {
            builder.HasNoKey();
            builder.ToView("DataOfEmployees", schema: "Work");

        }
    }
}
