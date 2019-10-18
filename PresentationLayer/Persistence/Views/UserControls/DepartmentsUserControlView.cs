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
    public sealed partial class DepartmentsUserControlView : UserControl, IDepartmentsUserControlView
    {
        private static readonly DepartmentsUserControlView _instance = new DepartmentsUserControlView();

        static DepartmentsUserControlView()
        {

        }

        private DepartmentsUserControlView()
        {
            InitializeComponent();
        }

        public static DepartmentsUserControlView Instance
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
    }
}
