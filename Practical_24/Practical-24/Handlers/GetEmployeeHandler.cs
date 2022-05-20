using MediatR;
using Practical_24.Models;
using Practical_24.Queries;
using Practical_24.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Practical_24
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, Employee>
    {
        private readonly IEmployeeRepository employeeRepo;

     

        public GetEmployeeHandler(IEmployeeRepository employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public  Task<Employee> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult( employeeRepo.GetEmployee(request.emp_id));
        }
    }
}
