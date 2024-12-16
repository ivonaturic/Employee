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
        public static void InputCommonData(out string inputId, out int id, out string firstName, out string lastName, out string inputAge, out int age)
        {
            id = 0;
            firstName = null;
            lastName = null;
            age = 0;
            inputId = null;
            inputAge = null;
            do
            {
                Console.WriteLine(StaticMessages.InputId);
                inputId = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputId)) return;
            }
            while (!ConsoleValidation.ValidationInputId(inputId));
            id = int.Parse(inputId);
            do
            {
                Console.WriteLine(StaticMessages.InputFirstName);
                firstName = Console.ReadLine();
                if (!ConsoleValidation.Exit(firstName)) return;
            }
            while (!ConsoleValidation.ValidationNameOrLastName(firstName));
            do
            {
                Console.WriteLine(StaticMessages.InputLastName);
                lastName = Console.ReadLine();
                if (!ConsoleValidation.Exit(lastName)) return;
            }
            while (!ConsoleValidation.ValidationNameOrLastName(lastName));
            do
            {
                Console.WriteLine(StaticMessages.InputAge);
                inputAge = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputAge)) return;
            }
            while (!ConsoleValidation.ValidationAge(inputAge));
            age = int.Parse(inputAge);
        }
        public static void InputCeoData(out string inputCeoYears)
        {
            inputCeoYears = null;
            do
            {
                Console.WriteLine(StaticMessages.InputCEOAge);
                inputCeoYears = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputCeoYears)) return;
            }
            while (!ConsoleValidation.ValidationCEOAge(inputCeoYears));
        }
        public static void InputProject(out string inputProject) 
        {
            inputProject = null;
            do
            {
                Console.WriteLine(StaticMessages.InputProject);
                inputProject = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputProject)) return;
            }
            while (!ConsoleValidation.ValidationEmptyString(inputProject));
        }
        public static void InputDesignerData(out string inputProject, out string inputCanDraw)
        {
            inputProject = null;
            inputCanDraw = null;
            InputProject(out inputProject);
            do
            {
                Console.WriteLine(StaticMessages.InputCanDraw);
                inputCanDraw = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputCanDraw)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputCanDraw));
        }
        public static void InputDeveloperData(out string inputProject, out string inputIsStudent)
        {
            inputProject = null;
            inputIsStudent = null;
            InputProject(out inputProject);
            do
            {
                Console.WriteLine(StaticMessages.InputIsStudent);
                inputIsStudent = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputIsStudent)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputIsStudent));
        }
        public static void InputProjectManagerData(out string inputProject)
        {
            inputProject = null;
            InputProject(out inputProject);
        }
        public static void InputSoftwareTesterData(out string inputProject, out string inputUseAutomatedTests)
        {
            inputProject = null;
            inputUseAutomatedTests = null;
            InputProject(out inputProject);
            do
            {
                Console.WriteLine(StaticMessages.InputUseAutomatedTests);
                inputUseAutomatedTests = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputUseAutomatedTests)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputUseAutomatedTests));
        }
        public static void InputRole(out string inputRole) 
        {
            inputRole = null;
            do
            {
                Console.WriteLine(StaticMessages.PossibleRoles);
                inputRole = Console.ReadLine().ToLower();
                if (!ConsoleValidation.Exit(inputRole)) return;
            } 
            while (!ConsoleValidation.ValidationRole(inputRole));
        }

        public static void InputRemoveId(out string inputId, out int id) 
        {
            inputId = null;
            id = 0;
            do
            {
                Console.WriteLine(StaticMessages.InputId);
                inputId = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputId)) return;
            }
            while (!ConsoleValidation.ValidationRemoveId(inputId));
            id = int.Parse(inputId);
        }
    }
}
