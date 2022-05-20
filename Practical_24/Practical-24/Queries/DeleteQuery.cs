using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Queries
{
    public class DeleteQuery : IRequest<bool>
    {
        public int emp_id {get; set;}
    }
}
