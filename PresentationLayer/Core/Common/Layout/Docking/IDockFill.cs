using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Core.Common.Layout.Docking
{
    public interface IDockFill
    {
        void SetDockToFill<T>(T control) where T : Control;
    }
}
