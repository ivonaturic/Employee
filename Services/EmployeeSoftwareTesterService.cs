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

        public EmployeeSoftwareTesterService(SoftwareTester sOFTWARETESTER) : base(sOFTWARETESTER)
        {
            softwaretester = sOFTWARETESTER;
        }

        public override void AddEmployeesService() 
        {
           
            base.AddEmployeesService();
            Console.WriteLine("Enter project: ");
            softwaretester.Project = Console.ReadLine();
              
            Console.WriteLine("Uses automated tests? true/false ");
            string stUsesAutomatedTestsstring = Console.ReadLine();
            softwaretester.UseAutomatedTests = bool.Parse(stUsesAutomatedTestsstring);

            try
            {
                softwaretester.Id = base.baseIdInt;
                softwaretester.FirstName = base.basefirstName;
                softwaretester.LastName = base.baselastName;
                softwaretester.Age = base.baseAgeInt;
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
