using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Presenters.UserControls;
using PresentationLayer.Core.Views.UserControls;

namespace PresentationLayer.Persistence.Presenters.UserControls
{
    public class NewsUserControlPresenter : INewsUserControlPresenter
    {
        private INewsUserControlView _newsUserControlView;

        public NewsUserControlPresenter()
        {

        }

        public NewsUserControlPresenter(INewsUserControlView newsUserControlView)
        {
            _newsUserControlView = newsUserControlView;
        }

        public INewsUserControlView GetNewsUserControlView { get { return _newsUserControlView; } }
    }
}
