using Mapster;
using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Mappers
{
    [Mapper]
    public interface ICarMapper
    {
        CarDto MapToDto(Car car);
    }
}
