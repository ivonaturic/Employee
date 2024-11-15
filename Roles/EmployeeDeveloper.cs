using Employee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Roles
{
    public class Developer : EmployeeBase
    {
        public string Project { get; set; }
        public bool IsStudent { get; set; }

        public Developer(int id, string firstName, string lastName, int age, string project, bool isStudent) : base(id, firstName, lastName, age)
        {
            Project = project;
            IsStudent = isStudent;
        }
        public override string GetInfo() => $"{Id} {FirstName} {LastName} Age = {Age} Project = {Project} IsStudent = {IsStudent}";
    }
}
