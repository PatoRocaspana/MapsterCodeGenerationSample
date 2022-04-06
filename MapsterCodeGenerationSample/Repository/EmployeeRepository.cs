using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<List<Employee>> GetAllAsync()
        {
            var employeeOne = new Employee()
            {
                Id = 1,
                FirstName = "Johnny",
                LastName = "Bravo",
                BirthDate = new DateTime(1992, 3, 29),
                Children = 3,
                Role = new Role()
                {
                    Id = 1,
                    Name = "Business Advisor",
                    Description = "This is the Business Advisor role description"
                },
                Car = new Car()
                {
                    Id = 1,
                    Brand = "Chevrolet",
                    Model = "Camaro",
                    Year = 2019,
                    IsOwner = true
                }
            };

            var employeeTwo = new Employee()
            {
                Id = 2,
                FirstName = "Angus",
                LastName = "Young",
                BirthDate = new DateTime(1955, 3, 31),
                Children = 7,
                Role = new Role()
                {
                    Id = 1,
                    Name = "Business Advisor",
                    Description = "This is the Business Advisor role description"
                },
                Car = new Car()
                {
                    Id = 2,
                    Brand = "Ford",
                    Model = "Mustang",
                    Year = 2017,
                    IsOwner = false
                }
            };

            var employees = new List<Employee>
            {
                employeeOne,
                employeeTwo
            };

            return employees;
        }
    }
}
