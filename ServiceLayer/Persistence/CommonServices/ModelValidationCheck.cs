using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Core.CommonServices;
using RepositoryLayer.Persistence.Validations;
using FluentValidation;
using FluentValidation.Results;
using FluentValidation.Resources;
using System.ComponentModel;

namespace ServiceLayer.Persistence.CommonServices
{
    public class ModelValidationCheck : IModelValidationCheck
    {
        public IDictionary<string, BindingList<string>> Errors { get; private set; }
        public bool IsValidationFalse { get;  set; }

        public ModelValidationCheck()
        {
            Errors = new Dictionary<string, BindingList<string>>();
            Errors.Add("ErrorCode", new BindingList<string>());
            Errors.Add("ErrorMessage", new BindingList<string>());

            IsValidationFalse = false;
        }

        public void ValidateModelFluentBuilder<TDomainModel>(TDomainModel domainModel, AbstractValidator<TDomainModel> validator)
        {                       
            ValidationResult validationResult = validator.Validate(domainModel);

            if(!validationResult.IsValid)
            {
                IsValidationFalse = true;

                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    if(failure.ErrorCode.Length != 0)
                    {
                        Errors["ErrorCode"].Add($"{ failure.PropertyName }: { failure.ErrorCode }");
                    }
                    else
                    {
                        Errors["ErrorMessage"].Add($"{ failure.PropertyName }: { failure.ErrorMessage }");
                    }
                }                
            }
        }
    }
}
