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
            if (!EXIT.Exit(base.inputId)) return;
            if (!EXIT.Exit(base.firstName)) return;
            if (!EXIT.Exit(base.lastName)) return;
            if (!EXIT.Exit(base.inputAge)) return;
            do
            {
                Console.WriteLine(ConstantsMessages.EnterProject);
                softwaretester.Project = Console.ReadLine();
                if (!EXIT.Exit(softwaretester.Project)) return;
            }
            while (!EmployeeValidation.ValidationString(softwaretester.Project));

            do
            {
                Console.WriteLine("Uses automated tests? true/false ");
                inputUseAutomatedTests = Console.ReadLine();
                if (!EXIT.Exit(inputUseAutomatedTests)) return;
            }
            while (!EmployeeValidation.ValidationBoolean(inputUseAutomatedTests));
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
