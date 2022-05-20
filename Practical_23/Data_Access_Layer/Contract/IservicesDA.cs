using Data_Access_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
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
