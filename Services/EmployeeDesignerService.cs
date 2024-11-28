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

        public EmployeeDesignerService(Designer dESIGNER) : base(dESIGNER)
        {
            designer = dESIGNER;
        }
        public override void AddEmployeesService() 
        {

            base.AddEmployeesService();
            Console.WriteLine("Enter project: ");
            designer.Project = Console.ReadLine();
            
            Console.WriteLine("Can draw? true/false ");
            string descanDrawstring = Console.ReadLine();   
            designer.CanDraw = bool.Parse(descanDrawstring);

            try
            {
                designer.Id = base.baseIdInt;
                designer.FirstName = base.basefirstName;
                designer.LastName = base.baselastName;
                designer.Age = base.baseAgeInt;
                EmployeeStorage.AddEmployees(designer);
                Console.WriteLine("Designer added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding CEO: {ex.Message}");
            }

        }
    }
}
