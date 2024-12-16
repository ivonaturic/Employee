using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Services;
using System.Data;

namespace Employee.Validation
{

    public class ConsoleValidation
    {
        public static bool ValidationInputId(string inputId) 
        {
            int id;
            if (int.TryParse(inputId, out id))
            {
                if (id >= 1)
                {
                    var findEmployee = EmployeeStorage.AllEmployees().FirstOrDefault(e => e.Id == id);
                    if (findEmployee != null)
                    {
                        DynamicMessages.EmployeeAlreadyExistsMessage(id);
                        return false;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine(StaticMessages.PositiveIntegerValidationMessage);
                    return false;
                }
            }
            else
            {
                Console.WriteLine(StaticMessages.IntegerValidationMessage);
                return false;
            }
        }
        public static bool ValidationRemoveId(string removeId)
        {
            int id;
            if (int.TryParse(removeId, out id))
            {
                if (id >= 1)
                {
                    var findEmployee = EmployeeStorage.AllEmployees().FirstOrDefault(e => e.Id == id);
                    if (findEmployee == null)
                    {
                        DynamicMessages.EmployeeNotFoundMessage(id);
                        return false;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine(StaticMessages.PositiveIntegerValidationMessage);
                    return false;
                }
            }
            else
            {
                Console.WriteLine(StaticMessages.IntegerValidationMessage);
                return false;
            }
        }
        public static bool ValidationEmptyString(string input) 
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                Console.WriteLine(StaticMessages.EmptyEntryMessage);
                return false;
            }
            return true;
        }
        public static bool ValidationBoolean(string input)
        {
            bool isValid;
            if (bool.TryParse(input, out isValid))
            {
                return true;
            }
            else
            {
                Console.WriteLine(StaticMessages.BooleanValidationMessage);
                return false;
            }
        }
        public static int age;
        public static bool ValidationAge(string inputAge)
        {
            if (int.TryParse(inputAge, out age))
            {
                if (age>=18 && age <= 67)
                {
                    return true;
                }
                else 
                {
                    Console.WriteLine(StaticMessages.AgeValidationMessage);
                    return false;
                }
            }
            else 
            {
                Console.WriteLine(StaticMessages.IntegerValidationMessage);
                return false;
            }
            
        }
        public static bool ValidationCEOAge(string inputCeoYears)
        {
            int ceoYears;
            if (int.TryParse(inputCeoYears, out ceoYears))
            {
                if (ceoYears >= 0 && ceoYears <= age-18)
                {
                    return true;
                }
                else
                {
                    DynamicMessages.CEOAgeValidationMessage(age);
                    return false;
                }

            }
            else
            {
                Console.WriteLine(StaticMessages.IntegerValidationMessage);
                return false;
            }

        }
        public static bool ValidationNameOrLastName(string input) 
        {
            //@"^[a-zA-ZčćžšđČĆŽŠĐljnj]+$"
            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else 
            {
                Console.WriteLine(StaticMessages.LetterValidationMessage);
                return false;
                
            }
        }
        public static bool Exit(string input)
        {
            if (input.ToLower() == ConstantsCommands.EXIT)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ExitBase(string id, string firstname, string lastname, string age) 
        {
            if (id.ToLower() == ConstantsCommands.EXIT || firstname.ToLower() == ConstantsCommands.EXIT || lastname.ToLower() == ConstantsCommands.EXIT || age.ToLower() == ConstantsCommands.EXIT)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public static bool CheckRoleInstance(IBaseService role) 
        {
            if (role == null) 
            {
                return false;
            }
            return true;
        }
        public static bool ValidationRole(string role)
        {
            string abbreviatedRole = RoleHelper.GetRoleAbbreviation(role);
            if (abbreviatedRole != null)
            {
                return true;
            }
            else
            {
                Console.WriteLine(StaticMessages.NonExistentRoleMessage);
                return false;
            }
        }
    }
}
