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
        private readonly IStorage<Developer> _storage;

        public EmployeeDeveloperService(IStorage<Developer> storage) : base(storage)
        {
            _storage = storage;
        }
        public void AddEmployeesDeveloperService() 
        {

            Console.WriteLine("Unesi id: ");
            string devIdString= Console.ReadLine();
            int devIdInt = int.Parse(devIdString);

            Console.WriteLine("Unesi ime: ");
            string devfirstName = Console.ReadLine();
            
            Console.WriteLine("Unesi prezime: ");
            string devlastName = Console.ReadLine();
            
            Console.WriteLine("Unesi broj godina: ");
            string devAgestring = Console.ReadLine();
            int devAge = int.Parse(devAgestring);

            Console.WriteLine("Unesi projekt: ");
            string devProject = Console.ReadLine();
           
            Console.WriteLine("Je li student? true/false ");
            string isStudentstring = Console.ReadLine();
            bool isStudent = bool.Parse(isStudentstring);

            var developer = new Developer(devIdInt, devfirstName, devlastName, devAge, devProject, isStudent);
            base.AddEmployeesService(developer);

            

        }
    }
}
