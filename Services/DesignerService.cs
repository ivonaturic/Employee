using Employee.Common;
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
    internal class DesignerService : BaseService<Designer>
    {
        protected string inputProject;
        protected string inputCanDraw;
        protected Designer designer;
        public DesignerService(Designer dESIGNER) : base(dESIGNER)
        {
            designer = dESIGNER;
        }
        public override void AddEmployeeService()
        {
            base.AddEmployeeService();
            if(!ConsoleValidation.ExitBase(base.inputId, base.firstName, base.lastName, base.inputAge)) return;
            PropertiesDataCapture.InputDesignerData(out inputProject, out inputCanDraw);
            if (!ConsoleValidation.Exit(inputProject)) return;
            if (!ConsoleValidation.Exit(inputCanDraw)) return;
            designer.Id = base.id;
            designer.FirstName = base.firstName;
            designer.LastName = base.lastName;
            designer.Age = base.age;
            designer.Project = inputProject;
            designer.CanDraw = bool.Parse(inputCanDraw);
            EmployeeStorage.AddEmployee(designer);
            DynamicMessages.EmployeeAddedSuccessfully(typeof(Designer));
        }
    }
}
