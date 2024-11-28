using Employee.Common;
using Employee.Roles;
using Employee.Storage;
using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    public class EmployeeBaseService<T> : IEmployeeBaseService where T : IEmployeeBase
    {
        protected int baseIdInt;
        protected string basefirstName;
        protected string baselastName;
        protected int baseAgeInt;

        protected T _employee;

        public EmployeeBaseService(T employee)
        { 
            _employee = employee;
        }
        
        public virtual void AddEmployeesService() 
        {
            Console.WriteLine("New entry: ");
            Console.WriteLine("Id: ");
            string baseIdString = Console.ReadLine();
            baseIdInt = int.Parse(baseIdString);
            var rememp = EmployeeStorage.AllEmployees().FirstOrDefault(e => e.Id == baseIdInt);
            if (rememp != null)
            {
                Console.WriteLine("Employee with that ID already exists!");
            }
            Console.WriteLine("First name: ");
            basefirstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            baselastName = Console.ReadLine();
            Console.WriteLine("Age: ");
            string baseAgeString = Console.ReadLine();
            baseAgeInt = int.Parse(baseAgeString);
        }
        public void RemoveEmployeesService(int id) 
        {
            var rememp = EmployeeStorage.AllEmployees().SingleOrDefault(e => e.Id == id);
            if (rememp == null)
            {
                Console.WriteLine("The employee does not exist.");
                return;
            }
            try
            {
                EmployeeStorage.RemoveEmployees(rememp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while removing {ex.Message}");
            }
            
        }
        public virtual void DisplayAllEmployees() 
        {
            var allemployees = EmployeeStorage.AllEmployees();
            if (!allemployees.Any())
            {
                Console.WriteLine("No employees entered!");
            }
            else
            {
                foreach (var employee in allemployees)
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
            
            
        }
        public void DisplayEmployeesWithoutCEO() 
        {
            var employeeswithoutceo = EmployeeStorage.AllEmployees().Where(e => e.GetType().Name != "CEO");
            if (!employeeswithoutceo.Any())
            {
                Console.WriteLine("No employees entered!");
            }
            else
            {
                foreach (var employee in employeeswithoutceo)
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
        }
        public void ListByRole(string role) 
        {
            var listbyrole = EmployeeStorage.AllEmployees().Where(e => e.GetType().Name.Equals(role, StringComparison.OrdinalIgnoreCase));
            if (!listbyrole.Any())
            {
                Console.WriteLine($"There are no employees entered for the {role} role!");
            }
            else
            {
                Console.WriteLine($"List by {role}");
                foreach (var employee in listbyrole) 
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
            
        }
    }
}
