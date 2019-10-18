using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Core.Models.Department;
using ServiceLayer.Core.Services.DepartmentServices;
using ServiceLayer.Core.CommonServices;
using ServiceLayer.Persistence.CommonServices;
using RepositoryLayer.Persistence.Validations;
using System.ComponentModel;
using System.IO;

namespace ServiceLayer.Persistence.Services.DepartmentServices
{
    public class DepartmentServices : IDepartmentServices, ICheckForValidationFails
    {
        private IModelValidationCheck _modelValidationCheck;
        private BindingList<string> ErrorCodes { get; set; }//when unit testing reffer to Count.
        private BindingList<string> ErrorMessages { get; set; }//same here

        private int ErrorCount
        {
            get
            {
                if (ErrorCodes.Count + ErrorMessages.Count > 0)
                    return ErrorCodes.Count + ErrorMessages.Count;
                else
                    return 0;
            }
        }

        public DepartmentServices()
        {
            _modelValidationCheck = new ModelValidationCheck();
            _experimentalBuilder = new BindingList<string>();          
        }

        public void ValidateModel(IDepartmentModel departmentModel)
        {
            this.ValidateModelFluentBuilder(departmentModel);
            if (CheckIfValidationIsTrueFluentBuilder(_modelValidationCheck.IsValidationFalse))
            {
                ErrorCodes = _modelValidationCheck.Errors["ErrorCode"];
                ErrorMessages = _modelValidationCheck.Errors["ErrorMessage"];

                this.ResetModelValidationChecksErrors();
            }
        }

        public void ValidateModelFluentBuilder(IDepartmentModel departmentModel)
        {
            _modelValidationCheck.ValidateModelFluentBuilder<IDepartmentModel>(departmentModel,new DepartmentValidation());            
        }

        #region Experimental Api

        private BindingList<string> _experimentalBuilder;

        public void ValidateDepartmentCityLocation(IDepartmentModel departmentModel)
        {
            var checks = new AdditionalValidChecks(new AdditionalValidForInt(), new AdditionalValidForString());

            string cityLocation = departmentModel.CityLocation;

            if(!checks.ForString.BeAValidCityLocation(cityLocation))
            {
                _experimentalBuilder.Add("Department city location is in wrong format.");                
            }
        }

        public void ValidateDepartmentEmail(IDepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public void ValidateDepartmentID(IDepartmentModel departmentModel)
        {
            var checks = new AdditionalValidChecks(new AdditionalValidForInt(), new AdditionalValidForString());

            int iD = departmentModel.ID;

            if(!checks.ForInt.BeAValidID(iD))
            {
                _experimentalBuilder.Add("Department iD is in wrong format.");
            }
        }

        public void ValidateDepartmentName(IDepartmentModel departmentModel)
        {
            var checks = new AdditionalValidChecks(new AdditionalValidForInt(), new AdditionalValidForString());

            string name = departmentModel.Name;

            if(!checks.ForString.BeAValidName(name))
            {
                _experimentalBuilder.Add("Department name is in wrong format.");
            }
        }

        public void ValidateDepartmentPhoneNumber(IDepartmentModel departmentModel)
        {

        }

        public void ValidateDepartmentStateLocation(IDepartmentModel departmentModel)
        {
            var checks = new AdditionalValidChecks(new AdditionalValidForInt(), new AdditionalValidForString());

            string stateLocation = departmentModel.StateLocation;

            if(!checks.ForString.BeAValidStateLocation(stateLocation))
            {
                _experimentalBuilder.Add("Department state location is in wrong format.");
            }
        }

        public void ValidateDepartmentUrl(IDepartmentModel departmentModel)
        {
            Uri uriAddress = new Uri(departmentModel.Url);

            string domainExtension = Path.GetExtension(uriAddress.Host).Trim().ToLower();

            if(!".com .net".Contains(domainExtension))
            {
                _experimentalBuilder.Add("Department Url has to contain .com or .net extensions.");
            }

            if(departmentModel.Url.Length <7 || departmentModel.Url.Length > 30)
            {
                _experimentalBuilder.Add("Department Url has to be between 7 and 30 characters.");
            }

            if(uriAddress.GetLeftPart(UriPartial.Scheme) != "http://")
            {
                _experimentalBuilder.Add("Department Url must only have http:// protocol.");
            }

            //if(!"http:// ftp://".Contains(uriAddress.GetLeftPart(UriPartial.Scheme)))
            //{
            //    //***
            //}            
        }

        public IEnumerable<string> GetExperimentalBuilder()
        {
            foreach (var str in _experimentalBuilder)
            {
                yield return str;
            }
        }

        #endregion

        private bool CheckIfValidationIsTrueFluentBuilder(bool answer)
        {
            return answer;
        }

        private void ResetModelValidationChecksErrors()
        {
            _modelValidationCheck.IsValidationFalse = false;
            _modelValidationCheck.Errors["ErrorCode"].Clear();
            _modelValidationCheck.Errors["ErrorMessage"].Clear();
        }

        public IEnumerable<string> GetErrorCodes()
        {
            foreach (var errorCode in ErrorCodes)
            {
                yield return errorCode;
            }
        }

        public IEnumerable<string> GetErrorMessage()
        {
            foreach (var errorMessage in ErrorMessages)
            {
                yield return errorMessage;
            }
        }

        public bool CheckIfAnyValidationFails()
        {
            if(ErrorCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
