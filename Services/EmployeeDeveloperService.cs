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
                Console.WriteLine(ConstantsMessages.EnterProject);
                developer.Project = Console.ReadLine();
                if (!ConsoleValidation.Exit(developer.Project)) return;
            }
            while (!ConsoleValidation.ValidationString(developer.Project));

            do
            {
                Console.WriteLine("Is student? true/false ");
                inputIsStudent = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputIsStudent)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputIsStudent));
            developer.IsStudent = bool.Parse(inputIsStudent);

            try
            {
                developer.Id = base.id;
                developer.FirstName = base.firstName;
                developer.LastName = base.lastName;
                developer.Age = base.age;
                EmployeeStorage.AddEmployees(developer);
                Console.WriteLine("Developer added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }


        }
    }
}
