using System;
using Employee.Services;
using Employee.Validation;
using Employee.Common;
using Employee.Storage;
using Employee.Roles;
using System.Data;

namespace Employee
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(StaticMessages.WelcomeMessage);
            IBaseModel employee = new BaseModel();
            IBaseService employeeservice = new BaseService<IBaseModel>(employee);
            do
            {
                Console.WriteLine(StaticMessages.PossibleCommands);
                string command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case ConstantsCommands.HELP:
                        Console.WriteLine(StaticMessages.HelpCommand);
                        break;
                    case ConstantsCommands.ADD:
                        string inputRole;
                        PropertiesDataCapture.InputRole(out inputRole);
                        IBaseService employeeService = Factory.CreateRoleService(inputRole);
                        if (!ConsoleValidation.CheckRoleInstance(employeeService)) break;
                        employeeService.AddEmployeeService();
                        break;
                    case ConstantsCommands.REMOVE:
                        string inputId;
                        int id;
                        PropertiesDataCapture.InputRemoveId(out inputId, out id);
                        if (!ConsoleValidation.Exit(inputId)) break;
                        employeeservice.RemoveEmployeeService(id);
                        break;
                    case ConstantsCommands.DISPLAY:
                        employeeservice.DisplayAllEmployees();
                        break;
                    case ConstantsCommands.LIST:
                        employeeservice.DisplayEmployeesWithoutCEO();
                        break;
                    case ConstantsCommands.ROLELIST:
                        string outputRole;
                        PropertiesDataCapture.InputRole(out outputRole);
                        employeeservice.ListByRole(outputRole);
                        break;
                    default:
                        Console.WriteLine(StaticMessages.NonExistentCommandMessage);
                        break;
                }
            } while (true);
        }
    }
 }

