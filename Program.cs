using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("0) Pomoć ");
                Console.WriteLine("1) Dodaj ");
                Console.WriteLine("2) Ukloni ");
                Console.WriteLine("3) Prikaži ");
                Console.WriteLine("4) Popis ");
                Console.WriteLine("5) <ime_uloge>Popis");
                int opcija = int.Parse(Console.ReadLine());

                switch (opcija)
                {
                    case 0:
                        continue;
                    case 1:
                        continue;
                    default:
                        Console.WriteLine("Nepostojeća opcija!");
                        continue;

                }
                Console.ReadKey();
            }
        }

    }
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Employee(string firstName, string lastName, int age) 
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
        }

        public class CEO : Employee
        {
            public int CeoYears { get; set; }

            public CEO(string firstName, string lastName, int age, int ceoYears) : base(firstName,lastName,age) 
            {
                CeoYears = ceoYears;
            }
        }
        public class ProjectManager : Employee
        {
            public string Project { get; set; }

            public ProjectManager(string firstName, string lastName, int age, string project) : base(firstName,lastName,age) 
            {
                Project = project;
            }
            
        }

        public class Developer : Employee
        {
            public string Project { get; set; }
            public bool IsStudent { get; set; }

            public Developer(string firstName, string lastName, int age, string project, bool isStudent) : base(firstName,lastName,age)
            {
                Project = project;
                IsStudent = isStudent;
            }
        }

        public class Designer : Employee 
        {   
            public string Project { get; set; }
            public bool CanDraw { get; set; }

            public Designer(string firstName, string lastName, int age, string project, bool canDraw) : base(firstName,lastName,age)
            {   
                Project=project;
                CanDraw = canDraw;
            }
        }

        public class SoftwareTester : Employee
        {
            public string Project { get; set; }
            public bool UseAutomatedTests { get; set; }

            public SoftwareTester(string firstName, string lastName, int age, string project, bool useAutomatedTests) : base(firstName, lastName, age)
            {
                Project = project;
                UseAutomatedTests = useAutomatedTests;
            }

        }
        
    
 }

