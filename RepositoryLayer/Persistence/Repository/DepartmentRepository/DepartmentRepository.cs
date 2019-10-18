using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;
using RepositoryLayer.Core.Repository.DepartmentRepository;

namespace RepositoryLayer.Persistence.Repository.DepartmentRepository
{
    public class DepartmentRepository : Repository<DepartmentModel>, IDepartmentRepository
    {
        public Context Context { get; private set; }

        public DepartmentRepository(Context context)
            :base(context)
        {
            Context = _context as Context;
        }

        public IEnumerable<DepartmentModel> GetDepartmentModelsByCityAndState(string cityLocation, string stateLocation)
        {
            return Context.Departments.Where(d => d.CityLocation.Equals(cityLocation) && d.StateLocation.Equals(stateLocation)).ToList();
        }

        public IEnumerable<DepartmentModel> GetDepartmentModelsByCityLocation(string cityLocation)
        {
            return Context.Departments.Where(d => d.CityLocation.Equals(cityLocation)).ToList();
        }

        public IEnumerable<DepartmentModel> GetDepartmentModelsByStateLocation(string stateLocation)
        {
            return Context.Departments.Where(d => d.StateLocation.Equals(stateLocation)).ToList();
        }
    }
}
