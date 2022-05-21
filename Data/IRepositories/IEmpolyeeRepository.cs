using Example.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Data.IRepositories
{
    public interface IEmpolyeeRepository
    {

        Task<Employee> CreateAsync(Employee employee);
        Task<Employee> UpdateAsync(Employee employee);
        Task<Employee> GetAsync(string  email);
        Task<IEnumerable<Employee>> GetAllAsync();
    }
}
