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
        private List<IEmployeeBase> employeelist = new List<IEmployeeBase>();
        /*{
            new CEO("Matija","Milic",55,10),
            new ProjectManager("Ivan","Zeko",28,"projekt"),
            new ProjectManager("Martina","Peric",32,"projekt2"),
            new Developer("Petar","Perica",44,"project",false),
            new SoftwareTester("Karla","Kartalic",44,"projekt2",true)
        };*/


        private void AddEmployees(IEmployeeBase employee) 
        {
            employeelist.Add(employee);
            
        }

        private void RemoveEmployees(IEmployeeBase employee)
        {
            employeelist.Remove(employee);
        }

        private IEnumerable<IEmployeeBase> AllEmployees() 
        {
            return employeelist;
        }
    }
}
