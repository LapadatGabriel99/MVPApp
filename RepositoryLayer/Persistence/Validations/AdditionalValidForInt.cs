using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Core.Validations;

namespace RepositoryLayer.Persistence.Validations
{
    public class AdditionalValidForInt : IAddtionalValidChecksForInt
    {
        public bool BeAValid(string variable)
        {
            return variable.All(char.IsNumber);
        }

        public bool BeAValidID(int iD)
        {
            string aux = iD.ToString();

            aux = aux.Replace(" ", "");
            aux = aux.Replace("-", "");
            aux = aux.Replace("_", "");

            return this.BeAValid(aux);
        }
    }
}
