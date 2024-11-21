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
        private readonly IStorage<SoftwareTester> _storage;

        public EmployeeSoftwareTesterService(IStorage<SoftwareTester> storage) : base(storage)
        {
            _storage = storage;
        }

        public void AddEmployeesSoftwareTester() 
        {
            Console.WriteLine("Unesi id: ");
            string stIdString = Console.ReadLine();
            int stIdInt = int.Parse(stIdString);

            Console.WriteLine("Unesi ime: ");
            string stfirstName = Console.ReadLine();

            Console.WriteLine("Unesi prezime: ");
            string stlastName = Console.ReadLine();
             
            Console.WriteLine("Unesi broj godina: ");
            string stAgestring = Console.ReadLine();
            int stAge = int.Parse(stAgestring);

            Console.WriteLine("Unesi projekt: ");
            string stProject = Console.ReadLine();
              
            Console.WriteLine("Zna li crtati? true/false ");
            string stUsesAutomatedTestsstring = Console.ReadLine();
            bool stUsesAutomatedTests = bool.Parse(stUsesAutomatedTestsstring);
             
            var softwaretester = new SoftwareTester(stIdInt, stfirstName, stlastName, stAge, stProject, stUsesAutomatedTests);
            base.AddEmployeesService(softwaretester);
            
        }
        
    }
}
