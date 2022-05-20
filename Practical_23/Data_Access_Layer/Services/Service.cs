using Data_Access_Layer.Data;
using Data_Access_Layer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Services
{
    public class Service : IservicesDA
    {
        private readonly EmployeeDbContext dbContext;

        public Service(EmployeeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var employee = await GetEmployeeByID(id);
            employee.emp_status = false;
            var res= dbContext.Update(employee);
            await dbContext.SaveChangesAsync();
            if (res!=null)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Employee>> GetEmployee()
        {
            return await dbContext.Employees.Include(x=>x.Department).Where(x=>x.emp_status==true).ToListAsync();
        }

        public async Task<Employee> GetEmployeeByID(int id)
        {
            return await dbContext.Employees.Where(x=>x.Id==id).FirstOrDefaultAsync();
   
        }

        public async Task<Employee> PostEmployee(Employee employee)
        {
            var result =await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {

            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }

    }
}
