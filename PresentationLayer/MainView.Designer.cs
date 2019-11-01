namespace PresentationLayer
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this._plantsCompanyPanel = new System.Windows.Forms.Panel();
            this._userControlViewPanel = new System.Windows.Forms.Panel();
            this._newsButton = new System.Windows.Forms.Button();
            this._departmentsButton = new System.Windows.Forms.Button();
            this._plantsButton = new System.Windows.Forms.Button();
            this._skyFlowerFields = new System.Windows.Forms.PictureBox();
            this._userInfoPictureBox = new System.Windows.Forms.PictureBox();
            this._notificationBellPictureBox = new System.Windows.Forms.PictureBox();
            this._viewMorePictureBox = new System.Windows.Forms.PictureBox();
            this._underlineLabel = new System.Windows.Forms.Label();
            this._viewMoreContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._skyFlowerFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._userInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._notificationBellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewMorePictureBox)).BeginInit();
            this._viewMoreContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _plantsCompanyPanel
            // 
            this._plantsCompanyPanel.BackgroundImage = global::PresentationLayer.Properties.Resources.PlantCompanyResize3;
            this._plantsCompanyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._plantsCompanyPanel.Location = new System.Drawing.Point(0, 0);
            this._plantsCompanyPanel.Name = "_plantsCompanyPanel";
            this._plantsCompanyPanel.Size = new System.Drawing.Size(800, 97);
            this._plantsCompanyPanel.TabIndex = 0;
            // 
            // _userControlViewPanel
            // 
            this._userControlViewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this._userControlViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._userControlViewPanel.Location = new System.Drawing.Point(0, 266);
            this._userControlViewPanel.Name = "_userControlViewPanel";
            this._userControlViewPanel.Size = new System.Drawing.Size(800, 220);
            this._userControlViewPanel.TabIndex = 1;
            // 
            // _newsButton
            // 
            this._newsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._newsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._newsButton.Location = new System.Drawing.Point(54, 223);
            this._newsButton.Name = "_newsButton";
            this._newsButton.Size = new System.Drawing.Size(152, 23);
            this._newsButton.TabIndex = 0;
            this._newsButton.Text = "News";
            this._newsButton.UseVisualStyleBackColor = false;
            this._newsButton.Click += new System.EventHandler(this._newsButton_Click);
            // 
            // _departmentsButton
            // 
            this._departmentsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._departmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._departmentsButton.Location = new System.Drawing.Point(588, 223);
            this._departmentsButton.Name = "_departmentsButton";
            this._departmentsButton.Size = new System.Drawing.Size(152, 23);
            this._departmentsButton.TabIndex = 2;
            this._departmentsButton.Text = "Departments";
            this._departmentsButton.UseVisualStyleBackColor = false;
            this._departmentsButton.Click += new System.EventHandler(this._departmentsButton_Click);
            // 
            // _plantsButton
            // 
            this._plantsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._plantsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._plantsButton.Location = new System.Drawing.Point(333, 223);
            this._plantsButton.Name = "_plantsButton";
            this._plantsButton.Size = new System.Drawing.Size(152, 23);
            this._plantsButton.TabIndex = 3;
            this._plantsButton.Text = "Plants";
            this._plantsButton.UseVisualStyleBackColor = false;
            this._plantsButton.Click += new System.EventHandler(this._plantsButton_Click);
            // 
            // _skyFlowerFields
            // 
            this._skyFlowerFields.Image = global::PresentationLayer.Properties.Resources.SkyNFlowers2;
            this._skyFlowerFields.Location = new System.Drawing.Point(0, 97);
            this._skyFlowerFields.Name = "_skyFlowerFields";
            this._skyFlowerFields.Size = new System.Drawing.Size(800, 111);
            this._skyFlowerFields.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._skyFlowerFields.TabIndex = 4;
            this._skyFlowerFields.TabStop = false;
            // 
            // _userInfoPictureBox
            // 
            this._userInfoPictureBox.Image = global::PresentationLayer.Properties.Resources.icons8_account_50;
            this._userInfoPictureBox.Location = new System.Drawing.Point(693, 103);
            this._userInfoPictureBox.Name = "_userInfoPictureBox";
            this._userInfoPictureBox.Size = new System.Drawing.Size(50, 50);
            this._userInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._userInfoPictureBox.TabIndex = 5;
            this._userInfoPictureBox.TabStop = false;
            // 
            // _notificationBellPictureBox
            // 
            this._notificationBellPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._notificationBellPictureBox.Image = global::PresentationLayer.Properties.Resources.CoolBellMark2;
            this._notificationBellPictureBox.Location = new System.Drawing.Point(637, 103);
            this._notificationBellPictureBox.Name = "_notificationBellPictureBox";
            this._notificationBellPictureBox.Size = new System.Drawing.Size(50, 50);
            this._notificationBellPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._notificationBellPictureBox.TabIndex = 6;
            this._notificationBellPictureBox.TabStop = false;
            // 
            // _viewMorePictureBox
            // 
            this._viewMorePictureBox.Image = global::PresentationLayer.Properties.Resources.icons8_view_more_56;
            this._viewMorePictureBox.Location = new System.Drawing.Point(748, 103);
            this._viewMorePictureBox.Name = "_viewMorePictureBox";
            this._viewMorePictureBox.Size = new System.Drawing.Size(50, 50);
            this._viewMorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._viewMorePictureBox.TabIndex = 7;
            this._viewMorePictureBox.TabStop = false;
            this._viewMorePictureBox.Click += new System.EventHandler(this._viewMorePictureBox_Click);
            // 
            // _underlineLabel
            // 
            this._underlineLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._underlineLabel.Location = new System.Drawing.Point(54, 249);
            this._underlineLabel.Name = "_underlineLabel";
            this._underlineLabel.Size = new System.Drawing.Size(152, 7);
            this._underlineLabel.TabIndex = 8;
            this._underlineLabel.Text = "_underlineLabel";
            this._underlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._underlineLabel.Click += new System.EventHandler(this._underlineLabel_Click);
            // 
            // _viewMoreContextMenuStrip
            // 
            this._viewMoreContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this._viewMoreContextMenuStrip.Name = "_viewMoreContextMenuStrip";
            this._viewMoreContextMenuStrip.Size = new System.Drawing.Size(136, 70);
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.helpAboutToolStripMenuItem.Text = "Help About";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this._underlineLabel);
            this.Controls.Add(this._viewMorePictureBox);
            this.Controls.Add(this._notificationBellPictureBox);
            this.Controls.Add(this._userInfoPictureBox);
            this.Controls.Add(this._skyFlowerFields);
            this.Controls.Add(this._plantsButton);
            this.Controls.Add(this._departmentsButton);
            this.Controls.Add(this._newsButton);
            this.Controls.Add(this._userControlViewPanel);
            this.Controls.Add(this._plantsCompanyPanel);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVPDemo";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this._skyFlowerFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._userInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._notificationBellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._viewMorePictureBox)).EndInit();
            this._viewMoreContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _plantsCompanyPanel;
        private System.Windows.Forms.Panel _userControlViewPanel;
        private System.Windows.Forms.Button _newsButton;
        private System.Windows.Forms.Button _departmentsButton;
        private System.Windows.Forms.Button _plantsButton;
        private System.Windows.Forms.PictureBox _skyFlowerFields;
        private System.Windows.Forms.PictureBox _userInfoPictureBox;
        private System.Windows.Forms.PictureBox _notificationBellPictureBox;
        private System.Windows.Forms.PictureBox _viewMorePictureBox;
        private System.Windows.Forms.Label _underlineLabel;
        private System.Windows.Forms.ContextMenuStrip _viewMoreContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

