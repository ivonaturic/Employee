using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Constants
{
    public static class PropertiesDataMessages
    {
        public static void InputId()
        {
            Console.WriteLine("ID: ");
        }
        public static void InputFirstName() 
        {
            Console.WriteLine("First name: ");
        }
        public static void InputLastName() 
        {
            Console.WriteLine("Last name: ");
        }
        public static void InputAge() 
        {
            Console.WriteLine("Age: ");
        }
        public static void InputCEOAge() 
        {
            Console.WriteLine("Years of CEO: ");
        }
        public static void InputCanDraw() 
        {
            Console.WriteLine("Can draw? true/false ");
        }
        public static void InputProject()
        {
            Console.WriteLine("Enter project: ");
        }
        public static void InputIsStudent() 
        {
            Console.WriteLine("Is student? true/false ");
        }
        public static void InputUseAutomatedTests() 
        {
            Console.WriteLine("Is student? true/false ");
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
    }
}
