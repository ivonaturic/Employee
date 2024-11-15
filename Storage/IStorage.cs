using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Storage
{
    internal interface IStorage<T> where T : class
    {
        void AddEmployees(T entity);
        void RemoveEmployees(T entity);
        IEnumerable<T> GetAll();
    }
}
