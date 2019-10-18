using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Core.Views;

namespace PresentationLayer.Persistence.Views
{
    public partial class ErrorMessageView : Form, IErrorMessageView
    {
        public ErrorMessageView()
        {
            InitializeComponent();
        }

        public void ShowErrorMessageView(string windowTitle, string errorMessage)
        {
            this.Text = windowTitle;
            this._messageTextBox.Text = errorMessage;
            this.ShowDialog();
        }

        private void _copyButton_Click(object sender, EventArgs e)
        {
            if(_messageTextBox.Text != "")
            {
                Clipboard.SetText(_messageTextBox.Text);
            }
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
