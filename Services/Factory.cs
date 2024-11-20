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
        public static IEmployeeBaseService<T> CreateRoleService<T>(string role, IStorage<T> storage) where T : EmployeeBase
        {
            switch (role.ToLower()) 
            {
                case "ceo":
                   if(typeof(T) == typeof(CEO)) return (IEmployeeBaseService<T>)new EmployeeCEOService(storage as IStorage<CEO>);
                    break;
                case "projectmanager":
                    if(typeof(T) == typeof(ProjectManager))return (IEmployeeBaseService<T>)new EmployeeProjectManagerService(storage as IStorage<ProjectManager>);
                    break;
                case "designer":
                   if(typeof(T) == typeof(Designer)) return (IEmployeeBaseService<T>)new EmployeeDesignerService(storage as IStorage<Designer>);
                    break;
                case "developer":
                    if(typeof(T) == typeof(Developer)) return (IEmployeeBaseService<T>)new EmployeeDeveloperService(storage as IStorage<Developer>);
                    break;
                case "softwaretester":
                    if(typeof(T) == typeof(SoftwareTester))return (IEmployeeBaseService<T>)new EmployeeSoftwareTesterService(storage as IStorage<SoftwareTester>);
                    break;
                default:
                    throw new ArgumentException("Invalid role type", nameof(role));
            }
            throw new InvalidOperationException("Invalid");
        }
    }
}
