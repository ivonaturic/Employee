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
            StandardMessages.NewEmployee();
            CommonDataCapture.EnterCommonData(out inputId, out id, out firstName,out lastName,out inputAge, out age);
        }
        public void RemoveEmployeesService(int id) 
        {
            var rememp = EmployeeStorage.AllEmployees().SingleOrDefault(e => e.Id == id);
            if (rememp == null)
            {
                StandardMessages.NonExistentEmployee();
                return;
            }
            else
            {
                EmployeeStorage.RemoveEmployees(rememp);
                StandardMessages.EmployeeIsRemoved();
            }
        }
        public virtual void DisplayAllEmployees() 
        {
            var allemployees = EmployeeStorage.AllEmployees();
            if (!allemployees.Any())
            {
                PropertiesDataMessages.InputId();
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
                StandardMessages.NoEnteredEmployee();
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
                StandardMessages.NoEnteredEmployee();
            }
            else
            {
                foreach (var employee in listbyrole) 
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
            
        }
    }
}
