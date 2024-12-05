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
                PropertiesDataMessages.InputProject();
                softwaretester.Project = Console.ReadLine();
                if (!ConsoleValidation.Exit(softwaretester.Project)) return;
            }
            while (!ConsoleValidation.ValidationString(softwaretester.Project));
            do
            {
                PropertiesDataMessages.InputUseAutomatedTests();
                inputUseAutomatedTests = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputUseAutomatedTests)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputUseAutomatedTests));
            softwaretester.UseAutomatedTests = bool.Parse(inputUseAutomatedTests);
            softwaretester.Id = base.id;
            softwaretester.FirstName = base.firstName;
            softwaretester.LastName = base.lastName;
            softwaretester.Age = base.age;
            EmployeeStorage.AddEmployees(softwaretester);
            StandardMessages.AddedSuccessfully();
        }
    }
}
