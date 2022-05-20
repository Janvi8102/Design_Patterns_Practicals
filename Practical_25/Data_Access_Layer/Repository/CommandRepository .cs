using Data_Access_Layer.DataContext;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
   public class CommandRepository : ICommandRepository
    {
        private readonly EmployeeDbContext context;

        public CommandRepository(EmployeeDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> Create(Employee emp)
        {
            if (emp.Id == 0)
            {
                await context.Employees.AddAsync(emp);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
      
        public async Task Edit(Employee emp)
        {
            context.Employees.Update(emp);
            await context.SaveChangesAsync();
        }
        public async Task<bool> Delete(int id)
        {
            var employee = await context.Employees.FindAsync(id);
            if (employee != null)
            {
                employee.emp_status = true;
                context.Employees.Update(employee);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
