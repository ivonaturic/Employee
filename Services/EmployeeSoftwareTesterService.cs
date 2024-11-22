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

        public virtual void AddEmployeesService() 
        {
           

            Console.WriteLine("Enter project: ");
            string stProject = Console.ReadLine();
              
            Console.WriteLine("Uses automated tests? true/false ");
            string stUsesAutomatedTestsstring = Console.ReadLine();
            bool stUsesAutomatedTests = bool.Parse(stUsesAutomatedTestsstring);
             
            //var softwaretester = new SoftwareTester(stIdInt, stfirstName, stlastName, stAge, stProject, stUsesAutomatedTests);
            //base.AddEmployeesService(softwaretester);
            
        }
        
    }
}
