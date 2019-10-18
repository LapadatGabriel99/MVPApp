using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Core.Validations;

namespace RepositoryLayer.Persistence.Validations
{
    public class AdditionalValidForString : IAdditionalValidChecksForString
    {
        public bool BeAValid(string variable)
        {
            return variable.All(char.IsLetter);
        }

        public bool BeAValidName(string name)
        {
            name = name.Replace(" ","");
            name = name.Replace("-", "");            

            return this.BeAValid(name);
        }

        public bool BeAValidCityLocation(string cityLocation)
        {           
            return this.BeAValidName(cityLocation);
        }

        public bool BeAValidStateLocation(string stateLocation)
        {
            return this.BeAValid(stateLocation);
        }
    }
}
