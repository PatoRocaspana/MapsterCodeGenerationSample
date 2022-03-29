using Mapster;
using MapsterCodeGenerationSample.Dtos;
using MapsterCodeGenerationSample.Mappers;
using MapsterCodeGenerationSample.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MapsterCodeGenerationSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeMapper _employeeMapper;

        public EmployeeController(IEmployeeRepository employeeRepository, IEmployeeMapper employeeMapper)
        {
            _employeeRepository = employeeRepository;
            _employeeMapper = employeeMapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<EmployeeDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get()
        {
            var employees = await _employeeRepository.GetAllAsync();

            if (employees == null)
                return NotFound();

            var employeesDto = employees.Select(x => _employeeMapper.MapToDto(x)).ToList();

            return Ok(employeesDto);
        }
    }
}
