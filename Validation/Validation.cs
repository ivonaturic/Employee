using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Employee.Constants;

namespace Employee.Validation
{

    public class ConsoleValidation
    {
        public static bool ValidationId(string idstring) 
        {
            int id;
            if (int.TryParse(idstring, out id))
            {
                if (id >= 1)
                {
                    var rememp = EmployeeStorage.AllEmployees().FirstOrDefault(e => e.Id == id);
                    if (rememp != null)
                    {
                        Console.WriteLine($"Employee with ID: {id} already exists!");
                        return false;
                    }
                    return true;
                }
                else
                {
                    ConstantsMessages.EntryPositiveIntegerValidation();
                    return false;
                }
            }
            else
            {
                ConstantsMessages.EntryIntegerValidation();
                return false;
            }



        }
        public static bool ValidationString(string input) 
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                ConstantsMessages.EmptyEntry();
                return false;
            }
            return true;
        }
        public static bool ValidationBoolean(string x)
        {
            bool pp;
            if (bool.TryParse(x, out pp))
            {
                return true;
            }
            else
            {
                ConstantsMessages.EntryBooleanValidation();
                return false;
            }
        }
        public static bool ValidationAge(string x)
        {
            int broj;
            if (int.TryParse(x, out broj))
            {
                if (broj>=18 && broj<= 67)
                {
                    return true;
                }
                else 
                {
                    ConstantsMessages.EntryAgeValidation();
                    return false;
                }
            }
            else 
            {
                ConstantsMessages.EntryIntegerValidation();
                return false;
            }
            
        }
        public static bool ValidationCEOAge(string x)
        {
            int broj;
            if (int.TryParse(x, out broj))
            {
                if (broj >= 0 && broj <= 40)
                {
                    return true;
                }
                else
                {
                    ConstantsMessages.EntryCEOAgeValidation();
                    return false;
                }
            }
            else
            {
                ConstantsMessages.EntryIntegerValidation();
                return false;
            }

        }
        public static bool ValidationRole(string x) 
        {
            if (x == ConstantsRoles.CEO || x == ConstantsRoles.PM || x == ConstantsRoles.DEV || x == ConstantsRoles.DSNR || x == ConstantsRoles.ST)
            {

                return true;
            }
            else
            {
                ConstantsMessages.NonExistentRole();
                return false;
            }
        }
        public static bool ValidationNameOrLastName(string x) 
        {
            if (Regex.IsMatch(x, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else 
            {
                ConstantsMessages.EntryLetterValidation();
                return false;
                
            }
        }
        public static bool Exit(string entry)
        {
            if (entry.ToLower() == ConstantsCommands.EXIT)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
