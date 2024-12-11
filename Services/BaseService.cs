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
        
        public virtual void AddEmployeesService() 
        {
            StandardMessages.NewEmployee();
            PropertiesDataCapture.EnterCommonData(out inputId, out id, out firstName,out lastName,out inputAge, out age);
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
                StandardMessages.NoEnteredEmployee();
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
            var roleAbbreviations = new Dictionary<string, string>
            {
                { ConstantsRoles.pm, ConstantsRoles.PM }, 
                { ConstantsRoles.dev, ConstantsRoles.DEV }, 
                { ConstantsRoles.dsnr, ConstantsRoles.DSNR } ,
                { ConstantsRoles.st,  ConstantsRoles.ST},
            };
            if (roleAbbreviations.ContainsKey(role))
            {
                role = roleAbbreviations[role];
            }
            var listbyrole = EmployeeStorage.AllEmployees().Where(e => e.GetType().Name.Equals(role, StringComparison.OrdinalIgnoreCase));
            if (!listbyrole.Any())
            {
                if (!ConsoleValidation.Exit(role)) return;
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
