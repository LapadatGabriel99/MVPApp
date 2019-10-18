namespace PresentationLayer.Persistence.Views
{
    partial class HelpAboutView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._productLabel = new System.Windows.Forms.Label();
            this._versionLabel = new System.Windows.Forms.Label();
            this._copyrightLabel = new System.Windows.Forms.Label();
            this._companyLabel = new System.Windows.Forms.Label();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.PlantLogo;
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _productLabel
            // 
            this._productLabel.AutoSize = true;
            this._productLabel.Location = new System.Drawing.Point(32, 143);
            this._productLabel.Name = "_productLabel";
            this._productLabel.Size = new System.Drawing.Size(253, 13);
            this._productLabel.TabIndex = 1;
            this._productLabel.Text = "---------------------------------------------------------------------------------" +
    "-";
            this._productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _versionLabel
            // 
            this._versionLabel.AutoSize = true;
            this._versionLabel.Location = new System.Drawing.Point(32, 182);
            this._versionLabel.Name = "_versionLabel";
            this._versionLabel.Size = new System.Drawing.Size(253, 13);
            this._versionLabel.TabIndex = 2;
            this._versionLabel.Text = "---------------------------------------------------------------------------------" +
    "-";
            this._versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _copyrightLabel
            // 
            this._copyrightLabel.AutoSize = true;
            this._copyrightLabel.Location = new System.Drawing.Point(32, 221);
            this._copyrightLabel.Name = "_copyrightLabel";
            this._copyrightLabel.Size = new System.Drawing.Size(253, 13);
            this._copyrightLabel.TabIndex = 3;
            this._copyrightLabel.Text = "---------------------------------------------------------------------------------" +
    "-";
            this._copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _companyLabel
            // 
            this._companyLabel.AutoSize = true;
            this._companyLabel.Location = new System.Drawing.Point(32, 260);
            this._companyLabel.Name = "_companyLabel";
            this._companyLabel.Size = new System.Drawing.Size(253, 13);
            this._companyLabel.TabIndex = 4;
            this._companyLabel.Text = "---------------------------------------------------------------------------------" +
    "-";
            this._companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._companyLabel.Click += new System.EventHandler(this._companyLabel_Click);
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.Location = new System.Drawing.Point(32, 299);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(253, 40);
            this._descriptionLabel.TabIndex = 5;
            this._descriptionLabel.Text = "---------------------------------------------------------------------------------" +
    "-";
            this._descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _closeButton
            // 
            this._closeButton.BackColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(121, 368);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 6;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = false;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // HelpAboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(315, 414);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._descriptionLabel);
            this.Controls.Add(this._companyLabel);
            this.Controls.Add(this._copyrightLabel);
            this.Controls.Add(this._versionLabel);
            this.Controls.Add(this._productLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HelpAboutView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpAboutView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpAboutView_FormClosed);
            this.Load += new System.EventHandler(this.HelpAboutView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _productLabel;
        private System.Windows.Forms.Label _versionLabel;
        private System.Windows.Forms.Label _copyrightLabel;
        private System.Windows.Forms.Label _companyLabel;
        private System.Windows.Forms.Label _descriptionLabel;
        private System.Windows.Forms.Button _closeButton;
    }
}