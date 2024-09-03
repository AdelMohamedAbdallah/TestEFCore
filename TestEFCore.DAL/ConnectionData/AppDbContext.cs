using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using TestEFCore.Configuration;
using TestEFCore.Models;

namespace TestEFCore.ConnectionData;

public partial class AppDbContext : DbContext
{
    //public AppDbContext(DbContextOptions option)
    //    : base(option)
    //{

    //}

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<GetEmployee> GetEmployees { get; set; }

    public virtual DbSet<DataofEmployees> DataofEmployees { get; set; }




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var configuration = new ConfigurationBuilder().AddJsonFile("appsittings.json").Build();
        var connection = configuration.GetSection("Connection String").Value;

        optionsBuilder.UseSqlServer(connection, o => o.MinBatchSize(1).MaxBatchSize(3));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DepartmentTypeConfiguration).Assembly);
        modelBuilder.Ignore<GetEmployee>();
    }

    public int GetTotalEmployees()
    {

        var outputParameter = new SqlParameter
        {
            ParameterName = "@TotalOrders",
            SqlDbType = SqlDbType.Int,
            Direction = ParameterDirection.Output
        };
        this.Database.ExecuteSqlRaw("EXEC @TotalOrders = dbo.GetNumberOfEmployees", outputParameter);
        return (int)outputParameter.Value;
    }

}
