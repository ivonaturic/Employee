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
            var ceo = _storage.AllEmployees().Where(e => e.GetType().Name == "CEO");
            if (ceo.Any())
            {
                Console.WriteLine("CEO already exists, there can only be one!");
                return;
            }
            else
            {
                base.AddEmployeesService(entity);
            }
        }
    }
}
