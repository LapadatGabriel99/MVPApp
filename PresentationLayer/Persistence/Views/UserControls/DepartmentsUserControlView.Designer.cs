namespace PresentationLayer.Persistence.Views.UserControls
{
    partial class DepartmentsUserControlView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._departmentListDataGridView = new System.Windows.Forms.DataGridView();
            this._departmentListDataGridViewID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departmentListDataGridViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departmentListDataGridViewUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departmentListDataGridViewPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departmentListDataGridViewEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departmentListDataGridViewCityLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departmentListDataGridViewStateLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._departmentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _departmentListDataGridView
            // 
            this._departmentListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this._departmentListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._departmentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._departmentListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._departmentListDataGridViewID,
            this._departmentListDataGridViewName,
            this._departmentListDataGridViewUrl,
            this._departmentListDataGridViewPhoneNumber,
            this._departmentListDataGridViewEmail,
            this._departmentListDataGridViewCityLocation,
            this._departmentListDataGridViewStateLocation});
            this._departmentListDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this._departmentListDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this._departmentListDataGridView.Location = new System.Drawing.Point(0, 0);
            this._departmentListDataGridView.Name = "_departmentListDataGridView";
            this._departmentListDataGridView.Size = new System.Drawing.Size(800, 220);
            this._departmentListDataGridView.TabIndex = 0;
            // 
            // _departmentListDataGridViewID
            // 
            this._departmentListDataGridViewID.DataPropertyName = "ID";
            this._departmentListDataGridViewID.HeaderText = "ID";
            this._departmentListDataGridViewID.Name = "_departmentListDataGridViewID";
            // 
            // _departmentListDataGridViewName
            // 
            this._departmentListDataGridViewName.DataPropertyName = "Name";
            this._departmentListDataGridViewName.HeaderText = "Name";
            this._departmentListDataGridViewName.Name = "_departmentListDataGridViewName";
            // 
            // _departmentListDataGridViewUrl
            // 
            this._departmentListDataGridViewUrl.DataPropertyName = "Url";
            this._departmentListDataGridViewUrl.HeaderText = "Url";
            this._departmentListDataGridViewUrl.Name = "_departmentListDataGridViewUrl";
            // 
            // _departmentListDataGridViewPhoneNumber
            // 
            this._departmentListDataGridViewPhoneNumber.DataPropertyName = "PhoneNumber";
            this._departmentListDataGridViewPhoneNumber.HeaderText = "Phone Number";
            this._departmentListDataGridViewPhoneNumber.Name = "_departmentListDataGridViewPhoneNumber";
            // 
            // _departmentListDataGridViewEmail
            // 
            this._departmentListDataGridViewEmail.DataPropertyName = "Email";
            this._departmentListDataGridViewEmail.HeaderText = "Email";
            this._departmentListDataGridViewEmail.Name = "_departmentListDataGridViewEmail";
            // 
            // _departmentListDataGridViewCityLocation
            // 
            this._departmentListDataGridViewCityLocation.DataPropertyName = "CityLocation";
            this._departmentListDataGridViewCityLocation.HeaderText = "City Location";
            this._departmentListDataGridViewCityLocation.Name = "_departmentListDataGridViewCityLocation";
            // 
            // _departmentListDataGridViewStateLocation
            // 
            this._departmentListDataGridViewStateLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._departmentListDataGridViewStateLocation.DataPropertyName = "StateLocation";
            this._departmentListDataGridViewStateLocation.HeaderText = "State Location";
            this._departmentListDataGridViewStateLocation.Name = "_departmentListDataGridViewStateLocation";
            // 
            // DepartmentsUserControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._departmentListDataGridView);
            this.Name = "DepartmentsUserControlView";
            this.Size = new System.Drawing.Size(800, 220);
            this.Load += new System.EventHandler(this.DepartmentsUserControlView_Load);
            ((System.ComponentModel.ISupportInitialize)(this._departmentListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _departmentListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentListDataGridViewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentListDataGridViewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentListDataGridViewUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentListDataGridViewPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentListDataGridViewEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentListDataGridViewCityLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentListDataGridViewStateLocation;
    }
}
