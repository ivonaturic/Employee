using Employee.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Constants
{
    public class ConstantsMessages
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
            Console.WriteLine("Application will allow you to create employees profiles by role! \n" +
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
        public static void InputIdForRemoveEmployee() 
        {
            Console.WriteLine("Input ID: ");
        }
        public static void ListAllEmployees() 
        {
            Console.WriteLine("List of all employees: ");
        }
        public static void ListWithoutCEO() 
        {
            Console.WriteLine("List without CEO: ");
        }
        public static void NonExistentEmployee() 
        {
            Console.WriteLine("The employee does not exist.");
        }
        public static void NoEnteredEmployee() 
        {
            Console.WriteLine("No employees entered!");
        }
        public static void NewEmployee() 
        {
            Console.WriteLine("New employee: ");
        }
        public static void CEOExist() 
        {
            Console.WriteLine("CEO already exists, there can only be one!");
        }
        public static void EntryIntegerValidation() 
        {
            Console.WriteLine("The entry must be a number!");
        }
        public static void EntryPositiveIntegerValidation() 
        {
            Console.WriteLine("ID must be positive number");
        }
        public static void EntryLetterValidation() 
        {
            Console.WriteLine("The entry must be a letter!");
        }
        public static void EntryCEOAgeValidation() 
        {
            Console.WriteLine("CEO age must be between 0 and 40!");
        }
        public static void EntryAgeValidation() 
        {
            Console.WriteLine("Age must be between 18 and 67!");
        }
        public static void EntryBooleanValidation() 
        {
            Console.WriteLine("The input must be true or false!");
        }
        public static void EmptyEntry() 
        {
            Console.WriteLine("Entry cannot be empty.");
        }
        public const string EnterProject = "Enter project: ";

    }
}
