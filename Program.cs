using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Employee.Services;

namespace Employee
{
    internal class Program
    {

        static void Main(string[] args)
        {
            EmployeeCommands command = new EmployeeCommands();
            while (true)
            {

                Console.WriteLine("Dostupne naredbe: Dodaj, Ukloni, Prikazi, Popis, Uloga ");
                
                string opcija = Console.ReadLine();

                switch (opcija.ToLower())
                {
                    case "dodaj":
                        Console.WriteLine("Uloga: CEO, ProjectManager, Developer, Designer, SoftwareTester");
                        string uloga = Console.ReadLine();
                        command.AddEmployees(uloga);
                        break;
                    case "ukloni":
                        Console.WriteLine("Unesite prezime zaposlenika kojeg želite ukloniti: ");
                        string prezime = Console.ReadLine();
                        command.RemoveEmployees(prezime);
                        break;
                    case "prikazi":
                        Console.WriteLine("Prikaz svih zaposlenika: ");
                        command.DisplayAllEmployees();
                        break;
                    case "popis":
                        Console.WriteLine("Prikaz zaposlenika bez CEO: ");
                        command.DisplayEmployeesWithoutCEO();
                        break;
                    case "uloga":
                        Console.WriteLine("Prikaz zaposlenika prema ulozi: ");
                        string role = Console.ReadLine();
                        command.ListByRole(role);
                        break;
                    default:
                        Console.WriteLine("Nepostojeća naredba!");
                        break;

                }
                Console.ReadKey();
            }
        }

    }
        /*public abstract class Employee
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
            public abstract string GetInfo();
      
        }
        public class CEO : Employee
        {
            public int CeoYears { get; set; }

            public CEO(string firstName, string lastName, int age, int ceoYears) : base(firstName, lastName, age)
            {
                CeoYears = ceoYears;
            }
            public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} CEO = {CeoYears}";
            
        }
        public class ProjectManager : Employee
        {
            public string Project { get; set; }

            public ProjectManager(string firstName, string lastName, int age, string project) : base(firstName,lastName,age) 
            {
                Project = project;
            }
            public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project}";
            

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
            public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project} Student = {IsStudent}";
            
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
            public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project} Crtanje = {CanDraw}";
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
            public override string GetInfo() => $"{FirstName} {LastName} Godine = {Age} Projekt = {Project} Automatizirani test = {UseAutomatedTests}";

        }*/

    /*public class EmployeeCommands
    {
        private List<Employee> employees = new List<Employee>();
        private CEO ceo;

        public void AddEmployees(string role)
        {
            switch (role.ToLower())
            {
                case "ceo":
                    if (ceo != null)
                    {
                        Console.WriteLine("CEO vec postoji");
                    }
                    else
                    {
                        Console.WriteLine("Unesi ime: ");
                        string ceofirstName = Console.ReadLine();
                        Console.WriteLine("Unesi prezime: ");
                        string ceolastName = Console.ReadLine();
                        Console.WriteLine("Unesi broj godina: ");
                        int ceoage = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesi broj godina kao CEO: ");
                        int ceoYears = int.Parse(Console.ReadLine());
                        ceo = new CEO(ceofirstName, ceolastName, ceoage, ceoYears);
                        employees.Add(ceo);
                    }
                    break;
                case "projectmanager":

                    Console.WriteLine("Unesi ime: ");
                    string pmfirstName = Console.ReadLine();
                    Console.WriteLine("Unesi prezime: ");
                    string pmlastName = Console.ReadLine();
                    Console.WriteLine("Unesi broj godina: ");
                    int pmAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesi projekt: ");
                    string pmProject = Console.ReadLine();
                    employees.Add(new ProjectManager(pmfirstName, pmlastName, pmAge, pmProject));
                    break;
                case "developer":
                    Console.WriteLine("Unesi ime: ");
                    string devfirstName = Console.ReadLine();
                    Console.WriteLine("Unesi prezime: ");
                    string devlastName = Console.ReadLine();
                    Console.WriteLine("Unesi broj godina: ");
                    int devAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesi projekt: ");
                    string devProject = Console.ReadLine();
                    Console.WriteLine("Je li student? true/false ");
                    bool isStudent = bool.Parse(Console.ReadLine());
                    employees.Add(new Developer(devfirstName, devlastName, devAge, devProject, isStudent));
                    break;
                case "designer":
                    Console.WriteLine("Unesi ime: ");
                    string desfirstName = Console.ReadLine();
                    Console.WriteLine("Unesi prezime: ");
                    string deslastName = Console.ReadLine();
                    Console.WriteLine("Unesi broj godina: ");
                    int desAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesi projekt: ");
                    string desProject = Console.ReadLine();
                    Console.WriteLine("Zna li crtati? true/false ");
                    bool descanDraw = bool.Parse(Console.ReadLine());
                    employees.Add(new Designer(desfirstName, deslastName, desAge, desProject, descanDraw));
                    break;
                case "softwaretester":
                    Console.WriteLine("Unesi ime: ");
                    string stfirstName = Console.ReadLine();
                    Console.WriteLine("Unesi prezime: ");
                    string stlastName = Console.ReadLine();
                    Console.WriteLine("Unesi broj godina: ");
                    int stAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesi projekt: ");
                    string stProject = Console.ReadLine();
                    Console.WriteLine("Zna li crtati? true/false ");
                    bool stUsesAutomatedTests = bool.Parse(Console.ReadLine());
                    employees.Add(new SoftwareTester(stfirstName, stlastName, stAge, stProject, stUsesAutomatedTests));
                    break;

            }

        }
        public void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }

        }

        public void RemoveEmployees(string lastName)
        {
            var employee = employees.First(x => x.LastName == lastName);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Zaposlenik izbrisan!");
            }
            else
            {
                Console.WriteLine("Zaposlenik ne postoji! ");
            }
        }
        public void ListByRole(string role) 
        {
            foreach (var employee in employees) 
            {
                Console.WriteLine(employee.GetInfo());
            }
        }



     }*/
        
    
 }

