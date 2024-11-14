using Employee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Roles
{
    public class SoftwareTester : EmployeeCommon
    {
        public string Project { get; set; }
        public bool UseAutomatedTests { get; set; }

        public SoftwareTester(int id, string firstName, string lastName, int age, string project, bool useAutomatedTests) : base(id, firstName, lastName, age)
        {
            Project = project;
            UseAutomatedTests = useAutomatedTests;
        }
        public override string GetInfo() => $"{Id} {FirstName} {LastName} Age = {Age} Project = {Project} Use Automated Test = {UseAutomatedTests}";

    }
}
