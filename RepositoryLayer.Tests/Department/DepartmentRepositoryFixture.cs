using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Core.Models.Department;
using RepositoryLayer.Core.Repository.DepartmentRepository;
using RepositoryLayer.Core;
using DomainLayer.Models.Department;
using RepositoryLayer.Persistence.Repository.DepartmentRepository;

namespace RepositoryLayer.Tests.Department
{
    internal class DepartmentRepositoryFixture
    {
        IDepartmentRepository _departmentRepository;
        IDepartmentModel _departmentModel;

        public DepartmentRepositoryFixture(IUnitOfWork unitOfWork)
        {
            _departmentRepository = unitOfWork.Departments;
            _departmentModel = new DepartmentModel();
        }

        public DepartmentModel DepartmentModel
        {
            get { return _departmentModel as DepartmentModel; }
            set { _departmentModel = value; }
        }

        public DepartmentRepository DepartmentRepository
        {
            get { return _departmentRepository as DepartmentRepository; }
            set { _departmentRepository = value; }
        }
    }
}
