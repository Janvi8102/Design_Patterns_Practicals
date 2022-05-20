using MediatR;
using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Queries
{
    public class PostEmployeeQuery : IRequest<Employee>
    {
   
         public Employee emp { get; set; }
        
    }
}
