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
        protected int baseIdInt;
        protected string basefirstName;
        protected string baselastName;
        protected int baseAgeInt;

        private readonly IStorage<T> _storage;

        public EmployeeBaseService(IStorage<T> storage)
        {
            _storage = storage;
        }
        public virtual void AddEmployeesService() 
        {
            Console.WriteLine("New entry: ");
            Console.WriteLine("Id: ");
            string baseIdString = Console.ReadLine();
            baseIdInt = int.Parse(baseIdString);
            Console.WriteLine("First name: ");
            basefirstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            baselastName = Console.ReadLine();
            Console.WriteLine("Age: ");
            string baseAgeString = Console.ReadLine();
            baseAgeInt = int.Parse(baseAgeString);

            var rememp = _storage.AllEmployees().FirstOrDefault(e => e.Id == baseIdInt);
            if (rememp != null)
            {
                Console.WriteLine("Employee with that ID already exists!");
                return;
            }

            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding {ex.Message}");
            }
        }
        public void RemoveEmployeesService(int id) 
        {
            var rememp = _storage.AllEmployees().SingleOrDefault(e => e.Id == id);
            if (rememp == null)
            {
                Console.WriteLine("The employee does not exist.");
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
                Console.WriteLine($"There are no employees entered for the {role} role!");
                return Enumerable.Empty<T>();
            }
            Console.WriteLine("List by {role}");
            return listbyrole;
        }
    }
}
