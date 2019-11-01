using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common;
using PresentationLayer.Core.Views.UserControls;

namespace PresentationLayer.Core.Presenters.UserControls
{
    public interface IPlantsUserControlPresenter
    {
        IPlantsUserControlView GetPlantsUserControlView { get; }

        void OnPlantsUserControlViewLoadingEventRaised(object sender, EventArgs e);
    }
}
