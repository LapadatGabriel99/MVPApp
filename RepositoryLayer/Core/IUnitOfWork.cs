using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Core.Repository.DepartmentRepository;

namespace RepositoryLayer.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IDataTransaction Transaction { get; set; }
        IDepartmentRepository Departments { get; set; }
        int Complete();
    }
}
