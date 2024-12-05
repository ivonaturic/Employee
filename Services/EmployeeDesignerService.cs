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
            if (!ConsoleValidation.Exit(base.inputId)) return;
            if (!ConsoleValidation.Exit(base.firstName)) return;
            if (!ConsoleValidation.Exit(base.lastName)) return;
            if (!ConsoleValidation.Exit(base.inputAge)) return;
            do
            {
                PropertiesDataMessages.InputProject();
                designer.Project = Console.ReadLine();
                if (!ConsoleValidation.Exit(designer.Project)) return;
            }
            while (!ConsoleValidation.ValidationString(designer.Project));
            /*do
            {
                PropertiesDataMessages.InputCanDraw();
                inputCanDraw = Console.ReadLine();
                if (!ConsoleValidation.Exit(inputCanDraw)) return;
            }
            while (!ConsoleValidation.ValidationBoolean(inputCanDraw));*/
            CommonDataCapture.EnterDesignerData(out inputCanDraw);
            designer.CanDraw = bool.Parse(inputCanDraw);
            designer.Id = base.id;
            designer.FirstName = base.firstName;
            designer.LastName = base.lastName;
            designer.Age = base.age;
            EmployeeStorage.AddEmployees(designer);
            StandardMessages.AddedSuccessfully();
        }
    }
}
