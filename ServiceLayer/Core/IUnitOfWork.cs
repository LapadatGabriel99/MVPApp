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
        IDepartmentServices DepartmentServices { get; set; }
        IThrowingExceptionsForUnitTests ExceptionsForUnitTests { get; set; } 
    }
}
