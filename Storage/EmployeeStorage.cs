using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Roles;

namespace Employee.Storage
{
    public class EmployeeStorage<T> : IStorage<T> where T : IEmployeeBase
    {
        private readonly List<T> employeelist = new List<T>();

        public void AddEmployees(T entity) 
        {
            employeelist.Add(entity);   
        }

        public void RemoveEmployees(T entity)
        {
            employeelist.Remove(entity);
        }

        public IEnumerable<T> AllEmployees() 
        {
            return employeelist.ToList();
        }
    }
}
