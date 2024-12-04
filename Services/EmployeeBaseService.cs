using Employee.Constants;
using Employee.Roles;
using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Employee.Validation;

namespace Employee.Services
{
    public class EmployeeBaseService<T> : IEmployeeBaseService where T : IEmployeeBase
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected int age;
        protected string inputId;
        protected string inputAge;

        protected T _employee;

        public EmployeeBaseService(T employee)
        { 
            _employee = employee;
        }
        
        public virtual void AddEmployeesService() 
        {
            ConstantsMessages.NewEmployee();
            do
            {
                Console.WriteLine("Id: ");
                inputId = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputId)) return;
            }
            while (!ConsoleValidation.ValidationId(inputId));
            id = int.Parse(inputId);
            do
            {
                Console.WriteLine("First name: ");
                firstName = Console.ReadLine();
                if (!ConsoleValidation.Exit(firstName)) return;
            } 
            while (!ConsoleValidation.ValidationNameOrLastName(firstName));
            do
            {
                Console.WriteLine("Last name: ");
                lastName = Console.ReadLine();
                if (!ConsoleValidation.Exit(lastName)) return;
            } 
            while (!ConsoleValidation.ValidationNameOrLastName(lastName));
            do
            {
                Console.WriteLine("Age: ");
                inputAge = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputAge)) return;
            } 
            while (!ConsoleValidation.ValidationAge(inputAge));
            age = int.Parse(inputAge);
        }
        public void RemoveEmployeesService(int id) 
        {
            var rememp = EmployeeStorage.AllEmployees().SingleOrDefault(e => e.Id == id);
            if (rememp == null)
            {
                ConstantsMessages.NonExistentEmployee();
                return;
            }
            else
            {
                EmployeeStorage.RemoveEmployees(rememp);
                Console.WriteLine($"Employee with ID = {id} is removed!");
            }
        }
        public virtual void DisplayAllEmployees() 
        {
            var allemployees = EmployeeStorage.AllEmployees();
            if (!allemployees.Any())
            {
                ConstantsMessages.NoEnteredEmployee();
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
                ConstantsMessages.NoEnteredEmployee();
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
                Console.WriteLine($"List of {role} role");
                foreach (var employee in listbyrole) 
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
            
        }
    }
}
