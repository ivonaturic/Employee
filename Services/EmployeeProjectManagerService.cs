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
    internal class EmployeeProjectManagerService : EmployeeBaseService<ProjectManager>
    {
        private readonly IStorage<ProjectManager> _storage;

        public EmployeeProjectManagerService(IStorage<ProjectManager> storage) : base(storage)
        {
            _storage = storage;
        }
        public void AddEmployeesProjectManagerService() 
        {
            Console.WriteLine("Unesi id: ");
            string pmIdString = Console.ReadLine();
            int pmIdInt = int.Parse(pmIdString);

            Console.WriteLine("Unesi ime: ");
            string pmfirstName = Console.ReadLine();
       
            Console.WriteLine("Unesi prezime: ");
            string pmlastName = Console.ReadLine();
               
            Console.WriteLine("Unesi broj godina: ");
            string pmAgestring = Console.ReadLine();
            int pmAge = int.Parse(pmAgestring);

            Console.WriteLine("Unesi projekt");
            string pmProject = Console.ReadLine();
            
            var projectmanager = new ProjectManager(pmIdInt, pmfirstName, pmlastName, pmAge, pmProject);
            base.AddEmployeesService(projectmanager);
        }
    }
}
