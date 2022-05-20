using Business_access_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_Abstract_Factory
{
   public  interface AbstractDepartmentFactory
    {
        IOvertimePay GetFactory(string deptname);
    }
}
