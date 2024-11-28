using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Employee.Services;
using Employee.Validation;
using Employee.Common;
using Employee.Storage;
using Employee.Roles;
using Employee.Constants;
using System.Data;

namespace Employee
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            IEmployeeBase employee = new EmployeeBase();
            IEmployeeBaseService employeeservice = new EmployeeBaseService<IEmployeeBase>(employee);
            
            do
            {
                Console.WriteLine(ConstantsMessages.PossibleCommands);
                string command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case ConstantsCommands.HELP:
                        Console.WriteLine(ConstantsHelp.HELP);
                        break;
                    case ConstantsCommands.ADD:
                        Console.WriteLine(ConstantsMessages.PossibleRoles);
                        string roleforinput = Console.ReadLine().ToLower();
                        IEmployeeBaseService employeeService = Factory.CreateRoleService(roleforinput);
                        employeeService.AddEmployeesService();
                        break;
                    case ConstantsCommands.REMOVE:
                        Console.WriteLine(ConstantsMessages.InputId);
                        int id = int.Parse(Console.ReadLine());
                        employeeservice.RemoveEmployeesService(id);
                        break;
                    case ConstantsCommands.DISPLAY:
                        Console.WriteLine(ConstantsMessages.ListAllEmployees);
                        employeeservice.DisplayAllEmployees();
                        break;
                    case ConstantsCommands.LIST:
                        Console.WriteLine(ConstantsMessages.ListWithoutCEO);
                        employeeservice.DisplayEmployeesWithoutCEO();
                        break;
                    case ConstantsCommands.ROLELIST:
                        Console.WriteLine(ConstantsMessages.PossibleRoles);
                        string roleforoutput = Console.ReadLine().ToLower();
                        employeeservice.ListByRole(roleforoutput);
                        break;
                    default:
                        Console.WriteLine(ConstantsMessages.NonExistentCommand);
                        break;
                }
            } while (true);
        }
    }
 }

