using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Core.Presenters;
using PresentationLayer.Core.Views;
using PresentationLayer.Persistence.Presenters;
using PresentationLayer.Persistence.Views;
using PresentationLayer.Persistence.Common;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var mainView = new MainView(new UnderlineLabelConditions());
            var helpAboutView = new HelpAboutView();
            IMainPresenter mainPresenter = new MainPresenter(mainView, new HelpAboutPresenter(helpAboutView));
            var secondView = mainPresenter.MainView;            

            Application.Run((MainView)secondView);
        }
    }
}
