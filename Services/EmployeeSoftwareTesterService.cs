using Employee.Roles;
using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    internal class EmployeeSoftwareTesterService : EmployeeBaseService<SoftwareTester>
    {
        private readonly IStorage<SoftwareTester> _storage;

        public EmployeeSoftwareTesterService(IStorage<SoftwareTester> storage) : base(storage)
        {
            _storage = storage;
        }
        
    }
}
