using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Constants;

namespace Employee.Roles
{
    public class CEO : EmployeeBase
    {
        public int CeoYears { get; set; }

        
        public override string GetInfo() => $"{base.GetInfo()} CEOAge = {CeoYears}";

    }
}
