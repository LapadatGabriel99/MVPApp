using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Core.Views;
using CommonComponents.Presentation;
using PresentationLayer.Persistence.Common;
using PresentationLayer.Core.Common;
using PresentationLayer.Persistence.Views.UserControls;

namespace PresentationLayer
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler MainViewLoadingEventRaised;
        public event EventHandler MainViewLoadedEventRaised;
        public event EventHandler NewsButtonClickEventRaised;
        public event EventHandler PlantListButtonClickEventRaised;
        public event EventHandler DepartmentListButtonClickEventRaised;
        public event EventHandler HelpAboutMenuClickEventRaised;

        private const int _distanceBetweenUnderlineLabelAndButton = 26;
        private IList<UserControl> _userControlList;
        //private DepartmentsUserControlView _departmentsUserControlView;

        public int GetDistanceBetweenUnderlineLabelAndButton { get { return _distanceBetweenUnderlineLabelAndButton; } }
        
        public IUnderlineLabelConditions UnderlineLabelConditions { get; set; }

        public Button NewsButton { get { return _newsButton; } }
        public Button PlantsButton { get { return _plantsButton; } }
        public Button DepartmentsButton { get { return _departmentsButton; } }

        //public IList<UserControl> UserControlList 
        //{
        //    get
        //    {
        //        return _userControlList;
        //    }
        //    private set
        //    {
        //        _userControlList = value;
        //    } 
        //}        
        
        public MainView()
        {               
            InitializeComponent();
            MainView_Load(this, EventArgs.Empty);
        }

        public MainView(IUnderlineLabelConditions underlineLabelConditions): this()
        {
            UnderlineLabelConditions = underlineLabelConditions;
        }

        public void ShowMainView()
        {            
            this.Show();
        }

        public void ChangeMainViewStartPosition()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ChangeUnderlineLabelLocation(Button button)
        {
            UnderlineLabelConditions.ChangeLabelLocation(_underlineLabel, button, GetDistanceBetweenUnderlineLabelAndButton);
        }

        public void SetUnderlineLabelStartingLocation()
        {
            UnderlineLabelConditions.SetLabelStartingLocation(_underlineLabel, _newsButton, GetDistanceBetweenUnderlineLabelAndButton);
        }       
        public void AddUserControlsToUserControlViewPanel(List<IUserControl> userControlList)
        {
            foreach (var userControl in userControlList)
            {
                if(!_userControlViewPanel.Controls.Contains((Control)userControl))
                {
                    _userControlViewPanel.Controls.Add((Control)userControl); 
                }
            }
        }
         
        public void DisplayUserControlOnUserControlViewPanel(IUserControl userControl)
        {
            userControl.ShowUserControl();           
        }

        public void InitializeUserControlList()
        {
            _userControlList = new List<UserControl>();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            EventHelper.RaisedEvent(this, MainViewLoadingEventRaised, e);            
        }
       

        private void _underlineLabel_Click(object sender, EventArgs e)
        {

        }

        private void _departmentsButton_Click(object sender, EventArgs e)
        {
            EventHelper.RaisedEvent(this, DepartmentListButtonClickEventRaised, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _viewMoreContextMenuStrip.Close();
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventHelper.RaisedEvent(this, HelpAboutMenuClickEventRaised, e);
        }

        private void _viewMorePictureBox_Click(object sender, EventArgs e)
        {
            PictureBoxHelper.DisplayContextMeniu(_viewMorePictureBox, _viewMoreContextMenuStrip, this);            
        }

        private void _newsButton_Click(object sender, EventArgs e)
        {
            EventHelper.RaisedEvent(this, NewsButtonClickEventRaised, e);
        }

        private void _plantsButton_Click(object sender, EventArgs e)
        {
            EventHelper.RaisedEvent(this, PlantListButtonClickEventRaised, e);
        }

    }
}
