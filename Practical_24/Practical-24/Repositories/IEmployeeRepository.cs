using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        Task<Employee> PostEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int id);
        List<Employee> GetAllEmployee();

    }
}
