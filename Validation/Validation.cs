using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Employee.Constants;
using Employee.Services;

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
                        StandardMessages.EmployeeExists();
                        return false;
                    }
                    return true;
                }
                else
                {
                    PropertiesDataMessages.EntryPositiveIntegerValidation();
                    return false;
                }
            }
            else
            {
                PropertiesDataMessages.EntryIntegerValidation();
                return false;
            }



        }
        public static bool ValidationString(string input) 
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                PropertiesDataMessages.EmptyEntry();
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
                PropertiesDataMessages.EntryBooleanValidation();
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
                    PropertiesDataMessages.EntryAgeValidation();
                    return false;
                }
            }
            else 
            {
                PropertiesDataMessages.EntryIntegerValidation();
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
                    PropertiesDataMessages.EntryCEOAgeValidation();
                    return false;
                }
            }
            else
            {
                PropertiesDataMessages.EntryIntegerValidation();
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
                StandardMessages.NonExistentRole();
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
                PropertiesDataMessages.EntryLetterValidation();
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
        public static bool RoleType(IEmployeeBaseService role) 
        {
            if (role == null) 
            {
                return false;
            }
            return true;
        }
    }
}
