using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Constants;
using Employee.Roles;
using Employee.Storage;
using Employee.Validation;

namespace Employee.Services
{
    public class EmployeeCEOService : EmployeeBaseService<CEO>
    {
        protected string inputCeoYears;
        protected CEO ceo;
        public EmployeeCEOService(CEO cEO) : base(cEO) 
        {
            ceo = cEO;  
        }
        public override void AddEmployeesService() 
        {
            var checkCEO = EmployeeStorage.AllEmployees().OfType<CEO>().FirstOrDefault();
            if (checkCEO != null)
            {
                StandardMessages.CEOExist();
                return;
            }
            else
            {
                base.AddEmployeesService();
                if (!ConsoleValidation.Exit(base.inputId)) return;
                if (!ConsoleValidation.Exit(base.firstName)) return;
                if (!ConsoleValidation.Exit(base.lastName)) return;
                if (!ConsoleValidation.Exit(base.inputAge)) return;

                CommonDataCapture.EnterCeoData(out inputCeoYears);
                ceo.CeoYears = int.Parse(inputCeoYears);
                ceo.Id = base.id;
                ceo.FirstName = base.firstName;
                ceo.LastName = base.lastName;
                ceo.Age = base.age;
                EmployeeStorage.AddEmployees(ceo);
                StandardMessages.AddedSuccessfully();
            }
        }
    }
}
