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

            switch (role.ToLower()) 
            {
                case ConstantsRoles.CEO:
                    return new CEOService(new CEO());
                case ConstantsRoles.PM:
                case ConstantsRoles.pm:
                    return new ProjectManagerService(new ProjectManager());
                case ConstantsRoles.DSNR:
                case ConstantsRoles.dsnr:
                    return new DesignerService(new Designer());
                case ConstantsRoles.DEV:
                case ConstantsRoles.dev:
                    return new DeveloperService(new Developer());
                case ConstantsRoles.ST:
                case ConstantsRoles.st:
                    return new SoftwareTesterService(new SoftwareTester());
                default:
                    break;
            }
            return null;
        }
        
    }
}
