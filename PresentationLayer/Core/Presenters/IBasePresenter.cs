using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Core.Presenters
{
    public interface IBasePresenter
    {
        void ShowErrorMessage(string windowTitle, string errorMessage);
    }
}
