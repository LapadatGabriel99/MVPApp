using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Core.CommonServices;

namespace ServiceLayer.Persistence.CommonServices
{
    public class ExceptionMessageStringService : IExceptionMessageStringService
    {
        public string CreateExceptionMessage(Exception ex)
        {
            return $"Exception: -{ nameof(ex.Message) }: { ex.Message }\n" +
                    $"\t\t   -{ nameof(ex.Source) }: { ex.Source }\n" +
                    $"\t\t   -{ nameof(ex.TargetSite) }: { ex.TargetSite}\n" +
                    $"\t\t   -{ nameof(ex.HelpLink) }: { ex.HelpLink }";
        }
    }
}
