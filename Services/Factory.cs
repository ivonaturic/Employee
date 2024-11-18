using Employee.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    public class Factory
    {
        public static IEmployeeBaseService SwitchEmployeeRole(string role)
        {
            switch (role) 
            {
                case "CEO":
                    return new EmployeeCEOService();
                case "ProjectManager":
                    return new EmployeeProjectManagerService();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
