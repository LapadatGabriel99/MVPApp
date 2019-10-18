using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common;
using System.Windows.Forms;
using System.Drawing;

namespace PresentationLayer.Persistence.Common
{
    public class UnderlineLabelConditions : IUnderlineLabelConditions
    {
        public void ChangeLabelLocation(Label underlineLabel, Button buttonThatWillHaveUnderLine, int distanceBetweenLabelAndButton)
        {
            underlineLabel.Location = new Point(buttonThatWillHaveUnderLine.Location.X, buttonThatWillHaveUnderLine.Location.Y + distanceBetweenLabelAndButton);
        }

        public void SetLabelStartingLocation(Label underlineLabel, Button buttonThatHasUnderline, int distanceBetweenLabelAndButton)
        {
            underlineLabel.Location = new Point(buttonThatHasUnderline.Location.X, buttonThatHasUnderline.Location.Y + distanceBetweenLabelAndButton);
        }
    }
}
