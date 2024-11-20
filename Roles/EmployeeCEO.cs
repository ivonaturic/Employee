using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;

namespace Employee.Roles
{
    public class CEO : EmployeeBase
    {
        public int CeoYears { get; set; }

        public CEO(int id, string firstName, string lastName, int age, int ceoYears) : base(id, firstName, lastName, age)
        {
            CeoYears = ceoYears;
        }
        public override string GetInfo() => $"{base.GetInfo()} CEOAge = {CeoYears}";

    }
}
