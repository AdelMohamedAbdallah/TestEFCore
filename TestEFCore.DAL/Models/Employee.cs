namespace TestEFCore.Models;

public partial class Employee
{
    public virtual int Employeeid { get; set; }

    public virtual string Fname { get; set; } = null!;

    public virtual string Lname { get; set; } = null!;

    public virtual string PhoneNumber { get; set; } = null!;

    public virtual string? Email { get; set; }

    public virtual decimal Salary { get; set; }

    public virtual decimal? NewSalary { get; set; }

    public virtual int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();



    public override string ToString()
    {
        return $"{Fname,-12}" +
                 $"{Lname,-12}" +
                 $"{PhoneNumber,-16}" +
                 $"{Salary,-10}" +
                 $"{NewSalary,-10:F}" +
                 $"{Email}";
    }
}
