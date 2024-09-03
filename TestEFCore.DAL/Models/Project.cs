namespace TestEFCore.Models
{
    public class Project
    {
        public int Projectid { get; set; }
        public string? Projectname { get; set; }
        public TimeSlot TimeSlot { get; set; } = null!;
        public int? Clientid { get; set; }
        public virtual Client? Client { get; set; }
        public virtual ICollection<EmployeeProject>? EmployeeProjects { get; set; }

        public override string ToString()
        {
            return $"{Projectname,-25}" +
                   $"{TimeSlot.Startdate.ToString("dd/MM/yyyy")}--{TimeSlot.Enddate.ToString("dd/MM/yyyy"),-9}";

        }
    }
}
