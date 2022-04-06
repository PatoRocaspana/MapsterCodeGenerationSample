namespace MapsterCodeGenerationSample.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public byte Children { get; set; }
        public DateTime BirthDate { get; set; }
        public int RoleId { get; set; }
        public CarDto? Car { get; set; }
    }
}
