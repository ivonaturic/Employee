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
    internal class EmployeeDeveloperService : EmployeeBaseService<Developer>
    {
        protected string inputIsStudent;
        protected Developer developer;
        public EmployeeDeveloperService(Developer dEVELOPER) : base(dEVELOPER)
        {
            developer = dEVELOPER;
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
                PropertiesDataMessages.InputProject();
                developer.Project = Console.ReadLine();
                if (!ConsoleValidation.Exit(developer.Project)) return;
            }
            while (!ConsoleValidation.ValidationString(developer.Project));
            do
            {
                PropertiesDataMessages.InputIsStudent();
                inputIsStudent = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputIsStudent)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputIsStudent));
            developer.IsStudent = bool.Parse(inputIsStudent);
            developer.Id = base.id;
            developer.FirstName = base.firstName;
            developer.LastName = base.lastName;
            developer.Age = base.age;
            EmployeeStorage.AddEmployees(developer);
            StandardMessages.AddedSuccessfully();
        }
    }
}
