using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common;
using PresentationLayer.Core.Views.UserControls;

namespace PresentationLayer.Core.Presenters.UserControls
{
    public interface INewsUserControlPresenter 
    {
        INewsUserControlView GetNewsUserControlView { get; }

        void OnNewsUserControlViewLoadingEventRaised(object sender, EventArgs e);
    }
}
