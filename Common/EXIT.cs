using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Common
{
    public static class EXIT
    {
        public static void Exit(string entry)
        {
            if (entry == "exit")
            {
                Console.WriteLine("Prekid unosa!");
                return;
            }
        }
    }
}
