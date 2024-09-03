namespace TestEFCore.Models
{
    public class DataofEmployees
    {
        public virtual string Fname { get; set; } = null!;

        public virtual string Lname { get; set; } = null!;

        public virtual string PhoneNumber { get; set; } = null!;

        public virtual string? Email { get; set; }

        public virtual decimal Salary { get; set; }

        public virtual decimal? NewSalary { get; set; }

        public virtual string Name { get; set; } = null!;

        public string? Projectname { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Enddate { get; set; }



        public override string ToString()
        {
            return $"{Fname,-8}" +
                   $"{Lname,-8}" +
                   $"{PhoneNumber}\t" +
                   $"{Salary,-10}" +
                   $"{NewSalary,-8:F}" +
                   $"{Name,-9}" +
                   $"{Email,-20}" +
                   $"{Projectname,-15}" +
                   $"{Startdate.ToString("dd/MM/yyyy")}-{Enddate.ToString("dd/MM/yyyy")}";
        }

    }
}
