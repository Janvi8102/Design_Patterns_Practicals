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
    public class PostEmployeeHandler : IRequestHandler<PostEmployeeQuery, Employee>
    {
        private readonly IEmployeeRepository employeeRepo;
        public PostEmployeeHandler(IEmployeeRepository employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        public async Task<Employee> Handle(PostEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepo.PostEmployee(request.emp);
        }
    }
}
