using MediatR;
using Practical_24.Models;
using Practical_24.Queries;
using Practical_24.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Practical_24.Handlers
{
    public class PutEmployeehandler : IRequestHandler<PutEmployeeQuery, Employee>
    {
          private readonly IEmployeeRepository employeeRepo;
        public PutEmployeehandler(IEmployeeRepository employeeRepo )
        {
            this.employeeRepo = employeeRepo;
        }
        public async Task<Employee> Handle(PutEmployeeQuery request, CancellationToken cancellationToken)
        {
            return  await employeeRepo.UpdateEmployee(request.emp);
        }
    }
}
