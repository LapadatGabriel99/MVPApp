using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.ComponentModel;

namespace ServiceLayer.Core.CommonServices
{
    interface IModelValidationCheck
    {
        IDictionary<string, BindingList<string>> Errors { get; }
        bool IsValidationFalse { get; set; }
        void ValidateModelFluentBuilder<TDomainModel>(TDomainModel domainModel, AbstractValidator<TDomainModel> validator);
    }
}
