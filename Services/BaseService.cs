using Employee.Common;
using Employee.Roles;
using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using Employee.Validation;

namespace Employee.Services
{
    public class BaseService<T> : IBaseService where T : IBaseModel
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected int age;
        protected string inputId;
        protected string inputAge;

        protected T _employee;

        public BaseService(T employee)
        { 
            _employee = employee;
        }
        
        public virtual void AddEmployeeService() 
        {
            Console.WriteLine(StaticMessages.NewEmployeeMessage);
            PropertiesDataCapture.InputCommonData(out inputId, out id, out firstName,out lastName,out inputAge, out age);
        }
        public virtual void RemoveEmployeeService(int id) 
        {
            var rememp = EmployeeStorage.AllEmployees().SingleOrDefault(e => e.Id == id);
            if (rememp == null)
            {
                DynamicMessages.EmployeeNotFoundMessage(id);
                return;
            }
            else
            {
                EmployeeStorage.RemoveEmployee(rememp);
                DynamicMessages.EmployeeRemovedMessage(id);
            }
        }
        public virtual void DisplayAllEmployees() 
        {
            var allemployees = EmployeeStorage.AllEmployees();
            if (!allemployees.Any())
            {
                Console.WriteLine(StaticMessages.NoEnteredEmployeeMessage);
            }
            else
            {
                Console.WriteLine(StaticMessages.ListOfAllEmployeesMessage);
                foreach (var employee in allemployees)
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
        }
        public virtual void DisplayEmployeesWithoutCEO() 
        {
            var employeeswithoutceo = EmployeeStorage.AllEmployees().Where(e => e.GetType().Name != "CEO");
            if (!employeeswithoutceo.Any())
            {
                Console.WriteLine(StaticMessages.NoEnteredEmployeeMessage);
            }
            else
            {
                Console.WriteLine(StaticMessages.ListWithoutCEOMessage);
                foreach (var employee in employeeswithoutceo)
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
        }
        public virtual void ListByRole(string role) 
        {
            string abbreviatedRole = RoleHelper.GetRoleAbbreviation(role);

            if (abbreviatedRole != null)
            {
                role = abbreviatedRole;
            }
            var listbyrole = EmployeeStorage.AllEmployees().Where(e => e.GetType().Name.Equals(role, StringComparison.OrdinalIgnoreCase));
            if (!listbyrole.Any())
            {
                if (!ConsoleValidation.Exit(role)) return;
                DynamicMessages.NoEmployeesForRoleMessage(role);
            }
            else
            {
                DynamicMessages.EmployeeListByRole(role);
                foreach (var employee in listbyrole) 
                {
                    Console.WriteLine($"{employee.GetInfo()}");
                }
            }
            
        }
    }
}
