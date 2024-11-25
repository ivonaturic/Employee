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
        protected Designer designer;
        private readonly IStorage<Designer> _storage;

        public EmployeeDesignerService(Designer dESIGNER) : base(dESIGNER) 
        {
            designer = dESIGNER;
            _storage = new EmployeeStorage<Designer>();
        }
        public virtual void AddEmployeesService() 
        {
            

            Console.WriteLine("Enter project: ");
            string desProject = Console.ReadLine();
            
            Console.WriteLine("Can draw? true/false ");
            string descanDrawstring = Console.ReadLine();   
            bool descanDraw = bool.Parse(descanDrawstring);

            
            
        }
    }
}
