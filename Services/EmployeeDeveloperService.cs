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
        private readonly IStorage<Developer> _storage;

        public EmployeeDeveloperService(Developer dEVELOPER) : base(dEVELOPER)
        {
            developer = dEVELOPER;
            _storage = new EmployeeStorage<Developer>();
        }
        public virtual void AddEmployeesService() 
        {

            

            Console.WriteLine("Enter project: ");
            string devProject = Console.ReadLine();
           
            Console.WriteLine("Is student? true/false ");
            string isStudentstring = Console.ReadLine();
            bool isStudent = bool.Parse(isStudentstring);

            //var developer = new Developer(devIdInt, devfirstName, devlastName, devAge, devProject, isStudent);
            //base.AddEmployeesService(developer);

            

        }
    }
}
