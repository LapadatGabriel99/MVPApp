using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Core.CommonServices;
using DomainLayer.Models.Department;
using RepositoryLayer.Core.Repository.DepartmentRepository;
using RepositoryLayer.Core;

namespace ServiceLayer.Core.Services.DepartmentServices
{
    public interface IDepartmentCrudOperations : ICrudOperations<DepartmentModel>
    {
         IDepartmentRepository GetDepartmentModel { get; }
         
         IDataTransaction GetDataTransaction { get; }
    }
}
