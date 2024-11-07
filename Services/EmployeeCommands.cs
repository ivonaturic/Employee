using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Roles;
using Employee.Storage;
using Employee.Validation;

namespace Employee.Services
{
    public class EmployeeCommands
    {
        EmployeeStorage storage = new EmployeeStorage();
        private CEO ceo;

        public void AddEmployees(string role)
        {
            switch (role.ToLower())
            {
                case "ceo":
                    var ceoceo = storage.AllEmployees().Where(e => e.Equals(GetType().Name == "CEO"));
                    if (ceoceo != null)
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
                        storage.AddEmployees(ceo);
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
                    storage.AddEmployees(new ProjectManager(pmfirstName, pmlastName, pmAge, pmProject));
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
                    storage.AddEmployees(new Developer(devfirstName, devlastName, devAge, devProject, isStudent));
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
                    storage.AddEmployees(new Designer(desfirstName, deslastName, desAge, desProject, descanDraw));
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
                    storage.AddEmployees(new SoftwareTester(stfirstName, stlastName, stAge, stProject, stUsesAutomatedTests));
                    break;
                default:
                    Console.WriteLine("Nepostojeća uloga!");
                    break;
            }

        }
        public void RemoveEmployees(string lastName)
        {
            var remEmployee = storage.AllEmployees().FirstOrDefault(e=>e.LastName.Equals(lastName));
            if (remEmployee != null)
            {
                storage.RemoveEmployees(remEmployee);
                Console.WriteLine("Korisnik je uspješno uklonjen!");
            }
            else 
            {
                Console.WriteLine("Zaposlenik ne postoji!");
            }
        }
        public void DisplayAllEmployees()
        {
            var allemployees = storage.AllEmployees();
            if (allemployees != null)
            {
                foreach (var employee in allemployees)
                {
                    Console.WriteLine(employee.GetInfo());
                }
            }
            else 
            {
                Console.WriteLine("Nema unesenih zaposlenika!");
            }
        }
        public void DisplayEmployeesWithoutCEO()
        {
            var employees = storage.AllEmployees().Where(e => e.GetType().Name != "CEO");
            if (employees != null)
            {
                foreach (var employ in employees)
                {
                    Console.WriteLine(employ.GetInfo());
                }
            }
            else 
            {
                Console.WriteLine("Nema unesenih zaposlenika!");
            }
        }
        public void ListByRole(string role)
        {
            var listbyrole = storage.AllEmployees().Where(e=>e.GetType().Name.ToLower() == role.ToLower());
            if (listbyrole != null)
            {
                foreach (var employee in listbyrole)
                {
                    Console.WriteLine(employee.GetInfo());
                }
            }
            else
            {
                Console.WriteLine("Za unesenu ulogu nema unesenih zaposlenika!");
            }
        }
    }
}
