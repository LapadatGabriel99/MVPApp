using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Views;

namespace PresentationLayer.Core.Presenters
{
    public interface IHelpAboutPresenter : IPresenter
    {
        IHelpAboutView HelpAboutView { get; }
        void OnHelpAboutViewLoadEventRaised(object sender, EventArgs e);
        void ReinstanciateHelpAboutView();
        void OnHelpAboutViewFormClosedEventRaised(object sender, EventArgs e);
    }
}
