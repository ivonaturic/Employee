using Employee.Common;
using Employee.Roles;
using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employee.Services
{
    public class Factory
    {
        public static IBaseService CreateRoleService(string role)
        {
            string abbreviatedRole = RoleHelper.GetRoleAbbreviation(role);
            if (abbreviatedRole == null)
            {
                return null;
            }
            switch (abbreviatedRole)
            {
                case ConstantsRoles.CEO:
                    return new CEOService(new CEO());
                case ConstantsRoles.PM:
                    return new ProjectManagerService(new ProjectManager());
                case ConstantsRoles.DSNR:
                    return new DesignerService(new Designer());
                case ConstantsRoles.DEV:
                    return new DeveloperService(new Developer());
                case ConstantsRoles.ST:
                    return new SoftwareTesterService(new SoftwareTester());
                default:
                    return null;
            }
        }
        
    }
}
