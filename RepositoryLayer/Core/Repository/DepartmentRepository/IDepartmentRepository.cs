using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;

namespace RepositoryLayer.Core.Repository.DepartmentRepository
{
    public interface IDepartmentRepository : IRepository<DepartmentModel>
    {
        IEnumerable<DepartmentModel> GetDepartmentModelsByStateLocation(string stateLocation);
        IEnumerable<DepartmentModel> GetDepartmentModelsByCityLocation(string cityLocation);
        IEnumerable<DepartmentModel> GetDepartmentModelsByCityAndState(string cityLocation, string stateLocation);

    }
}
