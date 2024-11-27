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
        protected ProjectManager projectmanager;
        public IStorage<ProjectManager> _storAGE = new EmployeeStorage<ProjectManager>();

        public EmployeeProjectManagerService(ProjectManager pROJECTMANAGER) : base(pROJECTMANAGER)
        {
            projectmanager = pROJECTMANAGER;
            
        }
        public override void AddEmployeesService() 
        {
            base.AddEmployeesService();

            Console.WriteLine("Enter project");
            string pmProject = Console.ReadLine();

            //var projectmanager = new ProjectManager(pmIdInt, pmfirstName, pmlastName, pmAge, pmProject);
            //base.AddEmployeesService(projectmanager);
            try
            {
                var newProjectManager = new ProjectManager(baseIdInt, basefirstName, baselastName, baseAgeInt, pmProject);
                _storAGE.AddEmployees(newProjectManager);
                Console.WriteLine("ProjectManager added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }
        }
    }
}
