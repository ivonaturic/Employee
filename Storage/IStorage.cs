using Employee.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Storage
{
    public interface IStorage<T> where T : IEmployeeBase
    {
        void AddEmployees(T entity);
        void RemoveEmployees(T entity);
        IEnumerable<T> AllEmployees();
    }
}
