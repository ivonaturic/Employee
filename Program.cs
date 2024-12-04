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
            ConstantsMessages.WelcomeMessage();
            IEmployeeBase employee = new EmployeeBase();
            IEmployeeBaseService employeeservice = new EmployeeBaseService<IEmployeeBase>(employee);
            
            do
            {
                ConstantsMessages.PossibleCommands();
                string command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case ConstantsCommands.HELP:
                        ConstantsMessages.HelpCommand();
                        break;
                    case ConstantsCommands.ADD:
                        ConstantsMessages.PossibleRoles();
                        string roleforinput = Console.ReadLine().ToLower();
                        IEmployeeBaseService employeeService = Factory.CreateRoleService(roleforinput);
                        employeeService.AddEmployeesService();
                        break;
                    case ConstantsCommands.REMOVE:
                        ConstantsMessages.InputIdForRemoveEmployee();
                        int id = int.Parse(Console.ReadLine());
                        employeeservice.RemoveEmployeesService(id);
                        break;
                    case ConstantsCommands.DISPLAY:
                        ConstantsMessages.ListAllEmployees();
                        employeeservice.DisplayAllEmployees();
                        break;
                    case ConstantsCommands.LIST:
                        ConstantsMessages.ListWithoutCEO();
                        employeeservice.DisplayEmployeesWithoutCEO();
                        break;
                    case ConstantsCommands.ROLELIST:
                        ConstantsMessages.PossibleRoles();
                        string roleforoutput = Console.ReadLine().ToLower();
                        employeeservice.ListByRole(roleforoutput);
                        break;
                    default:
                        ConstantsMessages.NonExistentCommand();
                        break;
                }
            } while (true);
        }
    }
 }

