﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Presenters.UserControls;
using PresentationLayer.Core.Views.UserControls;

namespace PresentationLayer.Persistence.Presenters.UserControls
{
    public class DepartmensUserControlPresenter : IDeparmentsUserControlPresenter
    {
        private IDepartmentsUserControlView _departmentsUserControlView;

        public DepartmensUserControlPresenter()
        {

        }

        public DepartmensUserControlPresenter(IDepartmentsUserControlView departmentsUserControlView)
        {
            _departmentsUserControlView = departmentsUserControlView;
        }

        public IDepartmentsUserControlView GetDepartmentsUserControlView { get { return _departmentsUserControlView; } }
    }
}