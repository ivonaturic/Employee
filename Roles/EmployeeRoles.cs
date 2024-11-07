using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;

namespace Employee.Roles
{
    public class CEO : EmployeeCommon
    {
        public int CeoYears { get; set; }

        public CEO(string firstName, string lastName, int age, int ceoYears) : base(firstName, lastName, age)
        {
            CeoYears = ceoYears;
        }
        public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} CEO = {CeoYears}";

    }
    public class ProjectManager : EmployeeCommon
    {
        public string Project { get; set; }

        public ProjectManager(string firstName, string lastName, int age, string project) : base(firstName, lastName, age)
        {
            Project = project;
        }
        public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project}";
    }

    public class Developer : EmployeeCommon
    {
        public string Project { get; set; }
        public bool IsStudent { get; set; }

        public Developer(string firstName, string lastName, int age, string project, bool isStudent) : base(firstName, lastName, age)
        {
            Project = project;
            IsStudent = isStudent;
        }
        public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project} Student = {IsStudent}";
    }

    public class Designer : EmployeeCommon
    {
        public string Project { get; set; }
        public bool CanDraw { get; set; }

        public Designer(string firstName, string lastName, int age, string project, bool canDraw) : base(firstName, lastName, age)
        {
            Project = project;
            CanDraw = canDraw;
        }
        public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project} Crtanje = {CanDraw}";
    }

    public class SoftwareTester : EmployeeCommon
    {
        public string Project { get; set; }
        public bool UseAutomatedTests { get; set; }

        public SoftwareTester(string firstName, string lastName, int age, string project, bool useAutomatedTests) : base(firstName, lastName, age)
        {
            Project = project;
            UseAutomatedTests = useAutomatedTests;
        }
        public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project} Automatizirani test = {UseAutomatedTests}";

    }
}
