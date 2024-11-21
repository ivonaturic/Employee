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
        public static IEmployeeBaseService<T> CreateRoleService<T>(string role) where T : EmployeeBase
        {
            IStorage<T> storage;
            switch (role.ToLower()) 
            {
                case "ceo":
                    storage = new EmployeeStorage<CEO>() as IStorage<T>;
                    return new EmployeeCEOService(storage as IStorage<CEO>) as IEmployeeBaseService<T>;
                case "projectmanager":
                    storage = new EmployeeStorage<ProjectManager>() as IStorage<T>;
                    return new EmployeeProjectManagerService(storage as IStorage<ProjectManager>) as IEmployeeBaseService<T>;
                case "designer":
                    storage = new EmployeeStorage<Designer>() as IStorage<T>;
                    return new EmployeeDesignerService(storage as IStorage<Designer>) as IEmployeeBaseService<T>;
                case "developer":
                    storage = new EmployeeStorage<Developer>() as IStorage<T>;
                    return new EmployeeDeveloperService(storage as IStorage<Developer>) as IEmployeeBaseService<T>;
                case "softwaretester":
                    storage = new EmployeeStorage<SoftwareTester>() as IStorage<T>;
                    return new EmployeeSoftwareTesterService(storage as IStorage<SoftwareTester>) as IEmployeeBaseService<T>;
                default:
                    throw new ArgumentException("Invalid role type", nameof(role));
            }
            throw new InvalidOperationException("Invalid");
        }
        
    }
}
