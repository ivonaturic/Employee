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
    internal class SoftwareTesterService : BaseService<SoftwareTester>
    {
        protected string inputProject;
        protected string inputUseAutomatedTests;
        protected SoftwareTester softwaretester;

        public SoftwareTesterService(SoftwareTester sOFTWARETESTER) : base(sOFTWARETESTER)
        {
            softwaretester = sOFTWARETESTER;
        }
        public override void AddEmployeesService() 
        {
            base.AddEmployeesService();
            if (!ConsoleValidation.ExitBase(base.inputId, base.firstName, base.lastName, base.inputAge)) return;
            PropertiesDataCapture.EnterSoftwareTester(out inputProject, out inputUseAutomatedTests);
            if (!ConsoleValidation.Exit(inputProject)) return;
            if (!ConsoleValidation.Exit(inputUseAutomatedTests)) return;
            softwaretester.Id = base.id;
            softwaretester.FirstName = base.firstName;
            softwaretester.LastName = base.lastName;
            softwaretester.Age = base.age;
            softwaretester.Project = inputProject;
            softwaretester.UseAutomatedTests = bool.Parse(inputUseAutomatedTests);
            EmployeeStorage.AddEmployees(softwaretester);
            StandardMessages.AddedSuccessfully();
        }
    }
}
