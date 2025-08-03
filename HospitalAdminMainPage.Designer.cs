namespace HospitalManagementSystem
{
    partial class HospitalAdminMainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatientsInfo = new System.Windows.Forms.Button();
            this.btnUpdateStaffInfo = new System.Windows.Forms.Button();
            this.btnStaffSchedule = new System.Windows.Forms.Button();
            this.btnStaffDepartment = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnResetPasswords = new System.Windows.Forms.Button();
            this.btnAddCredentials = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hospital Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 47);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 31);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(12, 203);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(239, 77);
            this.btnAddPatient.TabIndex = 19;
            this.btnAddPatient.Text = "Add New Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnUpdatePatientsInfo
            // 
            this.btnUpdatePatientsInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePatientsInfo.Location = new System.Drawing.Point(280, 203);
            this.btnUpdatePatientsInfo.Name = "btnUpdatePatientsInfo";
            this.btnUpdatePatientsInfo.Size = new System.Drawing.Size(239, 77);
            this.btnUpdatePatientsInfo.TabIndex = 20;
            this.btnUpdatePatientsInfo.Text = "Update Patient\'s Information";
            this.btnUpdatePatientsInfo.UseVisualStyleBackColor = true;
            this.btnUpdatePatientsInfo.Click += new System.EventHandler(this.btnUpdatePatientsInfo_Click);
            // 
            // btnUpdateStaffInfo
            // 
            this.btnUpdateStaffInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaffInfo.Location = new System.Drawing.Point(549, 203);
            this.btnUpdateStaffInfo.Name = "btnUpdateStaffInfo";
            this.btnUpdateStaffInfo.Size = new System.Drawing.Size(239, 77);
            this.btnUpdateStaffInfo.TabIndex = 21;
            this.btnUpdateStaffInfo.Text = "Update Staff\'s Information";
            this.btnUpdateStaffInfo.UseVisualStyleBackColor = true;
            this.btnUpdateStaffInfo.Click += new System.EventHandler(this.btnUpdateStaffInfo_Click);
            // 
            // btnStaffSchedule
            // 
            this.btnStaffSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSchedule.Location = new System.Drawing.Point(280, 307);
            this.btnStaffSchedule.Name = "btnStaffSchedule";
            this.btnStaffSchedule.Size = new System.Drawing.Size(239, 77);
            this.btnStaffSchedule.TabIndex = 22;
            this.btnStaffSchedule.Text = "Assign Staff Schedule";
            this.btnStaffSchedule.UseVisualStyleBackColor = true;
            this.btnStaffSchedule.Click += new System.EventHandler(this.btnStaffSchedule_Click);
            // 
            // btnStaffDepartment
            // 
            this.btnStaffDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDepartment.Location = new System.Drawing.Point(549, 307);
            this.btnStaffDepartment.Name = "btnStaffDepartment";
            this.btnStaffDepartment.Size = new System.Drawing.Size(239, 77);
            this.btnStaffDepartment.TabIndex = 23;
            this.btnStaffDepartment.Text = "Assign Staff Department";
            this.btnStaffDepartment.UseVisualStyleBackColor = true;
            this.btnStaffDepartment.Click += new System.EventHandler(this.btnStaffDepartment_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(12, 307);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(239, 77);
            this.btnAddStaff.TabIndex = 24;
            this.btnAddStaff.Text = "Add New Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnResetPasswords
            // 
            this.btnResetPasswords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPasswords.Location = new System.Drawing.Point(611, 28);
            this.btnResetPasswords.Name = "btnResetPasswords";
            this.btnResetPasswords.Size = new System.Drawing.Size(156, 47);
            this.btnResetPasswords.TabIndex = 25;
            this.btnResetPasswords.Text = "Reset Passwords";
            this.btnResetPasswords.UseVisualStyleBackColor = true;
            this.btnResetPasswords.Click += new System.EventHandler(this.btnResetPasswords_Click);
            // 
            // btnAddCredentials
            // 
            this.btnAddCredentials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCredentials.Location = new System.Drawing.Point(611, 81);
            this.btnAddCredentials.Name = "btnAddCredentials";
            this.btnAddCredentials.Size = new System.Drawing.Size(156, 47);
            this.btnAddCredentials.TabIndex = 26;
            this.btnAddCredentials.Text = "Add Credentials";
            this.btnAddCredentials.UseVisualStyleBackColor = true;
            this.btnAddCredentials.Click += new System.EventHandler(this.btnAddCredentials_Click);
            // 
            // HospitalAdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCredentials);
            this.Controls.Add(this.btnResetPasswords);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnStaffDepartment);
            this.Controls.Add(this.btnStaffSchedule);
            this.Controls.Add(this.btnUpdateStaffInfo);
            this.Controls.Add(this.btnUpdatePatientsInfo);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HospitalAdminMainPage";
            this.Text = "HospitalAdminMainPage";
            this.Load += new System.EventHandler(this.HospitalAdminMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnUpdatePatientsInfo;
        private System.Windows.Forms.Button btnUpdateStaffInfo;
        private System.Windows.Forms.Button btnStaffSchedule;
        private System.Windows.Forms.Button btnStaffDepartment;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnResetPasswords;
        private System.Windows.Forms.Button btnAddCredentials;
    }
}