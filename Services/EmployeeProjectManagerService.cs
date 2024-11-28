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
        public EmployeeProjectManagerService(ProjectManager pROJECTMANAGER) : base(pROJECTMANAGER)
        {
            projectmanager = pROJECTMANAGER;
            
        }
        public override void AddEmployeesService() 
        {
            base.AddEmployeesService();

            Console.WriteLine("Enter project");
            projectmanager.Project = Console.ReadLine();

            try
            {
                projectmanager.Id = base.baseIdInt;
                projectmanager.FirstName = base.basefirstName;
                projectmanager.LastName = base.baselastName;
                projectmanager.Age = base.baseAgeInt;
                EmployeeStorage.AddEmployees(projectmanager);
                Console.WriteLine("ProjectManager added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }
        }
    }
}
