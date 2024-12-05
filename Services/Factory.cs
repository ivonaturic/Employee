using Employee.Constants;
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
        public static IEmployeeBaseService CreateRoleService(string role)
        {

            switch (role.ToLower()) 
            {
                case "ceo":
                    return new EmployeeCEOService(new CEO());
                case "projectmanager":
                    return new EmployeeProjectManagerService(new ProjectManager());
                case "designer":
                    return new EmployeeDesignerService(new Designer());
                case "developer":
                    return new EmployeeDeveloperService(new Developer());
                case "softwaretester":
                    return new EmployeeSoftwareTesterService(new SoftwareTester());
                default:
                    break;
            }
            StandardMessages.NonExistentRole();
            return null;
        }
        
    }
}
