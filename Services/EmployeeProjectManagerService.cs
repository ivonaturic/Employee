using Employee.Roles;
using Employee.Storage;
using Employee.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    internal class EmployeeProjectManagerService : EmployeeBaseService<ProjectManager>
    {
        private readonly IStorage<ProjectManager> _storage;

        public EmployeeProjectManagerService(IStorage<ProjectManager> storage) : base(storage)
        {
            _storage = storage;
        }
        public virtual void AddEmployeesService() 
        {
            

            Console.WriteLine("Enter project");
            string pmProject = Console.ReadLine();
            
            //var projectmanager = new ProjectManager(pmIdInt, pmfirstName, pmlastName, pmAge, pmProject);
            //base.AddEmployeesService(projectmanager);
        }
    }
}
