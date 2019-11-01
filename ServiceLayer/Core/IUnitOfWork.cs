using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Core.Models.Department;
using ServiceLayer.Core.Services.DepartmentServices;

namespace ServiceLayer.Core
{
    public interface IUnitOfWork
    {
        RepositoryLayer.Core.IUnitOfWork RepositoryUnitOfWork { get; set; }
        IDepartmentServices DepartmentServices { get; set; }
        IThrowingExceptionsForUnitTests ExceptionsForUnitTests { get; set; } 
    }
}
