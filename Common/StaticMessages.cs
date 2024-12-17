using Employee.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Common
{
    public class StaticMessages
    {
        //Generally
        public static readonly string WelcomeMessage = "Welcome to application!";
        public static readonly string PossibleCommands = "Possible commands: Help, Add, Remove, Display, List, RoleList";
        public static readonly string HelpCommand = "Application will allow you to create and search employees profiles by role! \n" +
                              "\n" +
                              "Add is for adding new employee including CEO. There can only be one CEO! \n" +
                              "Remove is used for remove employee by ID. CEO also can be removed with this method!\n" +
                              "Display shows a list of all employes including CEO!\n" +
                              "List shows a list of all employees without CEO!\n" +
                              "RoleList shows employees by role!\n";
        public static readonly string PossibleRoles = "Possible roles: CEO, ProjectManager, Developer, Designer, SoftwareTester";

        //Input
        public static readonly string InputId = "Id: ";
        public static readonly string InputFirstName = "First name: ";
        public static readonly string InputLastName = "Last name: ";
        public static readonly string InputAge = "Age: ";
        public static readonly string InputCEOAge = "Years of CEO: ";
        public static readonly string InputCanDraw = "Can draw? true/false ";
        public static readonly string InputProject = "Enter project: ";
        public static readonly string InputIsStudent = "Is student? true/false ";
        public static readonly string InputUseAutomatedTests = "Use automated tests? true/false ";

        //Validation messages
        public static readonly string IntegerValidationMessage = "The input must be a number!";
        public static readonly string PositiveIntegerValidationMessage = "Id must be greater or equals 1!";
        public static readonly string LetterValidationMessage = "The input must be a letter!";
        public static readonly string AgeValidationMessage = "Age must be between 18 and 67!";
        public static readonly string BooleanValidationMessage = "The input must be true or false!";
        public static readonly string EmptyEntryMessage = "The input cannot be empty.";

        //Error messages
        public static readonly string NonExistentCommandMessage = "Non-existent command!";
        public static readonly string NonExistentRoleMessage = "Non-existent role!";

        public static readonly string NewEmployeeMessage = "New employee: ";
        public static readonly string NoEnteredEmployeeMessage = "List does not contain any employees.";
        public static readonly string ListOfAllEmployeesMessage = "List of all employees: ";
        public static readonly string ListWithoutCEOMessage = "List without CEO: ";
        public static readonly string CEOExistenceMessage = "CEO already exists, there can only be one!"; 
    }
}
