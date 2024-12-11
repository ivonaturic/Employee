using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;

namespace Employee.Roles
{
    public class CEO : BaseModel
    {
        public int CeoYears { get; set; }
        public override string GetInfo() => $"{base.GetInfo()} Years of CEO = {CeoYears}";

    }
}
