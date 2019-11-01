using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common.Layout;
using PresentationLayer.Core.Common.Layout.Docking;

namespace PresentationLayer.Persistence.Common.Layout
{
    public class Layout : ILayout 
    {
        private IControlDocking _controlDocking;

        public Layout(IControlDocking controlDocking)
        {
            _controlDocking = controlDocking;
        }

        public IControlDocking ControlDocking
        {
            get { return _controlDocking; }
            set { _controlDocking = value; }
        }
    }
}
