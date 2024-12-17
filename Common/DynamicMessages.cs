using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Common
{
    public static class DynamicMessages
    {
        public static void EmployeeNotFoundMessage(int id)
        {
            Console.WriteLine($"Employee with ID: {id} does not exists!");
        }
        public static void EmployeeListByRole(string role)
        {
            Console.WriteLine($"List by {role} employee: ");
        }
        public static void EmployeeAddedSuccessfully(Type type)
        {
            Console.WriteLine($"{type.Name} added successfully!");
        }
        public static void EmployeeAlreadyExistsMessage(int id)
        {
            Console.WriteLine($"Employee with ID: {id} already exists!");
        }
        public static void NoEmployeesForRoleMessage(string role)
        {
            Console.WriteLine($"No entered employees for {role} role!");
        }
        public static void EmployeeRemovedMessage(int id)
        {
            Console.WriteLine($"Employee with ID: {id} is removed!");
        }
        public static void CEOAgeValidationMessage(int broj)
        {
            Console.WriteLine($"CEO years cannot be greater than {Math.Abs((broj-18))} or less than 0! ");
        }
    }
}
