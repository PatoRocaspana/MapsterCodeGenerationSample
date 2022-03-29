using MapsterCodeGenerationSample.Models;

namespace MapsterCodeGenerationSample.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
    }
}
