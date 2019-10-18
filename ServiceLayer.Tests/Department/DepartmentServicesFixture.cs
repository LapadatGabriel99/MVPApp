using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Core.Models.Department;
using ServiceLayer.Persistence;
using DomainLayer.Models.Department;
using ServiceLayer.Core.Services.DepartmentServices;
using ServiceLayer.Persistence.Services.DepartmentServices;

namespace ServiceLayer.Tests.Department
{
    internal class DepartmentServicesFixture
    {
        private IDepartmentServices _departmentServices;
        private IDepartmentModel _departmentModel;

        public DepartmentServicesFixture(UnitOfWork unitOfWork)
        {
            _departmentServices = unitOfWork.DepartmentServices;
            _departmentModel = new DepartmentModel();
        }

        public DepartmentModel DepartmentModel
        {
            get { return _departmentModel as DepartmentModel; }
            set { _departmentModel = value; }
        }

        public DepartmentServices DepartmentServices
        {
            get { return _departmentServices as DepartmentServices; }
            set { _departmentServices = value; }
        }
    }
}
