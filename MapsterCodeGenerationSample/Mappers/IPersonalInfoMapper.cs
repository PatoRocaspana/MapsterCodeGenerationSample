using Mapster;
using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Mappers
{
    [Mapper]
    public interface IPersonalInfoMapper
    {
        PersonalInfoDto MapToDto(Employee employee);
    }
}
