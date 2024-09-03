namespace TestEFCore.Models
{
    public class EmployeeProject
    {
        public int Employeeid { get; set; }
        public int Projectid { get; set; }
        public Employee Employee { get; set; } = null!;
        public Project Project { get; set; } = null!;


    }
}
