using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Roles;
using Employee.Storage;

namespace Employee.Services
{
    public interface IEmployeeBaseService
    {
        void AddEmployeesService();
        void RemoveEmployeesService(int id);
        IEnumerable<IEmployeeBase> DisplayAllEmployees();
        IEnumerable<IEmployeeBase> DisplayEmployeesWithoutCEO();
        IEnumerable<IEmployeeBase> ListByRole(string role);
    }
}
