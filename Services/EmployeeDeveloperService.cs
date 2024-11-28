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
    internal class EmployeeDeveloperService : EmployeeBaseService<Developer>
    {
        protected Developer developer;
        public EmployeeDeveloperService(Developer dEVELOPER) : base(dEVELOPER)
        {
            developer = dEVELOPER;
        }
        public override void AddEmployeesService() 
        {

            base.AddEmployeesService();

            Console.WriteLine("Enter project: ");
            developer.Project = Console.ReadLine();
           
            Console.WriteLine("Is student? true/false ");
            string isStudentstring = Console.ReadLine();
            developer.IsStudent = bool.Parse(isStudentstring);

            try
            {
                developer.Id = base.baseIdInt;
                developer.FirstName = base.basefirstName;
                developer.LastName = base.baselastName;
                developer.Age = base.baseAgeInt;
                EmployeeStorage.AddEmployees(developer);
                Console.WriteLine("Developer added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }


        }
    }
}
