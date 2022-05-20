using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
   public interface IQueryRepository
    {
        Task<List<Employee>> GetEmployee(int? id);
    }
}
