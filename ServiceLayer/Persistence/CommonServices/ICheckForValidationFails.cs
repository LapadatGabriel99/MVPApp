using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Persistence.CommonServices
{
    public interface ICheckForValidationFails
    {
        bool CheckIfAnyValidationFails();
    }
}
