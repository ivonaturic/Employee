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
                Console.WriteLine("CEO already exists, there can only be one!");
                return;
            }
            else
            {
                base.AddEmployeesService();
                if (!EXIT.Exit(base.inputId)) return;
                if (!EXIT.Exit(base.firstName)) return;
                if (!EXIT.Exit(base.lastName)) return;
                if (!EXIT.Exit(base.inputAge)) return;
                do
                {
                    Console.WriteLine("Years of CEO: ");
                    inputCeoYears = Console.ReadLine();
                    if (!EXIT.Exit(inputCeoYears)) return;
                } 
                while (!EmployeeValidation.ValidationCEOAge(inputCeoYears));
                ceo.CeoYears = int.Parse(inputCeoYears);
            }
            try
            {
                ceo.Id = base.id;
                ceo.FirstName = base.firstName;
                ceo.LastName = base.lastName;
                ceo.Age = base.age;
                EmployeeStorage.AddEmployees(ceo);
                Console.WriteLine("CEO added successfully!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }
        }

    }
}
