namespace TestEFCore.Models
{
    public class Client
    {
        public int Clintid { get; set; }
        public string? Clientfname { get; set; }
        public string? Clientlname { get; set; }
        public string? ContactNumber { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }

        public override string ToString()
        {
            return $"{Clientfname,-9}" +
                   $"{Clientlname,-9}" +
                   $"{ContactNumber}";
        }
    }
}
