using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Common 
{
    public static class EmployeeCommon 
    {
        public static void Commands() 
        {
            Console.WriteLine("Possible commands: Help, Add, Remove, Display, List, RoleList");
        }
        public static void Roles() 
        {
            Console.WriteLine("Uloge: CEO, ProjectManager, Developer, Designer, SoftwareTester");
        }
        public static void Exit(string entry) 
        {
            if (entry == "exit")
            {
                Console.WriteLine("Prekid unosa!");
                return;
            }
        }
    }
}

/*
namespace Employee.Common
{
    public abstract class EmployeeCommon
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public EmployeeCommon(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public abstract string GetInfo();
    }
}*/
