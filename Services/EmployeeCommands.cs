using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Common;
using Employee.Roles;
using Employee.Storage;
using Employee.Validation;
//using Employee.Common;

/*namespace Employee.Services
{
    public class EmployeeCommands
    {
        EmployeeStorage storage = new EmployeeStorage();
        //EmployeeValidation validation = new EmployeeValidation();
        //private CEO ceo;

        public void AddEmployees(string role)
        {
            switch (role.ToLower())
            {
                case "ceo":
                    var firstceo = storage.AllEmployees().Where(e => e.GetType().Name == "CEO");
                    if (firstceo.Any())
                    {
                        Console.WriteLine("CEO already exists, there can only be one!");
                    }
                    else
                    {

                        string ceofirstName;
                        do
                        {
                            Console.WriteLine("First name: ");
                            ceofirstName = Console.ReadLine();
                            EmployeeCommon.Exit(ceofirstName);

                        }
                        while (!EmployeeValidation.ValidationString(ceofirstName) || !EmployeeValidation.ValidationNameOrLastName(ceofirstName));

                        string ceolastName;
                        do
                        {
                            Console.WriteLine("Last name: ");
                            ceolastName = Console.ReadLine();
                            EmployeeCommon.Exit(ceolastName);
                        }
                        while (!EmployeeValidation.ValidationString(ceolastName) || !EmployeeValidation.ValidationNameOrLastName(ceolastName));
                        string ceoagestring;
                        int ceoAge;
                        do
                        {
                            Console.WriteLine("Age: ");
                            ceoagestring = Console.ReadLine();
                            EmployeeCommon.Exit(ceoagestring);
                        }
                        while (!EmployeeValidation.ValidationAge(ceoagestring));
                        ceoAge = int.Parse(ceoagestring);

                        string ceoYearsstring;
                        int ceoYears;
                        do
                        {
                            Console.WriteLine("Years of CEO: ");
                            ceoYearsstring = Console.ReadLine();
                            EmployeeCommon.Exit(ceoYearsstring);
                        }
                        while (!EmployeeValidation.ValidationCEOAge(ceoYearsstring));
                        ceoYears = int.Parse(ceoYearsstring);

                        try
                        {
                            storage.AddEmployees(new CEO(ceofirstName, ceolastName, ceoAge, ceoYears));
                            Console.WriteLine("CEO successfully added");

                        }
                        catch
                        {
                            Console.WriteLine("CEO cannot be added!");
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
                        EmployeeCommon.Exit(pmfirstName);
                    }
                    while(!EmployeeValidation.ValidationString(pmfirstName) || !EmployeeValidation.ValidationNameOrLastName(pmfirstName));

                    string pmlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        pmlastName = Console.ReadLine();
                        EmployeeCommon.Exit(pmlastName);
                    }
                    while(!EmployeeValidation.ValidationString(pmlastName) || !EmployeeValidation.ValidationNameOrLastName(pmlastName));

                    string pmAgestring;
                    int pmAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        pmAgestring = Console.ReadLine();
                        EmployeeCommon.Exit(pmAgestring);
                    }
                    while(!EmployeeValidation.ValidationAge(pmAgestring));
                    pmAge = int.Parse(pmAgestring);

                    string pmProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        pmProject = Console.ReadLine();
                        EmployeeCommon.Exit(pmProject);
                    }
                    while(!EmployeeValidation.ValidationString(pmProject));

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
                        EmployeeCommon.Exit(devfirstName);
                    }
                    while(!EmployeeValidation.ValidationString(devfirstName) || !EmployeeValidation.ValidationNameOrLastName(devfirstName));

                    string devlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        devlastName = Console.ReadLine();
                        EmployeeCommon.Exit(devlastName);
                    }
                    while(!EmployeeValidation.ValidationString(devlastName) || !EmployeeValidation.ValidationNameOrLastName(devlastName));

                    string devAgestring;
                    int devAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        devAgestring = Console.ReadLine();
                        EmployeeCommon.Exit(devAgestring);
                    }
                    while(!EmployeeValidation.ValidationAge(devAgestring));
                    devAge = int.Parse(devAgestring);

                    string devProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        devProject = Console.ReadLine();
                        EmployeeCommon.Exit(devProject);
                    }
                    while(!EmployeeValidation.ValidationString(devProject));

                    string isStudentstring;
                    bool isStudent;
                    do
                    {
                        Console.WriteLine("Je li student? true/false ");
                        isStudentstring = Console.ReadLine();
                        EmployeeCommon.Exit(isStudentstring);
                    }
                    while(!EmployeeValidation.ValidationBoolean(isStudentstring));
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
                        EmployeeCommon.Exit(desfirstName);
                    }
                    while(!EmployeeValidation.ValidationString(desfirstName) || !EmployeeValidation.ValidationNameOrLastName(desfirstName));

                    string deslastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        deslastName = Console.ReadLine();
                        EmployeeCommon.Exit(deslastName);
                    }
                    while(!EmployeeValidation.ValidationString(deslastName) || !EmployeeValidation.ValidationNameOrLastName(deslastName));

                    string desAgestring;
                    int desAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        desAgestring = Console.ReadLine();
                        EmployeeCommon.Exit(desAgestring);
                    }
                    while(!EmployeeValidation.ValidationAge(desAgestring));
                    desAge = int.Parse(desAgestring);

                    string desProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        desProject = Console.ReadLine();
                        EmployeeCommon.Exit(desProject);
                    }
                    while(!EmployeeValidation.ValidationString(desProject));

                    string descanDrawstring;
                    bool descanDraw;
                    do
                    {
                        Console.WriteLine("Zna li crtati? true/false ");
                        descanDrawstring = Console.ReadLine();
                        EmployeeCommon.Exit(descanDrawstring);
                    }
                    while(!EmployeeValidation.ValidationBoolean(descanDrawstring));
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
                        EmployeeCommon.Exit(stfirstName);
                    }
                    while(!EmployeeValidation.ValidationString(stfirstName) || !EmployeeValidation.ValidationNameOrLastName(stfirstName));

                    string stlastName;
                    do
                    {
                        Console.WriteLine("Unesi prezime: ");
                        stlastName = Console.ReadLine();
                        EmployeeCommon.Exit(stlastName);
                    }
                    while(!EmployeeValidation.ValidationString(stlastName) || !EmployeeValidation.ValidationNameOrLastName(stlastName));

                    string stAgestring;
                    int stAge;
                    do
                    {
                        Console.WriteLine("Unesi broj godina: ");
                        stAgestring = Console.ReadLine();
                        EmployeeCommon.Exit(stAgestring);
                    }
                    while(!EmployeeValidation.ValidationAge(stAgestring));
                    stAge = int.Parse(stAgestring);

                    string stProject;
                    do
                    {
                        Console.WriteLine("Unesi projekt: ");
                        stProject = Console.ReadLine();
                        EmployeeCommon.Exit(stProject);
                    }
                    while(!EmployeeValidation.ValidationString(stProject));

                    string stUsesAutomatedTestsstring;
                    bool stUsesAutomatedTests;
                    do
                    {
                        Console.WriteLine("Zna li crtati? true/false ");
                        stUsesAutomatedTestsstring = Console.ReadLine();
                        EmployeeCommon.Exit(stUsesAutomatedTestsstring);
                    }
                    while(!EmployeeValidation.ValidationBoolean(stUsesAutomatedTestsstring));
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
}*/
