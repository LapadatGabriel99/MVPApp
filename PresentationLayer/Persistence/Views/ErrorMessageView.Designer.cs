namespace PresentationLayer.Persistence.Views
{
    partial class ErrorMessageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._messageTextBox = new System.Windows.Forms.TextBox();
            this._closeButton = new System.Windows.Forms.Button();
            this._copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _messageTextBox
            // 
            this._messageTextBox.Location = new System.Drawing.Point(12, 48);
            this._messageTextBox.Multiline = true;
            this._messageTextBox.Name = "_messageTextBox";
            this._messageTextBox.Size = new System.Drawing.Size(364, 90);
            this._messageTextBox.TabIndex = 0;
            // 
            // _closeButton
            // 
            this._closeButton.Location = new System.Drawing.Point(301, 163);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // _copyButton
            // 
            this._copyButton.Location = new System.Drawing.Point(220, 163);
            this._copyButton.Name = "_copyButton";
            this._copyButton.Size = new System.Drawing.Size(75, 23);
            this._copyButton.TabIndex = 2;
            this._copyButton.Text = "Copy";
            this._copyButton.UseVisualStyleBackColor = true;
            this._copyButton.Click += new System.EventHandler(this._copyButton_Click);
            // 
            // ErrorMessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 215);
            this.Controls.Add(this._copyButton);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._messageTextBox);
            this.Name = "ErrorMessageView";
            this.Text = "Error Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _messageTextBox;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.Button _copyButton;
    }
}