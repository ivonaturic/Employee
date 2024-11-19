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
        /*public static IEmployeeBaseService<T> CreateRoleService<T>(string role) where T : EmployeeBase
        {
            switch (role.ToLower()) 
            {
                case "ceo":
                   return EmployeeCEOService();
                case "projectmanager":
                    return new EmployeeProjectManagerService();
                case "designer":
                    return new EmployeeDesignerService();
                case "developer":
                    return new EmployeeDeveloperService();
                case "softwaretester":
                    return new EmployeeSoftwareTesterService();
                default:
                    throw new ArgumentException("Invalid role type", nameof(role));
            }
        }*/
    }
}
