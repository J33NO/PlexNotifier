namespace Plex_Notifier_App
{
    partial class Form1
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
            this.lblSelectUsers = new System.Windows.Forms.Label();
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.lblNotificationBody = new System.Windows.Forms.Label();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNotificationType = new System.Windows.Forms.Label();
            this.NewMovieRadioBtn = new System.Windows.Forms.RadioButton();
            this.MaintenanceRadioBtn = new System.Windows.Forms.RadioButton();
            this.OtherRadioBtn = new System.Windows.Forms.RadioButton();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBoxSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectUsers
            // 
            this.lblSelectUsers.AutoSize = true;
            this.lblSelectUsers.Location = new System.Drawing.Point(12, 26);
            this.lblSelectUsers.Name = "lblSelectUsers";
            this.lblSelectUsers.Size = new System.Drawing.Size(83, 13);
            this.lblSelectUsers.TabIndex = 2;
            this.lblSelectUsers.Text = "Users To Notify:";
            this.lblSelectUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Location = new System.Drawing.Point(759, 95);
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.Size = new System.Drawing.Size(566, 20);
            this.txtMessageBody.TabIndex = 3;
            // 
            // lblNotificationBody
            // 
            this.lblNotificationBody.AutoSize = true;
            this.lblNotificationBody.Location = new System.Drawing.Point(772, 74);
            this.lblNotificationBody.Name = "lblNotificationBody";
            this.lblNotificationBody.Size = new System.Drawing.Size(87, 13);
            this.lblNotificationBody.TabIndex = 4;
            this.lblNotificationBody.Text = "Notification Body";
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Location = new System.Drawing.Point(759, 264);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(122, 47);
            this.btnSendNotification.TabIndex = 5;
            this.btnSendNotification.Text = "Send Notification";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(903, 264);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(133, 47);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.AutoSize = true;
            this.lblStatusMessage.Location = new System.Drawing.Point(1042, 264);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(40, 13);
            this.lblStatusMessage.TabIndex = 7;
            this.lblStatusMessage.Text = "Status:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(1088, 264);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 10;
            // 
            // lblNotificationType
            // 
            this.lblNotificationType.AutoSize = true;
            this.lblNotificationType.Location = new System.Drawing.Point(772, 134);
            this.lblNotificationType.Name = "lblNotificationType";
            this.lblNotificationType.Size = new System.Drawing.Size(87, 13);
            this.lblNotificationType.TabIndex = 11;
            this.lblNotificationType.Text = "Notification Type";
            // 
            // NewMovieRadioBtn
            // 
            this.NewMovieRadioBtn.AutoSize = true;
            this.NewMovieRadioBtn.Location = new System.Drawing.Point(775, 151);
            this.NewMovieRadioBtn.Name = "NewMovieRadioBtn";
            this.NewMovieRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.NewMovieRadioBtn.TabIndex = 12;
            this.NewMovieRadioBtn.TabStop = true;
            this.NewMovieRadioBtn.Text = "New Movie";
            this.NewMovieRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MaintenanceRadioBtn
            // 
            this.MaintenanceRadioBtn.AutoSize = true;
            this.MaintenanceRadioBtn.Location = new System.Drawing.Point(775, 175);
            this.MaintenanceRadioBtn.Name = "MaintenanceRadioBtn";
            this.MaintenanceRadioBtn.Size = new System.Drawing.Size(87, 17);
            this.MaintenanceRadioBtn.TabIndex = 13;
            this.MaintenanceRadioBtn.TabStop = true;
            this.MaintenanceRadioBtn.Text = "Maintenance";
            this.MaintenanceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // OtherRadioBtn
            // 
            this.OtherRadioBtn.AutoSize = true;
            this.OtherRadioBtn.Location = new System.Drawing.Point(775, 199);
            this.OtherRadioBtn.Name = "OtherRadioBtn";
            this.OtherRadioBtn.Size = new System.Drawing.Size(51, 17);
            this.OtherRadioBtn.TabIndex = 14;
            this.OtherRadioBtn.TabStop = true;
            this.OtherRadioBtn.Text = "Other";
            this.OtherRadioBtn.UseVisualStyleBackColor = true;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(832, 198);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(489, 20);
            this.txtOther.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.userId,
            this.phoneNumber,
            this.firstName,
            this.lastName,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 521);
            this.dataGridView1.TabIndex = 16;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "SmsOptIn";
            this.Selected.FalseValue = "false";
            this.Selected.HeaderText = "Send Sms";
            this.Selected.Name = "Selected";
            this.Selected.TrueValue = "true";
            this.Selected.Width = 75;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "UserId";
            this.userId.HeaderText = "UserId";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "PhoneNumber";
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "FirstName";
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // chkBoxSelectAll
            // 
            this.chkBoxSelectAll.AutoSize = true;
            this.chkBoxSelectAll.Location = new System.Drawing.Point(76, 51);
            this.chkBoxSelectAll.Name = "chkBoxSelectAll";
            this.chkBoxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkBoxSelectAll.TabIndex = 17;
            this.chkBoxSelectAll.Text = "Select All";
            this.chkBoxSelectAll.UseVisualStyleBackColor = true;
            this.chkBoxSelectAll.CheckedChanged += new System.EventHandler(this.chkBoxSelectAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 632);
            this.Controls.Add(this.chkBoxSelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.OtherRadioBtn);
            this.Controls.Add(this.MaintenanceRadioBtn);
            this.Controls.Add(this.NewMovieRadioBtn);
            this.Controls.Add(this.lblNotificationType);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.lblNotificationBody);
            this.Controls.Add(this.txtMessageBody);
            this.Controls.Add(this.lblSelectUsers);
            this.Name = "Form1";
            this.Text = "Plex Notifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectUsers;
        private System.Windows.Forms.TextBox txtMessageBody;
        private System.Windows.Forms.Label lblNotificationBody;
        private System.Windows.Forms.Button btnSendNotification;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNotificationType;
        private System.Windows.Forms.RadioButton NewMovieRadioBtn;
        private System.Windows.Forms.RadioButton MaintenanceRadioBtn;
        private System.Windows.Forms.RadioButton OtherRadioBtn;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.CheckBox chkBoxSelectAll;
    }
}

