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
            StandardMessages.WelcomeMessage();
            IBaseModel employee = new BaseModel();
            IBaseService employeeservice = new BaseService<IBaseModel>(employee);
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
                        string roleforinput;
                        PropertiesDataCapture.AddEmployeeRole(out roleforinput);
                        IBaseService employeeService = Factory.CreateRoleService(roleforinput);
                        if (!ConsoleValidation.RoleType(employeeService)) break;
                        employeeService.AddEmployeesService();
                        break;
                    case ConstantsCommands.REMOVE:
                        string inputId;
                        int id;
                        PropertiesDataCapture.EnterRemoveId(out inputId, out id);
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
                        string roleforoutput;
                        PropertiesDataCapture.RoleForRoleList(out roleforoutput);
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

