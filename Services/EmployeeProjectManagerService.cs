using Employee.Roles;
using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    internal class EmployeeProjectManagerService : EmployeeBaseService<ProjectManager>
    {
        private readonly IStorage<ProjectManager> _storage;

        public EmployeeProjectManagerService(IStorage<ProjectManager> storage) : base(storage)
        {
            _storage = storage;
        }
    }
}
