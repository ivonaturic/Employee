using Employee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Roles
{
    public class Designer : EmployeeBase
    {
        public string Project { get; set; }
        public bool CanDraw { get; set; }

        public Designer(int id, string firstName, string lastName, int age, string project, bool canDraw) : base(id, firstName, lastName, age)
        {
            Project = project;
            CanDraw = canDraw;
        }
        public override string GetInfo() => $"Id = {Id} {FirstName} {LastName} Age = {Age} Project = {Project} CanDraw = {CanDraw}";
    }
}
