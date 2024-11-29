using Employee.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Roles
{
    public class SoftwareTester : EmployeeBase
    {
        public string Project { get; set; }
        public bool UseAutomatedTests { get; set; }

        public override string GetInfo() => $"{base.GetInfo()} Project = {Project} Use Automated Test = {UseAutomatedTests}";

    }
}
