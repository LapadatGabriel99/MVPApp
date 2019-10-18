using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Core;
using ServiceLayer.Core.Services.DepartmentServices;

namespace ServiceLayer.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDepartmentServices DepartmentServices { get ; set ; }
        public IThrowingExceptionsForUnitTests ExceptionsForUnitTests { get ; set ; }

        public UnitOfWork(IDepartmentServices departmentServices, IThrowingExceptionsForUnitTests exceptionsForUnitTests)
        {
            DepartmentServices = departmentServices;
            ExceptionsForUnitTests = exceptionsForUnitTests;
        }
    }
}
