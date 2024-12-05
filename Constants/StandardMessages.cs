using Employee.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Constants
{
    public class StandardMessages
    {
        public static void WelcomeMessage() 
        {
            Console.WriteLine("Welcome to application!");
        }
        public static void PossibleCommands() 
        {
            Console.WriteLine("Possible commands: Help, Add, Remove, Display, List, RoleList");
        }
        public static void HelpCommand() 
        {
            Console.WriteLine("Application will allow you to create and search employees profiles by role! \n" +
                              "\n"+
                              "Add is for adding new employee including CEO. There can only be one CEO! \n" +
                              "Remove is used for remove employee by ID. CEO also can be removed with this method!\n" +
                              "Display shows a list of all employes including CEO!\n" +
                              "List shows a list of all employees without CEO!\n" +
                              "RoleList shows employees by role!\n");
        }
        public static void PossibleRoles() 
        {
            Console.WriteLine("Possible roles: CEO, ProjectManager, Developer, Designer, SoftwareTester");
        }
        public static void NonExistentCommand() 
        {
            Console.WriteLine("Non-existent command!");
        }
        public static void NonExistentRole()
        {
            Console.WriteLine("Non-existent role!");
        }
        public static void NonExistentEmployee()
        {
            Console.WriteLine("Non-existent employee!");
        }
        public static void NewEmployee()
        {
            Console.WriteLine("New employee: ");
        }
        public static void EmployeeIsRemoved() 
        {
            Console.WriteLine("Employee is removed!");
        }
        public static void NoEnteredEmployee()
        {
            Console.WriteLine("No employees entered!");
        }
        public static void ListAllEmployees() 
        {
            Console.WriteLine("List of all employees: ");
        }
        public static void ListWithoutCEO() 
        {
            Console.WriteLine("List without CEO: ");
        }
        public static void CEOExist() 
        {
            Console.WriteLine("CEO already exists, there can only be one!");
        }
        public static void AddedSuccessfully()
        {
            Console.WriteLine("Added successfully!");
        }
        public static void EmployeeExists()
        {
            Console.WriteLine("Employee already exists!");
        }

    }
}
