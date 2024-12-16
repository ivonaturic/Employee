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
        public static List<BaseModel> employeelist = new List<BaseModel>();

        public static void AddEmployee(BaseModel entity) 
        {
            employeelist.Add(entity);   
        }

        public static void RemoveEmployee(BaseModel entity)
        {
            employeelist.Remove(entity);
        }

        public static IEnumerable<BaseModel> AllEmployees() 
        {
            return employeelist.ToList();
        }
    }
}
