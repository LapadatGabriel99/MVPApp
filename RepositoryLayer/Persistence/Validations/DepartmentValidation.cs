using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using DomainLayer.Models.Department;
using DomainLayer.Core.Models.Department;

namespace RepositoryLayer.Persistence.Validations
{
    public class DepartmentValidation : AbstractValidator<IDepartmentModel>, IValidation
    {
        public Action AddValidation { get; private set; }
        private AdditionalValidChecks _haveValidChecks;

        public DepartmentValidation()
        {
            _haveValidChecks = new AdditionalValidChecks(new AdditionalValidForInt(), new AdditionalValidForString());
            ApplyValidations();
        }

        private void ValidateID()
        {
            RuleFor(d => d.ID)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("This property cannot be null.")
                .NotEmpty()
                .WithMessage("Department ID is required.")
                .Must(_haveValidChecks.ForInt.BeAValidID)
                .WithMessage("Department ID conteins invalid characters");                
        }

        private void ValidateName()
        {
            RuleFor(d => d.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("This property cannot be null.")
                .NotEmpty()
                .WithMessage("Department name is required.")
                .Length(2, 50)
                .WithMessage("Department name must be between 2 and 50 characters")
                .Must(_haveValidChecks.ForString.BeAValidName)
                .WithMessage("Department name contains invalid characters");
        }

        private void ValidateUrl()
        {
            RuleFor(d => d.Url)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("This property cannot be null.")
                .NotEmpty()
                .WithMessage("Department url is required.")
                .Matches(@"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$")
                .WithMessage("Url format is invalid.");
        }

        private void ValidatePhoneNumber()
        {
            RuleFor(d => d.Url)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("This property cannot be null.")
                .NotEmpty()
                .WithMessage("Department phone number is required.")
                .Matches(@"(\+[0-9]{2}|\+[0-9]{2}\(0\)|\(\+[0-9]{2}\)\(0\)|00[0-9]{2}|0)([0-9]{9}|[0-9\-\s]{9,18})")
                .WithMessage("Phone number format is invalid.");
        }

        private void ValidateEmail()
        {
            RuleFor(d => d.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("This property cannot be null.")
                .NotEmpty()
                .WithMessage("Department email is required.")
                .Matches(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")
                .WithMessage("Email format is invalid.");
        }

        private void ValidateCityLocation()
        {
            RuleFor(d => d.CityLocation)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("This property cannot be null.")
                .NotEmpty()
                .WithMessage("Department city location is required.")
                .Length(2, 50)
                .WithMessage("Department city location must be between 2 and 50 characters.")
                .Must(_haveValidChecks.ForString.BeAValidCityLocation)
                .WithMessage("Department city location contains invalid characters");
        }

        private void ValidateStateLocation()
        {
            RuleFor(d => d.StateLocation)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("This property cannot be null.")
                .NotEmpty()
                .WithMessage("Department state location is required.")
                .Length(2, 50)
                .WithMessage("Department state location must be between 2 and 50 characters.")
                .Must(_haveValidChecks.ForString.BeAValidStateLocation)
                .WithMessage("Department state location contains invalid characters");
        }

        private void ApplyValidations()
        {
            AddValidation += ValidateID;
            AddValidation += ValidateName;
            AddValidation += ValidateUrl;
            AddValidation += ValidatePhoneNumber;
            AddValidation += ValidateEmail;
            AddValidation += ValidateCityLocation;
            AddValidation += ValidateStateLocation;
            AddValidation.Invoke();
        }
    }
}
