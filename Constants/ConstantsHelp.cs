using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Constants
{
    internal class ConstantsHelp
    {
        public const string HELP = "Add is for adding new employee including CEO. There can only be one CEO! \n" +
                                   "Remove is used for remove employee by ID. CEO can be removed with this method!\n" +
                                   "Display shows a list of all employes including CEO!\n" + 
                                   "List shows a list of all employees without CEO\n" + 
                                   "RoleList shows employees by role!\n";
    }
}
