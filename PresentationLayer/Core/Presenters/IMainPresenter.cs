using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Views;
using System.Windows.Forms;
using PresentationLayer.Core.Common;

namespace PresentationLayer.Core.Presenters
{
    public interface IMainPresenter
    {
        IMainView MainView { get; }

        IList<IUserControl> UserControlList { get; }

        void OnHelpAboutMenuClickEventRaised(object sender, EventArgs e);
        void OnMainViewLoadingEventRaised(object sender, EventArgs e);
    }
}
