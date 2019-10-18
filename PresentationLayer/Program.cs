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
using PresentationLayer.Persistence.Presenters.UserControls;
using PresentationLayer.Persistence.Views.UserControls;

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
            var departmentUserControlView = DepartmentsUserControlView.Instance;
            var newsUserControlView = NewsUserControlView.Instance;
            var plantsUserControlView = PlantsUserControlView.Instance;
            IMainPresenter mainPresenter = new MainPresenter(mainView, new HelpAboutPresenter(helpAboutView), new DepartmensUserControlPresenter(departmentUserControlView),
                new NewsUserControlPresenter(newsUserControlView), new PlantsUserControlPresenter(plantsUserControlView));
            var secondView = mainPresenter.MainView;            

            Application.Run((MainView)secondView);
        }
    }
}
