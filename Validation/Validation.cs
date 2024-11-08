using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Validation
{

    public class EmployeeValidation
    {
        public bool ValidationString(string input) 
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                Console.WriteLine("Unese ne može biti prazan!");
                return false;
            }
            return true;
        }
        public bool ValidationBoolean(string x)
        {
            bool pp;
            if (bool.TryParse(x, out pp))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Unos mora biti true ili false!");
                return false;
            }
        }
        public bool ValidationInt(string x)
        {
            int broj;
            if (int.TryParse(x, out broj))
            {
                if (broj >= 0)
                {
                    return true;
                }
                else 
                {
                    Console.WriteLine("Unos ne može biti negativan!");
                    return false;
                }
            }
            else 
            {
                Console.WriteLine("Unos mora biti broj!");
                return false;
            }
            
        }
    }
}
