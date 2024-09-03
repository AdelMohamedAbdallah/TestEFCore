namespace TestEFCore.Models
{
    public class GetEmployee
    {
        public virtual string Fname { get; set; } = null!;

        public virtual string Lname { get; set; } = null!;

        public virtual string PhoneNumber { get; set; } = null!;

        public virtual string? Email { get; set; }

        public virtual decimal Salary { get; set; }

        public virtual decimal? NewSalary { get; set; }

        public virtual string Name { get; set; } = null!;


        public override string ToString()
        {
            return $"{Fname,-12}" +
                   $"{Lname,-12}" +
                   $"{PhoneNumber,-16}" +
                   $"{Salary,-10}" +
                   $"{NewSalary,-10:F}" +
                   $"{Name,-19}" +
                   $"{Email}";
        }
    }
}
