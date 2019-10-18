using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Core.Models.Department;

namespace ServiceLayer.Core.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        void ValidateModel(IDepartmentModel departmentModel);
        void ValidateModelFluentBuilder(IDepartmentModel departmentModel);
        void ValidateDepartmentID(IDepartmentModel departmentModel);
        void ValidateDepartmentName(IDepartmentModel departmentModel);
        void ValidateDepartmentUrl(IDepartmentModel departmentModel);
        void ValidateDepartmentPhoneNumber(IDepartmentModel departmentModel);
        void ValidateDepartmentEmail(IDepartmentModel departmentModel);
        void ValidateDepartmentCityLocation(IDepartmentModel departmentModel);
        void ValidateDepartmentStateLocation(IDepartmentModel departmentModel);
    }
}
