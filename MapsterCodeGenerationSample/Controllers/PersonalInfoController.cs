using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Mappers;
using MapsterCodeGenerationSample.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MapsterCodeGenerationSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalInfoController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IPersonalInfoMapper _personalInfoMapper;

        public PersonalInfoController(IEmployeeRepository employeeRepository, IPersonalInfoMapper personalInfoMapper)
        {
            _employeeRepository = employeeRepository;
            _personalInfoMapper = personalInfoMapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PersonalInfoDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get()
        {
            var employees = await _employeeRepository.GetAllAsync();

            if (employees == null)
                return NotFound();

            var personalInfoDtos = employees.Select(employee => _personalInfoMapper.MapToDto(employee));

            return Ok(personalInfoDtos);
        }
    }
}
