using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Roles;
using Employee.Storage;
using Employee.Validation;

namespace Employee.Services
{
    public class CEOService : BaseService<CEO>
    {
        protected string inputCeoYears;
        protected CEO ceo;
        public CEOService(CEO cEO) : base(cEO) 
        {
            ceo = cEO;  
        }
        public override void AddEmployeeService() 
        {
            var checkCEO = EmployeeStorage.AllEmployees().OfType<CEO>().FirstOrDefault();
            if (checkCEO != null)
            {
                Console.WriteLine(StaticMessages.CEOExistenceMessage);
                return;
            }
            else
            {
                base.AddEmployeeService();
                if(!ConsoleValidation.ExitBase(base.inputId, base.firstName, base.lastName, base.inputAge)) return;
                PropertiesDataCapture.InputCeoData(out inputCeoYears);
                if (!ConsoleValidation.Exit(inputCeoYears)) return;
                ceo.Id = base.id;
                ceo.FirstName = base.firstName;
                ceo.LastName = base.lastName;
                ceo.Age = base.age;
                ceo.CeoYears = int.Parse(inputCeoYears);
                EmployeeStorage.AddEmployee(ceo);
                DynamicMessages.EmployeeAddedSuccessfully(typeof(CEO));
            }
        }
    }
}
