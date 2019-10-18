using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Core.Common
{
    public interface ILabelChangeLocation
    {
        void ChangeLabelLocation(Label label, Button button, int distance);
    }
}
