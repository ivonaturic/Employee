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
        public IStorage<Developer> _storaGE = new EmployeeStorage<Developer>();

        public EmployeeDeveloperService(Developer dEVELOPER) : base(dEVELOPER)
        {
            developer = dEVELOPER;
        }
        public virtual void AddEmployeesService() 
        {

            base.AddEmployeesService();

            Console.WriteLine("Enter project: ");
            string devProject = Console.ReadLine();
           
            Console.WriteLine("Is student? true/false ");
            string isStudentstring = Console.ReadLine();
            bool isStudent = bool.Parse(isStudentstring);

            //var developer = new Developer(devIdInt, devfirstName, devlastName, devAge, devProject, isStudent);
            //base.AddEmployeesService(developer);
            try
            {
                var newDeveloper = new Developer(baseIdInt, basefirstName, baselastName, baseAgeInt, devProject, isStudent);
                _storaGE.AddEmployees(newDeveloper);
                Console.WriteLine("Developer added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }


        }
    }
}
