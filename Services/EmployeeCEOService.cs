using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Roles;
using Employee.Storage;

namespace Employee.Services
{
    public class EmployeeCEOService : EmployeeBaseService<CEO>
    {
        protected int YearsAsCEO { get; set; }
        protected CEO ceo;
        private readonly IStorage<CEO> _storage;

        public EmployeeCEOService(CEO cEO) : base(cEO) 
        {
            ceo = cEO;
            _storage = new EmployeeStorage<CEO>();
        }
        public override void AddEmployeesService() 
        {
            base.AddEmployeesService();
            Console.WriteLine("Years of CEO: ");
            string ceoYearsstring = Console.ReadLine();
            int ceoYears = int.Parse(ceoYearsstring);
            var ceo = _storage.AllEmployees().Where(e => e.GetType().Name == "CEO");
            if (ceo.Any())
            {
                Console.WriteLine("CEO already exists, there can only be one!");
                return;
            }

            try
            {
                _storage.AddEmployees(new CEO(baseIdInt,basefirstName,baselastName,baseAgeInt,ceoYears));
                Console.WriteLine("CEO added successfully!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }
        }

    }
}
