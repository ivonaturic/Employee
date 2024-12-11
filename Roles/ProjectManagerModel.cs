using Employee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Roles
{ 
    public class ProjectManager : BaseModel
    {
        public string Project { get; set; }
        public override string GetInfo() => $"{base.GetInfo()} Project = {Project}";
    } 
}
