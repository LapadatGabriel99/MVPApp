using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Core.Common
{
    public interface ILabelConditions : ILabelStartLocation, ILabelChangeLocation
    {
        new void ChangeLabelLocation(Label label, Button button, int distance);
        new void SetLabelStartingLocation(Label label, Button button, int distance);
    }
}
