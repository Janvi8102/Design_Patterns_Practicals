using Microsoft.EntityFrameworkCore;
using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _empDbContext;

        public EmployeeRepository(EmployeeDbContext appDbContext)
        {
            _empDbContext = appDbContext;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var employee = GetEmployee(id);
            employee.emp_status = false;
            var res = _empDbContext.Update(employee);
            await _empDbContext.SaveChangesAsync();
            if (res != null)
            {
                return true;
            }
            return false;
        }

        public Employee GetEmployee(int id)
        {
            return _empDbContext.Employees.Where(x => x.Id == id && x.emp_status == true).FirstOrDefault();
            

        }

        public List<Employee> GetAllEmployee()
        {
            return _empDbContext.Employees.Include(x => x.Department).Where(x => x.emp_status == true).ToList();
        }

        public async Task<Employee> PostEmployee(Employee employee)
        {
            var result = await _empDbContext.Employees.AddAsync(employee);
            await _empDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            _empDbContext.Employees.Update(employee);
            await _empDbContext.SaveChangesAsync();
            return employee;
        }
    }
}
