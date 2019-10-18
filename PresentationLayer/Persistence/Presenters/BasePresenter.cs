using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Presenters;
using PresentationLayer.Core.Views;
using PresentationLayer.Persistence.Views;

namespace PresentationLayer.Persistence.Presenters
{
    public class BasePresenter : IBasePresenter
    {
        private IErrorMessageView _errorMessageView;

        public BasePresenter()
        {

        }

        public BasePresenter(IErrorMessageView errorMessageView)
        {
            _errorMessageView = errorMessageView;
        }

        public void ShowErrorMessage(string windowTitle, string errorMessage)
        {
            //Left TODO
            _errorMessageView.ShowErrorMessageView(windowTitle, errorMessage);
        }

        public IErrorMessageView ErrorMessageView { get { return _errorMessageView as ErrorMessageView; } }
    }
}
