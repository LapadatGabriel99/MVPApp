using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Core;

namespace ServiceLayer.Persistence
{
    public class ThrowingExceptionsForUnitTests : IThrowingExceptionsForUnitTests
    {
        public bool CheckIfThereAreAnyValidationFails(Func<bool> predicate)
        {
            return predicate.Invoke();
        }

        public void ThrowExceptionIfAnyValidationFails(Func<bool> predicate)
        {
            if(predicate.Invoke())
            {
                throw new NotImplementedException();
            }
        }
    }
}
