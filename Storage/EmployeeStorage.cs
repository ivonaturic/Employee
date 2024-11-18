using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Roles;

namespace Employee.Storage
{
    public class EmployeeStorage<T> : IStorage<T> 
    {
        private readonly List<T> employeelist = new List<T>();
        /*{
            new CEO("Matija","Milic",55,10),
            new ProjectManager("Ivan","Zeko",28,"projekt"),
            new ProjectManager("Martina","Peric",32,"projekt2"),
            new Developer("Petar","Perica",44,"project",false),
            new SoftwareTester("Karla","Kartalic",44,"projekt2",true)
        };*/


        public void AddEmployees(T entity) 
        {
            employeelist.Add(entity);   
        }

        public void RemoveEmployees(T entity)
        {
            employeelist.Remove(entity);
        }

        public IEnumerable<T> AllEmployees() 
        {
            return employeelist;
        }
    }
}
