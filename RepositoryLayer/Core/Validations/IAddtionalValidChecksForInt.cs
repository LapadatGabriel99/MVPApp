﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Core.Validations
{
    public interface IAddtionalValidChecksForInt : IAdditionalValidChecks<string>
    {
        bool BeAValidID(int iD);
    }
}