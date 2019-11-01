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
using ServiceLayer.Core;
using ServiceLayer.Persistence;

namespace PresentationLayer.Persistence.Views.UserControls
{
    public sealed partial class DepartmentsUserControlView : UserControl, IDepartmentsUserControlView
    {
        public event EventHandler UserControlViewLoadingEventRaised;

        private static readonly DepartmentsUserControlView _instance = new DepartmentsUserControlView();
        private ILayout _layout;

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

        public void PopulateDepartmentListDataGridView()
        {
            //var unitOfWork = new UnitOfWork(new RepositoryLayer.Persistence.UnitOfWork(new RepositoryLayer.Persistence.Context()));

            //this._departmentListDataGridView.AutoGenerateColumns = false;

            //using(unitOfWork.RepositoryUnitOfWork)
            //{                
            //    this._departmentListDataGridView.DataSource = unitOfWork.RepositoryUnitOfWork.Departments.GetAll();
            //}
        }

        private void DepartmentsUserControlView_Load(object sender, EventArgs e)
        {
            EventHelper.RaisedEvent(this, UserControlViewLoadingEventRaised, e);
        }
    }
}
