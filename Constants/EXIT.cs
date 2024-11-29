using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Constants
{
    public static class EXIT
    {
        public static bool Exit(string entry)
        {
            if (entry.ToLower() == "exit")
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
