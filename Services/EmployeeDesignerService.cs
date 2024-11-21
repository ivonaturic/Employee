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
    internal class EmployeeDesignerService : EmployeeBaseService<Designer>
    {
        private readonly IStorage<Designer> _storage;

        public EmployeeDesignerService(IStorage<Designer> storage) : base(storage) 
        {
            _storage = storage;
        }
        public void AddEmployeesDesignerService() 
        {
            Console.WriteLine("Unesi Id");
            string desStringId = Console.ReadLine();
            int desIntId = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ime: ");
            string desfirstName = Console.ReadLine();
            
            Console.WriteLine("Unesi prezime: ");
            string deslastName = Console.ReadLine();
            
            Console.WriteLine("Unesi broj godina: ");
            string desAgestring = Console.ReadLine();
            int desAge = int.Parse(desAgestring);

            Console.WriteLine("Unesi projekt: ");
            string desProject = Console.ReadLine();
            
            Console.WriteLine("Zna li crtati? true/false ");
            string descanDrawstring = Console.ReadLine();   
            bool descanDraw = bool.Parse(descanDrawstring);

            var designer = new Designer(desIntId, desfirstName, deslastName, desAge, desProject, descanDraw);
            base.AddEmployeesService(designer);
        }
    }
}
