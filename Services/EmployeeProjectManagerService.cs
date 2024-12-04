using Employee.Constants;
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
            if (!ConsoleValidation.Exit(base.inputId)) return;
            if (!ConsoleValidation.Exit(base.firstName)) return;
            if (!ConsoleValidation.Exit(base.lastName)) return;
            if (!ConsoleValidation.Exit(base.inputAge)) return;
            do
            {
                Console.WriteLine(ConstantsMessages.EnterProject);
                projectmanager.Project = Console.ReadLine();
                if (!ConsoleValidation.Exit(projectmanager.Project)) return;
            } 
            while (!ConsoleValidation.ValidationString(projectmanager.Project));

            try
            {
                projectmanager.Id = base.id;
                projectmanager.FirstName = base.firstName;
                projectmanager.LastName = base.lastName;
                projectmanager.Age = base.age;
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
