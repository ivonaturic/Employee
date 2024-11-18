using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Storage;

namespace Employee.Services
{
    public interface IEmployeeBaseService<T>
    {
        void AddEmployeesService(T entity);
        void RemoveEmployeesService(T entity);
        IEnumerable<T> DisplayAllEmployees();
        IEnumerable<T> DisplayEmployeesWithoutCEO();
        IEnumerable<T> ListByRole(string role);
    }
}
