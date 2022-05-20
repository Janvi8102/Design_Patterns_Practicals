using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practical_24.Models;
using Practical_24.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public EmployeesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet("GetEmployeeById")]
        public  Task<Employee> GetEmployee(int id)
        {
            return _mediatR.Send(new GetEmployeeQuery { emp_id = id });
        }

        [HttpDelete("DeleteEmployeeById")]
        public async Task<bool> DeleteEmployee(int id)
        {
            return await _mediatR.Send(new DeleteQuery { emp_id = id} );
        }

        [HttpGet("GetAllEmployee")]
        public  Task<List<Employee>> GetAllEmployee()
        {
            return  _mediatR.Send(new GetAllEmployeeQuery());
        }

        [HttpPut("UpdateEmployee")]
        public Task<Employee> UpdateEmployee(Employee employee)
        {
            return _mediatR.Send(new PutEmployeeQuery() { emp = employee });
        }

        [HttpPost("PostEmployee")]
        public Task<Employee> PostEmployee(Employee employee)
        {
            return _mediatR.Send(new PostEmployeeQuery() { emp = employee });
        }
    }
}
