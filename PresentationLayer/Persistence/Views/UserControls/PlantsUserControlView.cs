using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Core.Views.UserControls;
using PresentationLayer.Core.Common.Layout;
using CommonComponents.Presentation;
using PresentationLayer.Persistence.Common.Layout;
using PresentationLayer.Persistence.Common.Layout.Docking;

namespace PresentationLayer.Persistence.Views.UserControls
{
    public sealed partial class PlantsUserControlView : UserControl, IPlantsUserControlView
    {
        public event EventHandler UserControlViewLoadingEventRaised;

        private static readonly PlantsUserControlView _instance = new PlantsUserControlView();
        private ILayout _layout;

        static PlantsUserControlView()
        {

        }
        private PlantsUserControlView()
        {
            InitializeComponent();
        }

        public static PlantsUserControlView Instance
        {
            get
            {
                return _instance;
            }
        }

        public new ILayout Layout
        {
            get { return _layout; }
            set { _layout = value; }
        }

        public void ShowUserControl()
        {
            this.BringToFront();
            //this.Show();                
        }

        public void InitializeUserControlLayout()
        {
            _layout = new Layout(new ControlDocking());
        }
        public void SetUserControlDockingToDockStyleFill()
        {
            _layout.ControlDocking.SetDockToFill<Control>((Control)this);
        }

        private void PlantsUserControlView_Load(object sender, EventArgs e)
        {
            EventHelper.RaisedEvent(this, UserControlViewLoadingEventRaised, e);
        }
    }
}
