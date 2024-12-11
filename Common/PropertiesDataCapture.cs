using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Common
{
    public static class PropertiesDataCapture
    {
        public static void EnterCommonData(out string inputId, out int id, out string firstName, out string lastName, out string inputAge, out int age)
        {
            id = 0;
            firstName = null;
            lastName = null;
            age = 0;
            inputId = null;
            inputAge = null;
            do
            {
                PropertiesDataMessages.InputId();
                inputId = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputId)) return;
            }
            while (!ConsoleValidation.ValidationInputId(inputId));
            id = int.Parse(inputId);
            do
            {
                PropertiesDataMessages.InputFirstName();
                firstName = Console.ReadLine();
                if (!ConsoleValidation.Exit(firstName)) return;
            }
            while (!ConsoleValidation.ValidationNameOrLastName(firstName));
            do
            {
                PropertiesDataMessages.InputLastName();
                lastName = Console.ReadLine();
                if (!ConsoleValidation.Exit(lastName)) return;
            }
            while (!ConsoleValidation.ValidationNameOrLastName(lastName));
            do
            {
                PropertiesDataMessages.InputAge();
                inputAge = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputAge)) return;
            }
            while (!ConsoleValidation.ValidationAge(inputAge));
            age = int.Parse(inputAge);
        }
        public static void EnterCeoData(out string inputCeoYears)
        {
            inputCeoYears = null;
            do
            {
                PropertiesDataMessages.InputCEOAge();
                inputCeoYears = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputCeoYears)) return;
            }
            while (!ConsoleValidation.ValidationCEOAge(inputCeoYears));
        }

        public static void EnterDesignerData(out string inputProject, out string inputCanDraw)
        {
            inputProject = null;
            inputCanDraw = null;
            do
            {
                PropertiesDataMessages.InputProject();
                inputProject = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputProject)) return;
            }
            while (!ConsoleValidation.ValidationString(inputProject));
            do
            {
                PropertiesDataMessages.InputCanDraw();
                inputCanDraw = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputCanDraw)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputCanDraw));
        }
        public static void EnterDeveloperData(out string inputProject, out string inputIsStudent)
        {
            inputProject = null;
            inputIsStudent = null;
            do
            {
                PropertiesDataMessages.InputProject();
                inputProject = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputProject)) return;
            }
            while (!ConsoleValidation.ValidationString(inputProject));
            do
            {
                PropertiesDataMessages.InputIsStudent();
                inputIsStudent = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputIsStudent)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputIsStudent));
        }
        public static void EnterProjectManager(out string inputProject)
        {
            inputProject = null;
            do
            {
                PropertiesDataMessages.InputProject();
                inputProject = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputProject)) return;
            }
            while (!ConsoleValidation.ValidationString(inputProject));
        }
        public static void EnterSoftwareTester(out string inputProject, out string inputUseAutomatedTests)
        {
            inputProject = null;
            inputUseAutomatedTests = null;
            do
            {
                PropertiesDataMessages.InputProject();
                inputProject = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputProject)) return;
            }
            while (!ConsoleValidation.ValidationString(inputProject));
            do
            {
                PropertiesDataMessages.InputUseAutomatedTests();
                inputUseAutomatedTests = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputUseAutomatedTests)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputUseAutomatedTests));
        }
        public static void AddEmployeeRole(out string roleforinput) 
        {
            roleforinput = null;
            do
            {
                StandardMessages.PossibleRoles();
                roleforinput = Console.ReadLine().ToLower();
                if (!ConsoleValidation.Exit(roleforinput)) return;
            } 
            while (!ConsoleValidation.ValidationRole(roleforinput));
        }

        public static void EnterRemoveId(out string inputId, out int id) 
        {
            inputId = null;
            id = 0;
            do
            {
                PropertiesDataMessages.InputId();
                inputId = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputId)) return;
            }
            while (!ConsoleValidation.ValidationRemoveId(inputId));
            id = int.Parse(inputId);
        }
        public static void RoleForRoleList(out string roleforoutput) 
        {
            roleforoutput = null;
            do
            {
                StandardMessages.PossibleRoles();
                roleforoutput = Console.ReadLine().ToLower();
                if (!ConsoleValidation.Exit(roleforoutput)) return;
            }
            while (!ConsoleValidation.ValidationRole(roleforoutput));
        }
    }
}
