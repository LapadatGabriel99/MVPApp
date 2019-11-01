using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common.Layout.Docking;
using System.Windows.Forms;
using PresentationLayer.Core.Common;

namespace PresentationLayer.Persistence.Common.Layout.Docking
{
    public class ControlDocking : IControlDocking
    {

        public ControlDocking()
        {

        }

        public void SetDockToBottom<T>(T control) where T: Control
        {
            control.Dock = DockStyle.Bottom;
        }

        public void SetDockToFill<T>(T control) where T: Control 
        {
            control.Dock = DockStyle.Fill;
        }
    }
}
