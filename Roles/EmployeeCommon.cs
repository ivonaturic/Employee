using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Roles
{
    public abstract class EmployeeCommon
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public EmployeeCommon(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public virtual string GetInfo() => $"Id = {Id} {FirstName} {LastName} Age = {Age}";
    }
}
