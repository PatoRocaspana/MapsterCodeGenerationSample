using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Mappers;
using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Mappers
{
    public partial class EmployeeMapper : IEmployeeMapper
    {
        public EmployeeDto MapToDto(Employee p1)
        {
            return p1 == null ? null : new EmployeeDto()
            {
                Id = p1.Id,
                FirstName = p1.FirstName,
                LastName = p1.LastName,
                Childs = (byte)p1.Childs,
                BirthDate = p1.BirthDate,
                RoleId = funcMain1(p1.Role == null ? null : (int?)p1.Role.Id),
                Car = p1.Car == null ? null : new CarDto()
                {
                    Id = p1.Car.Id,
                    Brand = p1.Car.Brand,
                    Model = p1.Car.Model,
                    Year = p1.Car.Year,
                    IsOwner = p1.Car.IsOwner
                },
            };
        }
        
        private int funcMain1(int? p2)
        {
            return p2 == null ? 0 : (int)p2;
        }
    }
}
