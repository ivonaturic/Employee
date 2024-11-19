using Employee.Roles;
using Employee.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    internal class EmployeeDesignerService : EmployeeBaseService<Designer>
    {
        private readonly IStorage<Designer> _storage;

        public EmployeeDesignerService(IStorage<Designer> storage) : base(storage) 
        {
            _storage = storage;
        }
    }
}
