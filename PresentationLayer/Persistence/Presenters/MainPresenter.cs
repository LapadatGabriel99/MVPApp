using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Presenters;
using PresentationLayer.Core.Views;
using PresentationLayer;
using PresentationLayer.Core.Dependencies;
using PresentationLayer.Core.Presenters.UserControls;
using PresentationLayer.Core.Common;

namespace PresentationLayer.Persistence.Presenters
{
    public class MainPresenter : IMainPresenter, IMainViewDependency 
    {        
        private IMainView _mainView;
        private IHelpAboutPresenter _helpAboutPresenter;
        private IDeparmentsUserControlPresenter _deparmentsUserControlPresenter;
        private INewsUserControlPresenter _newsUserControlPresenter;
        private IPlantsUserControlPresenter _plantsUserControlPresenter;

        public IList<IUserControl> UserControlList { get; private set; }

        public MainPresenter()
        {
            UserControlList = new List<IUserControl>();            
        }

        public MainPresenter(IMainView mainView): this()
        {
            _mainView = mainView;
            SubscribeToEventsSetup();
        }

        public MainPresenter(IMainView mainView, IHelpAboutPresenter helpAboutPresenter): this(mainView)
        {
            _helpAboutPresenter = helpAboutPresenter;            
        }
        
        public MainPresenter(IMainView mainView, IHelpAboutPresenter helpAboutPresenter, IDeparmentsUserControlPresenter deparmentsUserControlPresenter): 
            this(mainView, helpAboutPresenter)
        {
            _deparmentsUserControlPresenter = deparmentsUserControlPresenter;
        }

        public MainPresenter(IMainView mainView, IHelpAboutPresenter helpAboutPresenter, IDeparmentsUserControlPresenter deparmentsUserControlPresenter, 
            INewsUserControlPresenter newsUserControlPresenter): this(mainView, helpAboutPresenter, deparmentsUserControlPresenter)
        {
            _newsUserControlPresenter = newsUserControlPresenter;
        }

        public MainPresenter(IMainView mainView, IHelpAboutPresenter helpAboutPresenter, IDeparmentsUserControlPresenter deparmentsUserControlPresenter,
            INewsUserControlPresenter newsUserControlPresenter, IPlantsUserControlPresenter plantsUserControlPresenter):
                this(mainView, helpAboutPresenter, deparmentsUserControlPresenter, newsUserControlPresenter)
        {
            _plantsUserControlPresenter = plantsUserControlPresenter;
            FillUserControlList();
        }

        public IMainView MainView { get { return _mainView ; } }

        public void SetDependency(IMainView mainView)
        {
            _mainView = mainView;
        }

        private void SubscribeToEventsSetup()
        {
            _mainView.HelpAboutMenuClickEventRaised += new EventHandler(OnHelpAboutMenuClickEventRaised);
            _mainView.MainViewLoadingEventRaised += new EventHandler(OnMainViewLoadingEventRaised);
            _mainView.NewsButtonClickEventRaised += new EventHandler(OnNewsButtonClickEventRaised);
            _mainView.PlantListButtonClickEventRaised += new EventHandler(OnPlantsButtonClickEventRaised);
            _mainView.DepartmentListButtonClickEventRaised += new EventHandler(OnDepartmentsButtonClickEventRaised);
        }

        private void FillUserControlList()
        {
            UserControlList.Add(_deparmentsUserControlPresenter.GetDepartmentsUserControlView);
            UserControlList.Add(_newsUserControlPresenter.GetNewsUserControlView);
            UserControlList.Add(_plantsUserControlPresenter.GetPlantsUserControlView);
        }

        public void OnHelpAboutMenuClickEventRaised(object sender, EventArgs e)
        {
            _helpAboutPresenter.HelpAboutView.ShowHelpAboutView();
        }

        public void OnMainViewLoadingEventRaised(object sender, EventArgs e)
        {
            _mainView.AddUserControlsToUserControlViewPanel((List<IUserControl>)UserControlList);
            _mainView.SetUnderlineLabelStartingLocation();
            _mainView.DisplayUserControlOnUserControlViewPanel(_newsUserControlPresenter.GetNewsUserControlView);
            _mainView.ChangeMainViewStartPosition();
            _mainView.ShowMainView();
        }
        
        public void OnNewsButtonClickEventRaised(object sender, EventArgs e)
        {
            _mainView.ChangeUnderlineLabelLocation(_mainView.NewsButton);
            _mainView.DisplayUserControlOnUserControlViewPanel(_newsUserControlPresenter.GetNewsUserControlView);
        }

        public void OnPlantsButtonClickEventRaised(object sender, EventArgs e)
        {
            _mainView.ChangeUnderlineLabelLocation(_mainView.PlantsButton);
            _mainView.DisplayUserControlOnUserControlViewPanel(_plantsUserControlPresenter.GetPlantsUserControlView);
        }

        public void OnDepartmentsButtonClickEventRaised(object sender, EventArgs e)
        {
            _mainView.ChangeUnderlineLabelLocation(_mainView.DepartmentsButton);
            _mainView.DisplayUserControlOnUserControlViewPanel(_deparmentsUserControlPresenter.GetDepartmentsUserControlView);
        }
    }
}
