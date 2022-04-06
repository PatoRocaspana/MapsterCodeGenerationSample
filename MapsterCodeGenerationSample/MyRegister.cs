using Mapster;
using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample
{
    public class MyRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Employee, PersonalInfoDto>()
            .Map(dest => dest.CompleteName, src => $"{src.FirstName} {src.LastName}")

            .Map(dest => dest.Age, src => Math.Truncate((DateTime.Now - src.BirthDate).TotalDays / 365.25))

            .Map(dest => dest.CarInfo,
                src => $"{src.FirstName} is the Owner of the {src.Car.Model}",
                srcCond => srcCond.Car.IsOwner)

            .Map(dest => dest.CarInfo,
                src => $"The {src.Car.Model} belongs to the company",
                srcCond => !srcCond.Car.IsOwner);
        }
    }
}
