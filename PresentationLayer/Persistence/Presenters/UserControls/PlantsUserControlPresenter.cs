using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Presenters.UserControls;
using PresentationLayer.Core.Views.UserControls;

namespace PresentationLayer.Persistence.Presenters.UserControls
{
    public class PlantsUserControlPresenter : IPlantsUserControlPresenter
    {
        private IPlantsUserControlView _plantsUserControlView;

        public PlantsUserControlPresenter()
        {

        }
        
        public PlantsUserControlPresenter(IPlantsUserControlView plantsUserControlView)
        {
            _plantsUserControlView = plantsUserControlView;
        }

        public IPlantsUserControlView GetPlantsUserControlView { get { return _plantsUserControlView; } }

        private void SubscribeToEventsSetup()
        {
            _plantsUserControlView.UserControlViewLoadingEventRaised += new EventHandler(OnPlantsUserControlViewLoadingEventRaised);
        }

        public void OnPlantsUserControlViewLoadingEventRaised(object sender, EventArgs e)
        {
            _plantsUserControlView.InitializeUserControlLayout();
            _plantsUserControlView.SetUserControlDockingToDockStyleFill();
        }
    }
}
