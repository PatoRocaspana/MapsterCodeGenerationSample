using Mapster;
using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Mappers
{
    [Mapper]
    public interface IEmployeeMapper
    {
        EmployeeDto MapToDto(Employee employee);
    }
}
