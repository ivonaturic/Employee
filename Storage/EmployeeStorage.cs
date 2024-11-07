using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Roles;

namespace Employee.Storage
{
    public class EmployeeStorage
    {
        private List<EmployeeCommon> employeelist = new List<EmployeeCommon>() 
        {
            new CEO("Ivona","Turić",25,0),
            new ProjectManager("Ivan","Zeko",28,"projekt"),
            new ProjectManager("Martina","Peric",32,"projekt2"),
            new Developer("Petar","Perica",44,"project",false),
            new SoftwareTester("Karla","Kartalic",44,"projekt2",true)
        };


        public void AddEmployees(EmployeeCommon employee) 
        {
            employeelist.Add(employee);
        }

        public void RemoveEmployees(EmployeeCommon employee)
        {
            employeelist.Remove(employee);
        }

        public IEnumerable<EmployeeCommon> AllEmployees() 
        {
            return employeelist;
        }
    }
}
