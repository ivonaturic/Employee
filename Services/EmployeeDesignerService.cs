using Employee.Constants;
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
        protected string inputCanDraw;
        protected Designer designer;
        public EmployeeDesignerService(Designer dESIGNER) : base(dESIGNER)
        {
            designer = dESIGNER;
        }
        public override void AddEmployeesService()
        {
            base.AddEmployeesService();
            if (!EXIT.Exit(base.inputId)) return;
            if (!EXIT.Exit(base.firstName)) return;
            if (!EXIT.Exit(base.lastName)) return;
            if (!EXIT.Exit(base.inputAge)) return;
            do
            {
                Console.WriteLine(ConstantsMessages.EnterProject);
                designer.Project = Console.ReadLine();
                if (!EXIT.Exit(designer.Project)) return;
            }
            while (!EmployeeValidation.ValidationString(designer.Project));

            do
            {
                Console.WriteLine("Can draw? true/false ");
                inputCanDraw = Console.ReadLine();
                if (!EXIT.Exit(inputCanDraw)) return;
            }
            while (!EmployeeValidation.ValidationBoolean(inputCanDraw));
            designer.CanDraw = bool.Parse(inputCanDraw);

            try
            {
                designer.Id = base.id;
                designer.FirstName = base.firstName;
                designer.LastName = base.lastName;
                designer.Age = base.age;
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
