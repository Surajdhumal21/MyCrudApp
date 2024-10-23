using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCrudApp.Data.Contexts;
using MyCrudApp.Domain.Models;

namespace MyCrudApp.ApiEndpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public EmployeesController(AppDbContext appDbContext) 
        {
            _appDbContext=appDbContext;
        }
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return _appDbContext.employees.ToList();
        }
        [HttpPost]
        public void PostEmployees(Employee employee)
        {
            _appDbContext.employees.Add(employee);
            _appDbContext.SaveChanges();
        }

    }
}
