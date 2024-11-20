using Employee.Common;
using Employee.Roles;
using Employee.Storage;
using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    public class EmployeeBaseService<T> : IEmployeeBaseService<T> where T : EmployeeBase
    {
        private readonly IStorage<T> _storage;

        public EmployeeBaseService(IStorage<T> storage)
        {
            _storage = storage;
        }
        public virtual void AddEmployeesService(T entity) 
        {
            var rememp = _storage.AllEmployees().FirstOrDefault(e => e.Id == entity.Id);
            if (rememp != null)
            {
                Console.WriteLine("Employee already exists!");
                return;
            }
            try
            {
                _storage.AddEmployees(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding {ex.Message}");
            }
        }
        public void RemoveEmployeesService(T entity) 
        {
            var rememp = _storage.AllEmployees().SingleOrDefault(e => e.Id == entity.Id);
            if (rememp == null)
            {
                Console.WriteLine("Non-existent employee");
                return;
            }
            try
            {
                _storage.RemoveEmployees(rememp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while removing {ex.Message}");
            }
            
        }
        public IEnumerable<T> DisplayAllEmployees() 
        {
            var allemployees = _storage.AllEmployees();
            if (!allemployees.Any())
            {
                Console.WriteLine("No employees entered!");
                return Enumerable.Empty<T>();
            }
            return allemployees;
        }
        public IEnumerable<T> DisplayEmployeesWithoutCEO() 
        {
            var employeeswithoutceo = _storage.AllEmployees().Where(e => e.GetType().Name != "CEO");
            if (!employeeswithoutceo.Any())
            {
                Console.WriteLine("No employees entered!");
                return Enumerable.Empty<T>();
            }
            return employeeswithoutceo;
        }
        public IEnumerable<T> ListByRole(string role) 
        {
            var listbyrole = _storage.AllEmployees().Where(e => e.GetType().Name.Equals(role, StringComparison.OrdinalIgnoreCase));
            if (!listbyrole.Any())
            {
                Console.WriteLine("There are no employees entered for the entered role!");
                return Enumerable.Empty<T>();
            }
            return listbyrole;
        }
    }
}
