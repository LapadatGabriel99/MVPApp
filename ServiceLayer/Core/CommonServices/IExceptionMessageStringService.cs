using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Core.CommonServices
{
    public interface IExceptionMessageStringService
    {
        string CreateExceptionMessage(Exception ex);
    }
}
