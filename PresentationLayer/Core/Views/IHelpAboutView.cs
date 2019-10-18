using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Core.Views
{
    public interface IHelpAboutView
    {
        event EventHandler HelpAboutViewLoadingEventRaised;
        event EventHandler HelpAboutViewFormClosedEventRaised;        
        void SetValues(string windowTitle, string productName, string versionName, string copyright, string companyName, string description);
        void ShowHelpAboutView();
        void ChangeHelpAboutViewStartLocationToCenterScreen();
    }
}
