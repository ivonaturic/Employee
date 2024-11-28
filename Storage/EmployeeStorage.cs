using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Roles;

namespace Employee.Storage
{
    public static class EmployeeStorage
    {
        public static List<EmployeeBase> employeelist = new List<EmployeeBase>();

        public static void AddEmployees(EmployeeBase entity) 
        {
            employeelist.Add(entity);   
        }

        public static void RemoveEmployees(EmployeeBase entity)
        {
            employeelist.Remove(entity);
        }

        public static IEnumerable<EmployeeBase> AllEmployees() 
        {
            return employeelist.ToList();
        }
    }
}
