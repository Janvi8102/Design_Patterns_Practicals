using MediatR;
using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Queries
{
    //public class GetAllEmployeeQuery :IRequest<List<Employee>>
    //{
    public record GetAllEmployeeQuery() : IRequest<List<Employee>>;
    //public List<Employee> emp { get; set; }


    //}
}
