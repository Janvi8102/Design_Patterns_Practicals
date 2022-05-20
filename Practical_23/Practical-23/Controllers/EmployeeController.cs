using Data_Access_Layer;
using Data_Access_Layer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IservicesDA iservicesDA;

        public EmployeeController(IservicesDA iservicesDA)
        {
            this.iservicesDA = iservicesDA;
        }

        [HttpGet]
        public async Task<List<Employee>> GetAllEmployee()
        {
            var employees = await iservicesDA.GetEmployee();
            if (employees != null)
            {
                return employees;
            }
            return employees;
        }

        [HttpPost("AddEmployee")]
        public async Task<Employee> AddEmployee([FromBody] Employee employee)
        {
            var result = await iservicesDA.PostEmployee(employee);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            try
            {
                if (id == employee.Id)
                {
                    await iservicesDA.UpdateEmployee(employee);
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok("Updated Successfull");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await iservicesDA.GetEmployeeByID(id);
            if (employee == null)
            {
                return NotFound();
            }
            await iservicesDA.DeleteEmployee(id);
            return Ok("Deleted Successfull");
        }
    }
}
