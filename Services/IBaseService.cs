using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Roles;
using Employee.Storage;

namespace Employee.Services
{
    public interface IBaseService
    {
        void AddEmployeeService();
        void RemoveEmployeeService(int id);
        void DisplayAllEmployees();
        void DisplayEmployeesWithoutCEO();
        void ListByRole(string role);
    }
}
