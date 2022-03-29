using System;
using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Mappers;
using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Mappers
{
    public partial class PersonalInfoMapper : IPersonalInfoMapper
    {
        public PersonalInfoDto MapToDto(Employee p1)
        {
            if (p1 == null)
                return null;

            var personalInfoDto = new PersonalInfoDto()
            {
                Id = p1.Id,
                CompleteName = string.Format("{0} {1}", p1.FirstName, p1.LastName),
                Childs = (byte)p1.Childs,
                Age = (int)Math.Truncate((DateTime.Now - p1.BirthDate).TotalDays / 365.25d),
                CarInfo = p1.Car.IsOwner == true ? string.Format("{0} is the Owner of the {1}", p1.FirstName, p1.Car.Model) : (p1.Car.IsOwner == false ? string.Format("The {0} belongs to the company", p1.Car.Model) : null)
            };

            Validate(personalInfoDto);

            return personalInfoDto;
        }

        private void Validate(PersonalInfoDto personalInfoDto)
        {
            var ageToRetire = 65;

            personalInfoDto.FitToRetire = personalInfoDto.Age >= ageToRetire;
        }
    }
}
