using Example.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Interfaces
{
    public interface IEmployeeService
    {
        Task<Employee> CreateAsync(Employee employee);
       
        Task<IEnumerable<Employee>> GetAllAsync();

        Task<Employee> GetAsync(string email);

        Task<Employee> UpdateAsync(Employee employee);
    }
}
