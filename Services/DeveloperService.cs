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
    internal class DeveloperService : BaseService<Developer>
    {
        protected string inputProject;
        protected string inputIsStudent;
        protected Developer developer;
        public DeveloperService(Developer dEVELOPER) : base(dEVELOPER)
        {
            developer = dEVELOPER;
        }
        public override void AddEmployeesService() 
        {
            base.AddEmployeesService();
            if (!ConsoleValidation.ExitBase(base.inputId, base.firstName, base.lastName, base.inputAge)) return;
            PropertiesDataCapture.EnterDeveloperData(out inputProject,out inputIsStudent);
            if (!ConsoleValidation.Exit(inputProject)) return;
            if (!ConsoleValidation.Exit(inputIsStudent)) return;
            developer.Id = base.id;
            developer.FirstName = base.firstName;
            developer.LastName = base.lastName;
            developer.Age = base.age;
            developer.Project = inputProject;
            developer.IsStudent = bool.Parse(inputIsStudent);
            EmployeeStorage.AddEmployees(developer);
            StandardMessages.AddedSuccessfully();
        }
    }
}
