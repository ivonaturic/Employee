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
        protected SoftwareTester softwaretester;
        public IStorage<SoftwareTester> _storageee = new EmployeeStorage<SoftwareTester>();

        public EmployeeSoftwareTesterService(SoftwareTester sOFTWARETESTER) : base(sOFTWARETESTER)
        {
            softwaretester = sOFTWARETESTER;
        }

        public override void AddEmployeesService() 
        {
           
            base.AddEmployeesService();
            Console.WriteLine("Enter project: ");
            string stProject = Console.ReadLine();
              
            Console.WriteLine("Uses automated tests? true/false ");
            string stUsesAutomatedTestsstring = Console.ReadLine();
            bool stUsesAutomatedTests = bool.Parse(stUsesAutomatedTestsstring);

            //var softwaretester = new SoftwareTester(stIdInt, stfirstName, stlastName, stAge, stProject, stUsesAutomatedTests);
            //base.AddEmployeesService(softwaretester);
            try
            {
                var newSoftwareTester = new SoftwareTester(baseIdInt, basefirstName, baselastName, baseAgeInt, stProject, stUsesAutomatedTests);
                _storageee.AddEmployees(newSoftwareTester);
                Console.WriteLine("Developer added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }

        }
        
    }
}
