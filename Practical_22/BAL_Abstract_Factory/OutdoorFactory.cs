using BAL_Abstract_Factory;
using Business_access_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_AbstractFactory
{
    class OutdoorFactory : AbstractDepartmentFactory
    {
        public IOvertimePay GetFactory(string deptname)
        {
            if (deptname.Equals("Sales"))
            {
                return new SalesOvertimePay();
            }
            else if (deptname.Equals("On-Site"))
            {
                return new OnSiteOverTimePay();
            }
            return null;
        }
    }
}
