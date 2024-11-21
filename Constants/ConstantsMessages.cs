using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Constants
{
    public static class ConstantsMessages
    {
        public const string PossibleCommands = "Possible commands: Help, Add, Remove, Display, List, RoleList";
        public const string PossibleRoles = "Possible roles: CEO, ProjectManager, Developer, Designer, SoftwareTester";

        public const string NonExistentCommand = "Non-existent command!";
        public const string ListWithoutCEO = "List without CEO!";
    }
}
