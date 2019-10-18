using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Views;
using PresentationLayer.Core.Presenters;
using PresentationLayer.Persistence.Views;
using System.Reflection;
using System.Threading;

namespace PresentationLayer.Persistence.Presenters
{
    public class HelpAboutPresenter : IHelpAboutPresenter
    {
        private IHelpAboutView _helpAboutView;

        public HelpAboutPresenter(IHelpAboutView helpAboutView)
        {
            _helpAboutView = helpAboutView;
            SubscribeToEventsSetup();
        }

        public void ReinstanciateHelpAboutView()
        {
            _helpAboutView = new HelpAboutView();
            //TODO try working with the main presenter
        }

        public IHelpAboutView HelpAboutView
        {
            get { return _helpAboutView; }
        }

        private void SubscribeToEventsSetup()
        {
            _helpAboutView.HelpAboutViewLoadingEventRaised += new EventHandler(OnHelpAboutViewLoadEventRaised);
            _helpAboutView.HelpAboutViewFormClosedEventRaised += new EventHandler(OnHelpAboutViewFormClosedEventRaised);
        }

        public void OnHelpAboutViewLoadEventRaised(object sender, EventArgs e)
        {
            _helpAboutView.SetValues(AssemblyTitle(), AssemblyProduct(), AssemblyVersion(), AssemblyCopyright(), AssemblyCompany(), AssemblyDescription());
            _helpAboutView.ChangeHelpAboutViewStartLocationToCenterScreen();
        }

        public void OnHelpAboutViewFormClosedEventRaised(object sender, EventArgs e)
        {
            ReinstanciateHelpAboutView();
            OnHelpAboutViewLoadEventRaised(sender, e);
        }

        private string AssemblyTitle()
        {
            dynamic attribute = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false).First();
            return attribute.Title;
        }

        private string AssemblyProduct()
        {
            dynamic attribute = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false).First();
            return attribute.Product;
        }

        private string AssemblyVersion()
        {
            var versionName = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            return versionName;
        }

        private string AssemblyCopyright()
        {
            dynamic attribute = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false).First();
            return attribute.Copyright;
        }

        private string AssemblyCompany()
        {
            dynamic attribute = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false).First();
            return attribute.Company;
        }

        private string AssemblyDescription()
        {
            dynamic attribute = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false).First();
            return attribute.Description;
        }

        private void InitiateMaintananceThread()
        {
            Thread thread = new Thread(CheckToSeeIfMainViewIsNull) { IsBackground = false };
            thread.Start();
            
        }

        private void CheckToSeeIfMainViewIsNull()
        {
            while(true)
            {
                if(_helpAboutView == null)
                {
                    ReinstanciateHelpAboutView();
                    break;
                }
            }
        }
    }
}
