using Example.Context;
using Example.Data.IRepositories;
using Example.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Data.Repositories
{
#pragma warning disable
    public class EmployeeRepository : IEmpolyeeRepository
    {
        internal readonly ApplicationDbContext _dbContext;
        protected DbSet<Employee> _Employees;

        public EmployeeRepository(ApplicationDbContext applicationDbContext)
        {
           _dbContext = applicationDbContext;
           _Employees = _dbContext.Set<Employee>();    

        }
        public async Task<Employee> CreateAsync(Employee employee)
        {
            EntityEntry entry = await _Employees.AddAsync(employee);
           
            await _dbContext.SaveChangesAsync();

            return (Employee)entry.Entity;

        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return _Employees;
        }

        public async Task<Employee> GetAsync(string email)
        {
            return await _Employees.FirstOrDefaultAsync(user => user.Email_Home.Equals(email));
        }

        public async Task<Employee> UpdateAsync(Employee employee)
        {
            EntityEntry entity = _Employees.Update(employee);

            await _dbContext.SaveChangesAsync();

            return (Employee)entity.Entity;
        }
    }
}
