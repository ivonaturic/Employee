using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Constants
{
    public static class CommonDataCapture
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
            while (!ConsoleValidation.ValidationId(inputId));
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

        public static void EnterDesignerData(out string inputCanDraw) 
        {
            inputCanDraw = null;

            do
            {
                PropertiesDataMessages.InputCanDraw();
                inputCanDraw = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputCanDraw)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputCanDraw));
        }
    }
}
