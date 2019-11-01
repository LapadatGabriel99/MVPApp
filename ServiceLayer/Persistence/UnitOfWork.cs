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
        private RepositoryLayer.Core.IUnitOfWork _repositoryUnitOfWork;

        public RepositoryLayer.Core.IUnitOfWork RepositoryUnitOfWork
        {
            get { return _repositoryUnitOfWork; }
            set { _repositoryUnitOfWork = value; }
        }
        public IDepartmentServices DepartmentServices { get ; set ; }
        public IThrowingExceptionsForUnitTests ExceptionsForUnitTests { get ; set ; }

        public UnitOfWork(RepositoryLayer.Core.IUnitOfWork repositoryUnitOfWork)
        {
            _repositoryUnitOfWork = repositoryUnitOfWork;
        }

        public UnitOfWork(IDepartmentServices departmentServices, IThrowingExceptionsForUnitTests exceptionsForUnitTests)            
        {
            DepartmentServices = departmentServices;
            ExceptionsForUnitTests = exceptionsForUnitTests;
        }
    }
}
