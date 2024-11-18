using Employee.Common;
using Employee.Storage;
using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    internal class EmployeeBaseService<T> : IEmployeeBaseService<T>
    {
        private readonly IStorage<T> _storage;

        public EmployeeBaseService(IStorage<T> storage)
        {
            _storage = storage;
        }
        virtual public void AddEmployeesService(T entity) 
        {
            _storage.AddEmployees(entity);
        }
        virtual public void RemoveEmployeesService(T entity) 
        {
            _storage.RemoveEmployees(entity);
        }
        public IEnumerable<T> DisplayAllEmployees() 
        {
            return _storage.AllEmployees();
        }
        public IEnumerable<T> DisplayEmployeesWithoutCEO() 
        {
            return _storage.AllEmployees().Where(e => e.GetType().Name != "CEO");
        }
        public IEnumerable<T> ListByRole(string role) 
        {
            return _storage.AllEmployees().Where(e => e.GetType().Name.ToLower() == role.ToLower());
        }
    }
}
