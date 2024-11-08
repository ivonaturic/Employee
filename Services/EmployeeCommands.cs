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
        EmployeeValidation validation = new EmployeeValidation();
        private CEO ceo;

        public void AddEmployees(string role)
        {
            switch (role.ToLower())
            {
                case "ceo":
                    var firstceo = storage.AllEmployees().Where(e => e.Equals(GetType().Name == "CEO"));
                    if (firstceo != null)
                    {
                        Console.WriteLine("CEO vec postoji");
                    }
                    else
                    {
                        string ceofirstName;
                        do
                        {
                            Console.WriteLine("Unesi ime: ");
                            ceofirstName = Console.ReadLine();
                        }
                        while(!validation.ValidationString(ceofirstName));
                        string ceolastName;
                        do
                        {
                            Console.WriteLine("Unesi prezime: ");
                            ceolastName = Console.ReadLine();
                        }
                        while(!validation.ValidationString(ceolastName));
                        string ceoagestring;
                        int ceoAge;
                        do
                        {
                            Console.WriteLine("Unesi broj godina: ");
                            ceoagestring = Console.ReadLine();
                        }
                        while(!validation.ValidationInt(ceoagestring));
                        ceoAge = int.Parse(ceoagestring);

                        string ceoYearsstring;
                        int ceoYears;
                        do
                        {
                            Console.WriteLine("Unesi broj godina kao CEO: ");
                            ceoYearsstring = Console.ReadLine();
                        }
                        while(!validation.ValidationInt(ceoYearsstring));
                        ceoYears = int.Parse(ceoYearsstring);

                        ceo = new CEO(ceofirstName, ceolastName, ceoAge, ceoYears);
                        storage.AddEmployees(ceo);
                    }
                    break;
                case "projectmanager":

                    string pmfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        pmfirstName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(pmfirstName));

                    string pmlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        pmlastName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(pmlastName));

                    string pmAgestring;
                    int pmAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        pmAgestring = Console.ReadLine();
                    }
                    while(!validation.ValidationInt(pmAgestring));
                    pmAge = int.Parse(pmAgestring);

                    string pmProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        pmProject = Console.ReadLine();
                    }
                    while(!validation.ValidationString(pmProject));

                    storage.AddEmployees(new ProjectManager(pmfirstName, pmlastName, pmAge, pmProject));
                    break;

                case "developer":
                    string devfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        devfirstName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(devfirstName));


                    Console.WriteLine("Unesi prezime: ");
                    string devlastName = Console.ReadLine();
                    if(!validation.ValidationString(devlastName)) return;
                    Console.WriteLine("Unesi broj godina: ");
                    string devAgestring = Console.ReadLine();
                    if(!validation.ValidationInt(devAgestring)) return;
                    int devAge = int.Parse(devAgestring);
                    Console.WriteLine("Unesi projekt: ");
                    string devProject = Console.ReadLine();
                    if(!validation.ValidationString(devProject)) return;
                    Console.WriteLine("Je li student? true/false ");
                    string isStudentstring = Console.ReadLine();
                    if(!validation.ValidationBoolean(isStudentstring)) return;
                    bool isStudent = bool.Parse(isStudentstring);
                    storage.AddEmployees(new Developer(devfirstName, devlastName, devAge, devProject, isStudent));
                    break;
                case "designer":
                    Console.WriteLine("Unesi ime: ");
                    string desfirstName = Console.ReadLine();
                    if(!validation.ValidationString(desfirstName)) return;
                    Console.WriteLine("Unesi prezime: ");
                    string deslastName = Console.ReadLine();
                    if(!validation.ValidationString(deslastName)) return;
                    Console.WriteLine("Unesi broj godina: ");
                    string desAgestring = Console.ReadLine();
                    if(!validation.ValidationInt(desAgestring)) return;
                    int desAge = int.Parse(desAgestring);
                    Console.WriteLine("Unesi projekt: ");
                    string desProject = Console.ReadLine();
                    if(!validation.ValidationString(desProject)) return;
                    Console.WriteLine("Zna li crtati? true/false ");
                    string descanDrawstring = Console.ReadLine();
                    if(!validation.ValidationBoolean(descanDrawstring)) return;
                    bool descanDraw = bool.Parse(descanDrawstring);
                    storage.AddEmployees(new Designer(desfirstName, deslastName, desAge, desProject, descanDraw));
                    break;
                case "softwaretester":
                    Console.WriteLine("Unesi ime: ");
                    string stfirstName = Console.ReadLine();
                    if(!validation.ValidationString(stfirstName)) return;
                    Console.WriteLine("Unesi prezime: ");
                    string stlastName = Console.ReadLine();
                    if(!validation.ValidationString(stlastName)) return;
                    Console.WriteLine("Unesi broj godina: ");
                    string stAgestring = Console.ReadLine();
                    if(!validation.ValidationInt(stAgestring)) return;
                    int stAge = int.Parse(stAgestring);
                    Console.WriteLine("Unesi projekt: ");
                    string stProject = Console.ReadLine();
                    if(!validation.ValidationString(stProject)) return;
                    Console.WriteLine("Zna li crtati? true/false ");
                    string stUsesAutomatedTestsstring = Console.ReadLine();
                    if(!validation.ValidationBoolean(stUsesAutomatedTestsstring)) return;
                    bool stUsesAutomatedTests = bool.Parse(stUsesAutomatedTestsstring);
                    storage.AddEmployees(new SoftwareTester(stfirstName, stlastName, stAge, stProject, stUsesAutomatedTests));
                    break;
                default:
                    Console.WriteLine("Nepostojeća uloga!");
                    break;
            }

        }
        public void RemoveEmployees(string lastName)
        {
            var remEmployee = storage.AllEmployees().FirstOrDefault(e=>e.LastName.ToLower().Equals(lastName.ToLower()));
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
