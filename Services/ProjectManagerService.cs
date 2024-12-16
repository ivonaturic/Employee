using Employee.Common;
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
    internal class ProjectManagerService : BaseService<ProjectManager>
    {
        protected string inputProject;
        protected ProjectManager projectmanager;
        public ProjectManagerService(ProjectManager pROJECTMANAGER) : base(pROJECTMANAGER)
        {
            projectmanager = pROJECTMANAGER;
            
        }
        public override void AddEmployeeService() 
        {
            base.AddEmployeeService();
            if(!ConsoleValidation.ExitBase(base.inputId, base.firstName, base.lastName, base.inputAge)) return;
            PropertiesDataCapture.InputProjectManagerData(out inputProject);
            if (!ConsoleValidation.Exit(inputProject)) return;
            projectmanager.Id = base.id;
            projectmanager.FirstName = base.firstName;
            projectmanager.LastName = base.lastName;
            projectmanager.Age = base.age;
            projectmanager.Project = inputProject;
            EmployeeStorage.AddEmployee(projectmanager);
            DynamicMessages.EmployeeAddedSuccessfully(typeof(ProjectManager));
        }
    }
}
