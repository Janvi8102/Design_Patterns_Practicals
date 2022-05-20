
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
   public class QueryRepository : IQueryRepository
    {
        private readonly EmployeeDbContext context;

        public QueryRepository(EmployeeDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Employee>> GetEmployee(int? id)
        {
            if (id == null)
            {
                var allemployee = await context.Employees.Include(x => x.Department).ToListAsync();
                await context.SaveChangesAsync();
                return allemployee;
            }
            return await context.Employees.Include(x => x.Department).Where(x => x.Id == id).ToListAsync();
        }
    }
}
