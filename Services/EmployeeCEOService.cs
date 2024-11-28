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
        protected CEO ceo;

        public EmployeeCEOService(CEO cEO) : base(cEO) 
        {
            ceo = cEO;  
        }
        public override void AddEmployeesService() 
        {
            var ceoo = EmployeeStorage.AllEmployees().OfType<CEO>().FirstOrDefault();
            if (ceoo != null)
            {
                Console.WriteLine("CEO already exists, there can only be one!");
                return;
            }
            else
            {
                base.AddEmployeesService();
                Console.WriteLine("Years of CEO: ");
                string ceoYearsstring = Console.ReadLine();
                ceo.CeoYears = int.Parse(ceoYearsstring);
            }

            try
            {
                ceo.Id = base.baseIdInt;
                ceo.FirstName = base.basefirstName;
                ceo.LastName = base.baselastName;
                ceo.Age = base.baseAgeInt;
                EmployeeStorage.AddEmployees(ceo);
                Console.WriteLine("CEO added successfully!");
                
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }
        }

    }
}
