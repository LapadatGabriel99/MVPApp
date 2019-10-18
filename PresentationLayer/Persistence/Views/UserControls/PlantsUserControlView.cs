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


namespace PresentationLayer.Persistence.Views.UserControls
{
    public sealed partial class PlantsUserControlView : UserControl, IPlantsUserControlView
    {
        private static readonly PlantsUserControlView _instance = new PlantsUserControlView();

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

        public void ShowUserControl()
        {
            this.BringToFront();
            //this.Show();                
        }

        private void PlantsUserControlView_Load(object sender, EventArgs e)
        {

        }
    }
}
