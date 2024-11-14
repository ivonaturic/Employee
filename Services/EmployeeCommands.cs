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
        //private CEO ceo;

        public void AddEmployees(string role)
        {
            switch (role.ToLower())
            {
                case "ceo":
                    var firstceo = storage.AllEmployees().Where(e => e.GetType().Name == "CEO");
                    if (firstceo.Any())
                    {
                        Console.WriteLine("CEO vec postoji, može biti samo jedan!");
                    }
                    else
                    {
                        string ceofirstName;
                        do
                        {
                            Console.WriteLine("Unesi ime: ");
                            ceofirstName = Console.ReadLine();
                            if (ceofirstName == "exit") 
                            {
                                Console.WriteLine("Prekid unosa!");
                                return;
                            }

                        }
                        while (!validation.ValidationString(ceofirstName) || !validation.ValidationNameOrLastName(ceofirstName));

                        string ceolastName;
                        do
                        {
                            Console.WriteLine("Unesi prezime: ");
                            ceolastName = Console.ReadLine();
                            if (ceolastName == "exit")
                            {
                                Console.WriteLine("Prekid unosa!");
                                return;
                            }
                        }
                        while (!validation.ValidationString(ceolastName) || !validation.ValidationNameOrLastName(ceolastName));
                        string ceoagestring;
                        int ceoAge;
                        do
                        {
                            Console.WriteLine("Unesi broj godina: ");
                            ceoagestring = Console.ReadLine();
                            if (ceoagestring == "exit")
                            {
                                Console.WriteLine("Prekid unosa!");
                                return;
                            }
                        }
                        while (!validation.ValidationInt(ceoagestring));
                        ceoAge = int.Parse(ceoagestring);

                        string ceoYearsstring;
                        int ceoYears;
                        do
                        {
                            Console.WriteLine("Unesi broj godina kao CEO: ");
                            ceoYearsstring = Console.ReadLine();
                            if (ceoYearsstring == "exit")
                            {
                                Console.WriteLine("Prekid unosa!");
                                return;
                            }
                        }
                        while (!validation.ValidationInt(ceoYearsstring));
                        ceoYears = int.Parse(ceoYearsstring);

                        try
                        {
                            storage.AddEmployees(new CEO(ceofirstName, ceolastName, ceoAge, ceoYears));
                            Console.WriteLine("CEO je uspješno dodan!");

                        }
                        catch
                        {
                            Console.WriteLine("CEO nije moguće dodati!");
                        }
                        //storage.AddEmployees(ceo);
                    }
                    break;
                case "projectmanager":

                    string pmfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        pmfirstName = Console.ReadLine();
                        if (pmfirstName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(pmfirstName) || !validation.ValidationNameOrLastName(pmfirstName));

                    string pmlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        pmlastName = Console.ReadLine();
                        if (pmlastName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(pmlastName) || !validation.ValidationNameOrLastName(pmlastName));

                    string pmAgestring;
                    int pmAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        pmAgestring = Console.ReadLine();
                        if (pmAgestring == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationInt(pmAgestring));
                    pmAge = int.Parse(pmAgestring);

                    string pmProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        pmProject = Console.ReadLine();
                        if (pmProject == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(pmProject));

                    try
                    {
                        storage.AddEmployees(new ProjectManager(pmfirstName, pmlastName, pmAge, pmProject));
                        Console.WriteLine("ProjectManager je uspješno dodan!");
                    }
                    catch 
                    {
                        Console.WriteLine("ProjectManagera nije moguće dodati!");
                    }
                    break;

                case "developer":
                    string devfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        devfirstName = Console.ReadLine();
                        if (devfirstName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(devfirstName) || !validation.ValidationNameOrLastName(devfirstName));

                    string devlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        devlastName = Console.ReadLine();
                        if (devlastName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(devlastName) || !validation.ValidationNameOrLastName(devlastName));

                    string devAgestring;
                    int devAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        devAgestring = Console.ReadLine();
                        if (devAgestring == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationInt(devAgestring));
                    devAge = int.Parse(devAgestring);

                    string devProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        devProject = Console.ReadLine();
                        if (devProject == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(devProject));

                    string isStudentstring;
                    bool isStudent;
                    do
                    {
                        Console.WriteLine("Je li student? true/false ");
                        isStudentstring = Console.ReadLine();
                        if (isStudentstring == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationBoolean(isStudentstring));
                    isStudent = bool.Parse(isStudentstring);

                    try
                    {
                        storage.AddEmployees(new Developer(devfirstName, devlastName, devAge, devProject, isStudent));
                        Console.WriteLine("Developer je dodan!");
                    }
                    catch 
                    {
                        Console.WriteLine("Developera nije moguće dodati!");
                    }
                    break;

                case "designer":
                    string desfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        desfirstName = Console.ReadLine();
                        if (desfirstName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(desfirstName) || !validation.ValidationNameOrLastName(desfirstName));

                    string deslastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        deslastName = Console.ReadLine();
                        if (deslastName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(deslastName) || !validation.ValidationNameOrLastName(deslastName));

                    string desAgestring;
                    int desAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        desAgestring = Console.ReadLine();
                        if (desAgestring == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationInt(desAgestring));
                    desAge = int.Parse(desAgestring);

                    string desProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        desProject = Console.ReadLine();
                        if (desProject == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(desProject));

                    string descanDrawstring;
                    bool descanDraw;
                    do
                    {
                        Console.WriteLine("Zna li crtati? true/false ");
                        descanDrawstring = Console.ReadLine();
                        if (descanDrawstring == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationBoolean(descanDrawstring));
                    descanDraw = bool.Parse(descanDrawstring);

                    try
                    {
                        storage.AddEmployees(new Designer(desfirstName, deslastName, desAge, desProject, descanDraw));
                        Console.WriteLine("Designer je dodan!");
                    }
                    catch 
                    {
                        Console.WriteLine("Designera nije moguće dodati!");
                    }
                    break;

                case "softwaretester":
                    string stfirstName;
                    do
                    {
                        Console.WriteLine("Unesi ime: ");
                        stfirstName = Console.ReadLine();
                        if (stfirstName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(stfirstName) || !validation.ValidationNameOrLastName(stfirstName));

                    string stlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        stlastName = Console.ReadLine();
                        if (stlastName == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(stlastName) || !validation.ValidationNameOrLastName(stlastName));

                    string stAgestring;
                    int stAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        stAgestring = Console.ReadLine();
                        if (stAgestring == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationInt(stAgestring));
                    stAge = int.Parse(stAgestring);

                    string stProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        stProject = Console.ReadLine();
                        if (stProject == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationString(stProject));

                    string stUsesAutomatedTestsstring;
                    bool stUsesAutomatedTests;
                    do
                    {
                        Console.WriteLine("Zna li crtati? true/false ");
                        stUsesAutomatedTestsstring = Console.ReadLine();
                        if (stUsesAutomatedTestsstring == "exit")
                        {
                            Console.WriteLine("Prekid unosa!");
                            return;
                        }
                    }
                    while(!validation.ValidationBoolean(stUsesAutomatedTestsstring));
                    stUsesAutomatedTests = bool.Parse(stUsesAutomatedTestsstring);

                    try
                    {
                        storage.AddEmployees(new SoftwareTester(stfirstName, stlastName, stAge, stProject, stUsesAutomatedTests));
                        Console.WriteLine("SoftwareTester je dodan!");
                    }
                    catch 
                    {
                        Console.WriteLine("SoftwareTestter nije dodan!");
                    }
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
            if (allemployees.Any())
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
            if (employees.Any())
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
            if (listbyrole.Any())
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
