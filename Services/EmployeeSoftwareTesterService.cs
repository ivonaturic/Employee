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
    internal class EmployeeSoftwareTesterService : EmployeeBaseService<SoftwareTester>
    {
        protected string inputUseAutomatedTests;
        protected SoftwareTester softwaretester;

        public EmployeeSoftwareTesterService(SoftwareTester sOFTWARETESTER) : base(sOFTWARETESTER)
        {
            softwaretester = sOFTWARETESTER;
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
                softwaretester.Project = Console.ReadLine();
                if (!ConsoleValidation.Exit(softwaretester.Project)) return;
            }
            while (!ConsoleValidation.ValidationString(softwaretester.Project));

            do
            {
                Console.WriteLine("Uses automated tests? true/false ");
                inputUseAutomatedTests = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputUseAutomatedTests)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputUseAutomatedTests));
            softwaretester.UseAutomatedTests = bool.Parse(inputUseAutomatedTests);

            try
            {
                softwaretester.Id = base.id;
                softwaretester.FirstName = base.firstName;
                softwaretester.LastName = base.lastName;
                softwaretester.Age = base.age;
                EmployeeStorage.AddEmployees(softwaretester);
                Console.WriteLine("Developer added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }

        }
        
    }
}
