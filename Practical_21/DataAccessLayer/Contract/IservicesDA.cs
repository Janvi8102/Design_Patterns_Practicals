using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IservicesDA
    {
        Task<List<Employee>> GetEmployee();
        Task<Employee> PostEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int id);
        Task<Employee> GetEmployeeByID(int id);
    }
}
