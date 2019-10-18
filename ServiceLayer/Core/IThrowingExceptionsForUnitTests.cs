using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Core
{
    public interface IThrowingExceptionsForUnitTests
    {
        bool CheckIfThereAreAnyValidationFails(Func<bool> predicate);
        void ThrowExceptionIfAnyValidationFails(Func<bool> predicate);
    }
}
