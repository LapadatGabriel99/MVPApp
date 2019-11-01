using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common.Layout;
using PresentationLayer.Core.Common;
using System.Windows.Forms;

namespace PresentationLayer.Core.Common.Layout.Docking
{
    public interface IControlDocking : IDockStyle
    {
        new void SetDockToBottom<T>(T control) where T : Control;

        new void SetDockToFill<T>(T control) where T : Control;
    }
}
