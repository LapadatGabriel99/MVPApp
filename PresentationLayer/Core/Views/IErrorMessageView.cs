using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Core.Views
{
    public interface IErrorMessageView
    {
        void ShowErrorMessageView(string windowTitle, string errorMessage);
    }
}
