namespace TestEFCore.Models;

public partial class Department
{
    public virtual int Departmentid { get; set; }

    public virtual string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public override string ToString()
    {
        return $"{Name}";

    }
}
