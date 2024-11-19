using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Roles;
using Employee.Storage;

namespace Employee.Services
{
    public class EmployeeCEOService : EmployeeBaseService<CEO>
    {
        private readonly IStorage<CEO> _storage;

        public EmployeeCEOService(IStorage<CEO> storage) : base(storage) 
        {
            _storage = storage;
        }
        public override void AddEmployeesService(CEO entity)
        {
            base.AddEmployeesService(entity);
        }
        public override void RemoveEmployeesService(CEO entity)
        {
            base.RemoveEmployeesService(entity);
        }
    }
}
