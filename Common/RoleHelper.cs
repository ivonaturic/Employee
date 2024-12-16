using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Common
{
    public static class RoleHelper
    {
        private static readonly Dictionary<string, string> roleAbbreviations = new Dictionary<string, string>
        {
            { ConstantsRoles.CEO, ConstantsRoles.CEO },
            { ConstantsRoles.pm, ConstantsRoles.PM },
            { ConstantsRoles.dev, ConstantsRoles.DEV },
            { ConstantsRoles.dsnr, ConstantsRoles.DSNR },
            { ConstantsRoles.st, ConstantsRoles.ST },
            { ConstantsRoles.PM, ConstantsRoles.PM },
            { ConstantsRoles.DEV, ConstantsRoles.DEV },
            { ConstantsRoles.DSNR, ConstantsRoles.DSNR },
            { ConstantsRoles.ST, ConstantsRoles.ST },
        };
            public static string GetRoleAbbreviation(string role)
            {
                if (roleAbbreviations.ContainsKey(role))
                {
                    return roleAbbreviations[role];
                }
                return null;
            }
    }
}
