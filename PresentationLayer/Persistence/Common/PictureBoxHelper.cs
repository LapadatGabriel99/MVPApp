using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PresentationLayer.Persistence.Common
{
    public static class PictureBoxHelper
    {
        public static void SetClickableBehavior(PictureBox pictureBox)
        {
            pictureBox.MouseMove += new MouseEventHandler(OnPictureBoxMouseMoveEventHandler);
            pictureBox.MouseLeave += new EventHandler(OnPictureBoxMouseLeaveEventHandler);
        }

        private static void OnPictureBoxMouseMoveEventHandler(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private static void OnPictureBoxMouseLeaveEventHandler(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        public static void DisplayContextMeniu(PictureBox pictureBox, ContextMenuStrip contextMenuStrip, Form form)
        {
            Point pointForContextMenu = form.PointToScreen(
                new Point(pictureBox.Location.X - contextMenuStrip.Width + pictureBox.Width,
                pictureBox.Location.Y + pictureBox.Height));

            contextMenuStrip.Show(pointForContextMenu.X, pointForContextMenu.Y);
        }
    }
}
