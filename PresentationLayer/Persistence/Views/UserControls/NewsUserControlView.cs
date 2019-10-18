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
    public sealed partial class NewsUserControlView : UserControl, INewsUserControlView
    {
        private static readonly NewsUserControlView _instance = new NewsUserControlView();

        static NewsUserControlView()
        {

        }

        private NewsUserControlView()
        {
            InitializeComponent();
        }

        public static NewsUserControlView Instance
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
