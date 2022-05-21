using Example.Context;
using Example.Interfaces;
using Example.Models;
using Example.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Example.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IEmployeeService employeeService;

        public EmployeeController(ApplicationDbContext applicationDbContext, IEmployeeService employee)
        {
            this.dbContext = applicationDbContext;
            this.employeeService = employee;
        }

        public IActionResult Datas()
        {
            return View();
        }

        public async Task<ViewResult> Search(string email)
        {
            var viewModel = new EmployeeDetailsViewModel()
            {
                Employee = await employeeService.GetAsync(email)
            };

            return View(viewModel);

        }


    }
}


    

