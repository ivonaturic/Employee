using Employee.Roles;
using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    internal class EmployeeDeveloperService : EmployeeBaseService<Developer>
    {
        private readonly IStorage<Developer> _storage;

        public EmployeeDeveloperService(IStorage<Developer> storage) : base(storage)
        {
            _storage = storage;
        }
    }
}
