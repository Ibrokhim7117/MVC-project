using Example.Data.IRepositories;
using Example.Interfaces;
using Example.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmpolyeeRepository empolyeeRepository;

        public EmployeeService(IEmpolyeeRepository empolyeeRepository)
        {
            this.empolyeeRepository = empolyeeRepository;

        }
        public async Task<Employee> CreateAsync(Employee employee)
        {
           Employee employeeEntity = new Employee()
           {

               FirstName = employee.FirstName,
               LastName = employee.LastName,
               Address = employee.Address,
               Address_2 = employee.Address_2,  
               Date_Of_Birth = employee.Date_Of_Birth,
               Email_Home  = employee.Email_Home,
               Mobile = employee.Mobile,
               Payroll_Number = employee.Payroll_Number,
               PostCode = employee.PostCode,
               Start_date = employee.Start_date,
               Telephone = employee.Telephone,
               
           };

            return await empolyeeRepository.CreateAsync(employeeEntity);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await empolyeeRepository.GetAllAsync();
        }

        public async Task<Employee> GetAsync(string email)
        {
           return await empolyeeRepository.GetAsync(email);
        }

        public async Task<Employee> UpdateAsync(Employee employee)
        {
           return await empolyeeRepository.UpdateAsync(employee);
        }
    }
}
