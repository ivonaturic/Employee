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
                    return new EmployeeCEOService(new CEO(0, "Default", "Name", 0, 0));
                /*case "projectmanager":
                    return new EmployeeProjectManagerService(new ProjectManager());
                case "designer":
                    return new EmployeeDesignerService(new Designer());
                case "developer":
                    return new EmployeeDeveloperService(new Developer());
                case "softwaretester":
                    return new EmployeeSoftwareTesterService(new SoftwareTester());*/
                default:
                    throw new ArgumentException("Invalid role type", nameof(role));
            }
            throw new InvalidOperationException("Invalid opeation!");
        }
        
    }
}
