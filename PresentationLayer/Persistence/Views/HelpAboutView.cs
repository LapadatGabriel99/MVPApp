using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonComponents.Presentation;
using PresentationLayer.Persistence.Common;
using PresentationLayer.Core.Views;

namespace PresentationLayer.Persistence.Views
{
    public partial class HelpAboutView : Form, IHelpAboutView
    {
        public event EventHandler HelpAboutViewLoadingEventRaised;
        public event EventHandler HelpAboutViewFormClosedEventRaised;

        public HelpAboutView()
        {            
            InitializeComponent();
            //TODO try triggering event to start ViewMaintenance
        }

        public void SetValues(string windowTitle, string productName, string versionName, string copyright, string companyName, string description)
        {
            this.Text = windowTitle;
            this._productLabel.Text = productName;
            this._versionLabel.Text = versionName;
            this._copyrightLabel.Text = copyright;
            this._companyLabel.Text = companyName;
            this._descriptionLabel.Text = description;
        }

        private void HelpAboutView_Load(object sender, EventArgs e)
        {
            FormHelper.SetDialogAppereance(this);
            EventHelper.RaisedEvent(this, HelpAboutViewLoadingEventRaised, e);
        }

        public void ShowHelpAboutView()
        {
            this.Show();
        }

        public void ChangeHelpAboutViewStartLocationToCenterScreen()
        {
            //Retrives the current screen bounds
            Rectangle screenBounds = Screen.FromControl(this).Bounds;

            Size ClinetSize = new Size((int)(screenBounds.Width / 2), (int)(screenBounds.Height / 2));

            this.Location = new Point(screenBounds.Width / 2 - ClientSize.Width / 2, screenBounds.Height / 2 - ClientSize.Height / 2);
        }

        private void _companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();            
        }

        private void HelpAboutView_FormClosed(object sender, FormClosedEventArgs e)
        {            
            EventHelper.RaisedEvent(this, HelpAboutViewFormClosedEventRaised, e);
        }
    }
}
