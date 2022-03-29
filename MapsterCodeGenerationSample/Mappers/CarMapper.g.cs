using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Mappers;
using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Mappers
{
    public partial class CarMapper : ICarMapper
    {
        public CarDto MapToDto(Car p1)
        {
            return p1 == null ? null : new CarDto()
            {
                Id = p1.Id,
                Brand = p1.Brand,
                Model = p1.Model,
                Year = p1.Year,
                IsOwner = p1.IsOwner
            };
        }
    }
}
