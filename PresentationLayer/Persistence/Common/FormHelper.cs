using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PresentationLayer.Persistence.Common
{
    public static class FormHelper
    {
        public static void SetDialogAppereance(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.BackColor = Color.White;
            form.Icon = PresentationLayer.Properties.Resources.house_2_32;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
        }

        public static void SetFormAppereance(Form form)
        {
            SetDialogAppereance(form);
            form.MinimizeBox = true;
        }
    }
}
