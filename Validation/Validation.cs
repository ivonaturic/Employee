using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee.Validation
{

    public static class EmployeeValidation
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
                        Console.WriteLine("Employee with that ID already exists!");
                        return false;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("ID must be positive number");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("ID must be a number!");
                return false;
            }



        }
        public static bool ValidationString(string input) 
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                Console.WriteLine("Entry cannot be empty.");
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
                Console.WriteLine("The input must be true or false!");
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
                    Console.WriteLine("Age must be between 18 and 67!");
                    return false;
                }
            }
            else 
            {
                Console.WriteLine("The entry must be a number!");
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
                    Console.WriteLine("CEO age must be between 0 and 40!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("The entry must be a number!");
                return false;
            }

        }
        public static bool ValidationRole(string x) 
        {
            if (x == "ceo" || x == "projectmanager" || x == "developer" || x == "designer" || x == "softwaretester")
            {

                return true;
            }
            else
            {
                Console.WriteLine("Non-existent role");
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
                Console.WriteLine("The entry must be a letter!");
                return false;
                
            }
            
        }
    }
}
