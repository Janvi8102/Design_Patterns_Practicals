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
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<Employee>>
    {
        private readonly IEmployeeRepository employeeRepo;
        public GetAllEmployeeHandler(IEmployeeRepository employeeRepo )
        {
            this.employeeRepo = employeeRepo;
        }
        public async Task<List<Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(employeeRepo.GetAllEmployee());
        }
    }
}
