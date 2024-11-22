using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Roles;
using Employee.Storage;

namespace Employee.Services
{
    public interface IEmployeeBaseService<T> where T : EmployeeBase
    {
        void AddEmployeesService();
        void RemoveEmployeesService(int id);
        IEnumerable<T> DisplayAllEmployees();
        IEnumerable<T> DisplayEmployeesWithoutCEO();
        IEnumerable<T> ListByRole(string role);
    }
}
