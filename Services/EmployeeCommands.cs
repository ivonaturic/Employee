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

                    string devlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        devlastName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(devlastName));

                    string devAgestring;
                    int devAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        devAgestring = Console.ReadLine();
                    }
                    while(!validation.ValidationInt(devAgestring));
                    devAge = int.Parse(devAgestring);

                    string devProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        devProject = Console.ReadLine();
                    }
                    while(!validation.ValidationString(devProject));

                    string isStudentstring;
                    bool isStudent;
                    do
                    {
                        Console.WriteLine("Je li student? true/false ");
                        isStudentstring = Console.ReadLine();
                    }
                    while(!validation.ValidationBoolean(isStudentstring));
                    isStudent = bool.Parse(isStudentstring);

                    storage.AddEmployees(new Developer(devfirstName, devlastName, devAge, devProject, isStudent));
                    break;

                case "designer":
                    string desfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        desfirstName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(desfirstName));

                    string deslastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        deslastName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(deslastName));

                    string desAgestring;
                    int desAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        desAgestring = Console.ReadLine();
                    }
                    while(!validation.ValidationInt(desAgestring));
                    desAge = int.Parse(desAgestring);

                    string desProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        desProject = Console.ReadLine();
                    }
                    while(!validation.ValidationString(desProject));

                    string descanDrawstring;
                    bool descanDraw;
                    do
                    {
                        Console.WriteLine("Zna li crtati? true/false ");
                        descanDrawstring = Console.ReadLine();
                    }
                    while(!validation.ValidationBoolean(descanDrawstring));
                    descanDraw = bool.Parse(descanDrawstring);

                    storage.AddEmployees(new Designer(desfirstName, deslastName, desAge, desProject, descanDraw));
                    break;

                case "softwaretester":
                    string stfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        stfirstName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(stfirstName));

                    string stlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        stlastName = Console.ReadLine();
                    }
                    while(!validation.ValidationString(stlastName));

                    string stAgestring;
                    int stAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        stAgestring = Console.ReadLine();
                    }
                    while(!validation.ValidationInt(stAgestring));
                    stAge = int.Parse(stAgestring);

                    string stProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        stProject = Console.ReadLine();
                    }
                    while(!validation.ValidationString(stProject));

                    string stUsesAutomatedTestsstring;
                    bool stUsesAutomatedTests;
                    do
                    {
                        Console.WriteLine("Zna li crtati? true/false ");
                        stUsesAutomatedTestsstring = Console.ReadLine();
                    }
                    while(!validation.ValidationBoolean(stUsesAutomatedTestsstring));
                    stUsesAutomatedTests = bool.Parse(stUsesAutomatedTestsstring);

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
