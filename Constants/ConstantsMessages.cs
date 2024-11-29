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
        public const string ListAllEmployees = "List of all employees: ";
        public const string ListWithoutCEO = "List without CEO: ";

        public const string InputId = "Input ID: ";
        public const string EnterProject = "Enter project: ";

        public const string NonExistentEmployee ="The employee does not exist.";
        public const string NoEnteredEmployee = "No employees entered!";

    }
}
