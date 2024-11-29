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
            if (!EXIT.Exit(base.inputId)) return;
            if (!EXIT.Exit(base.firstName)) return;
            if (!EXIT.Exit(base.lastName)) return;
            if (!EXIT.Exit(base.inputAge)) return;
            do
            {
                Console.WriteLine(ConstantsMessages.EnterProject);
                developer.Project = Console.ReadLine();
                if (!EXIT.Exit(developer.Project)) return;
            }
            while (!EmployeeValidation.ValidationString(developer.Project));

            do
            {
                Console.WriteLine("Is student? true/false ");
                inputIsStudent = Console.ReadLine();
                if (!EXIT.Exit(inputIsStudent)) return;
            }
            while (!EmployeeValidation.ValidationBoolean(inputIsStudent));
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
