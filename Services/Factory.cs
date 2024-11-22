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
        public static IEmployeeBaseService<T> CreateRoleService<T>(string role,IStorage<T> storage) where T : EmployeeBase
        {

            switch (role.ToLower()) 
            {
                case "ceo":
                    return new EmployeeCEOService((IStorage<CEO>) storage) as IEmployeeBaseService<T>;
                case "projectmanager":
                    return new EmployeeProjectManagerService((IStorage<ProjectManager>)storage) as IEmployeeBaseService<T>;
                case "designer":
                    return new EmployeeDesignerService((IStorage<Designer>)storage) as IEmployeeBaseService<T>;
                case "developer":
                    return new EmployeeDeveloperService((IStorage<Developer>)storage) as IEmployeeBaseService<T>;
                case "softwaretester":
                    return new EmployeeSoftwareTesterService((IStorage<SoftwareTester>)storage) as IEmployeeBaseService<T>;
                default:
                    throw new ArgumentException("Invalid role type", nameof(role));
            }
            throw new InvalidOperationException("Invalid opeation!");
        }
        
    }
}
