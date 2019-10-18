using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Core.Validations;

namespace RepositoryLayer.Persistence.Validations
{
    public class AdditionalValidChecks 
    {
        public IAdditionalValidChecksForString ForString { get; set; }
        public IAddtionalValidChecksForInt ForInt { get; set; }

        public AdditionalValidChecks(IAddtionalValidChecksForInt forInt, IAdditionalValidChecksForString forString)
        {
            ForString = forString;
            ForInt = forInt;
        }
    }
}
