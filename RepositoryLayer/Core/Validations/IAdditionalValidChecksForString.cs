using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Core.Validations
{
    public interface IAdditionalValidChecksForString : IAdditionalValidChecks<string>
    {
        bool BeAValidName(string name);
        bool BeAValidCityLocation(string cityLocation);
        bool BeAValidStateLocation(string stateLocation);
    }
}
