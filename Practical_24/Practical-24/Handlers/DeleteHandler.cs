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
    public class DeleteHandler : IRequestHandler<DeleteQuery, bool>
    {

        private readonly IEmployeeRepository employeeRepo;

        public DeleteHandler(IEmployeeRepository employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        Task<bool> IRequestHandler<DeleteQuery, bool>.Handle(DeleteQuery request, CancellationToken cancellationToken)
        {
            return  (employeeRepo.DeleteEmployee(request.emp_id));
        }
    }
}
