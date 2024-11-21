using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Roles;
using Employee.Storage;

namespace Employee.Services
{
    public class EmployeeCEOService : EmployeeBaseService<CEO>
    {
        private readonly IStorage<CEO> _storage;

        public EmployeeCEOService(IStorage<CEO> storage) : base(storage) 
        {
            _storage = storage;
        }
        /*public override void AddEmployeesService(CEO entity)
        {
            var ceo = _storage.AllEmployees().Where(e => e.GetType().Name == "CEO");
            if (ceo.Any())
            {
                Console.WriteLine("CEO already exists, there can only be one!");
                return;
            }
            else
            {
                base.AddEmployeesService(entity);
            }
        }*/
        public void AddEmployeesCEOService() 
        {
            var ceo = _storage.AllEmployees().Where(e => e.GetType().Name == "CEO");
            if (ceo.Any())
            {
                Console.WriteLine("CEO already exists, there can only be one!");
                return;
            }
            else
            {
                Console.WriteLine("New CEO entry: ");
                Console.WriteLine("Id: ");
                string stringId = Console.ReadLine();
                int intId= int.Parse(stringId);
                Console.WriteLine("First name: ");
                string ceofirstName = Console.ReadLine();
                Console.WriteLine("Last name: ");
                string ceolastName = Console.ReadLine();
                Console.WriteLine("Age: ");
                string ceoagestring = Console.ReadLine();
                int ceoAge = int.Parse(ceoagestring);
                Console.WriteLine("Years of CEO: ");
                string ceoYearsstring = Console.ReadLine();
                int ceoYears = int.Parse(ceoYearsstring);

                var ceoobject = new CEO(intId, ceofirstName, ceolastName, ceoAge, ceoYears);
                base.AddEmployeesService(ceoobject);
            }
        }

    }
}
