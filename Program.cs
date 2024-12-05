using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Employee.Services;
using Employee.Validation;
using Employee.Constants;
using Employee.Storage;
using Employee.Roles;
using System.Data;

namespace Employee
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            IEmployeeBase employee = new EmployeeBase();
            IEmployeeBaseService employeeservice = new EmployeeBaseService<IEmployeeBase>(employee);
            
            do
            {
                StandardMessages.PossibleCommands();
                string command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case ConstantsCommands.HELP:
                        StandardMessages.HelpCommand();
                        break;
                    case ConstantsCommands.ADD:
                        StandardMessages.PossibleRoles();
                        string roleforinput = Console.ReadLine().ToLower();
                        IEmployeeBaseService employeeService = Factory.CreateRoleService(roleforinput);
                        if (!ConsoleValidation.RoleType(employeeService)) break;
                        employeeService.AddEmployeesService();
                        break;
                    case ConstantsCommands.REMOVE:
                        PropertiesDataMessages.InputId();
                        int id = int.Parse(Console.ReadLine());
                        employeeservice.RemoveEmployeesService(id);
                        break;
                    case ConstantsCommands.DISPLAY:
                        StandardMessages.ListAllEmployees();
                        employeeservice.DisplayAllEmployees();
                        break;
                    case ConstantsCommands.LIST:
                        StandardMessages.ListWithoutCEO();
                        employeeservice.DisplayEmployeesWithoutCEO();
                        break;
                    case ConstantsCommands.ROLELIST:
                        StandardMessages.PossibleRoles();
                        string roleforoutput = Console.ReadLine().ToLower();
                        employeeservice.ListByRole(roleforoutput);
                        break;
                    default:
                        StandardMessages.NonExistentCommand();
                        break;
                }
            } while (true);
        }
    }
 }

