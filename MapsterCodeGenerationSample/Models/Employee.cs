namespace MapsterCodeGenerationSample.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Children { get; set; }
        public DateTime BirthDate { get; set; }
        public Role? Role { get; set; }
        public Car? Car { get; set; }
    }
}
