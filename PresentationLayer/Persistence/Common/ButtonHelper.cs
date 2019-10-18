using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Persistence.Common
{
    public static class ButtonHelper
    {
        public static void SetToBorderless(Button button)
        {
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.FlatAppearance.MouseDownBackColor = button.BackColor;

            button.MouseMove += new MouseEventHandler(OnBorderlessMouseMoveEventHandler);
            button.MouseLeave += new EventHandler(OnBorderlessMouseLeaveEventHandler);
        }

        private static void OnBorderlessMouseMoveEventHandler(object sender,EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private static void OnBorderlessMouseLeaveEventHandler(object sender,EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        public static void SetToBorderlessGroup(List<Button> buttons)
        {
            foreach (var button in buttons)
            {
                SetToBorderless(button);
            }
        }

        public static void SetVisibilityOfGroup(List<Button> buttons, bool visibility, Label underlineLabel)
        {
            foreach (var button in buttons)
            {
                button.Visible = visibility;
            }

            if(underlineLabel != null)
            {
                underlineLabel.Visible = visibility;
            }
        }

        public static void SetUnderlinePosition(Button button, Label underlineLabel)
        {
            underlineLabel.Width = button.Bounds.Width - (int)(button.Bounds.Width * 0.15);
            underlineLabel.Left = button.Bounds.Left - (int)(button.Bounds.Width * 0.8);
            underlineLabel.Top = button.Top + button.Height;
        }
    }
}
