namespace HospitalManagementSystem
{
    partial class HospitalReceptionistMainPage
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckInPatients = new System.Windows.Forms.Button();
            this.btnPatientsInfo = new System.Windows.Forms.Button();
            this.btnAppointmentList = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 31);
            this.btnLogOut.TabIndex = 21;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 47);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hospital Receptionist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCheckInPatients
            // 
            this.btnCheckInPatients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInPatients.Location = new System.Drawing.Point(540, 222);
            this.btnCheckInPatients.Name = "btnCheckInPatients";
            this.btnCheckInPatients.Size = new System.Drawing.Size(239, 77);
            this.btnCheckInPatients.TabIndex = 24;
            this.btnCheckInPatients.Text = "Check In Patients";
            this.btnCheckInPatients.UseVisualStyleBackColor = true;
            this.btnCheckInPatients.Click += new System.EventHandler(this.btnCheckInPatients_Click);
            // 
            // btnPatientsInfo
            // 
            this.btnPatientsInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientsInfo.Location = new System.Drawing.Point(271, 222);
            this.btnPatientsInfo.Name = "btnPatientsInfo";
            this.btnPatientsInfo.Size = new System.Drawing.Size(239, 77);
            this.btnPatientsInfo.TabIndex = 23;
            this.btnPatientsInfo.Text = "Patient\'s Information";
            this.btnPatientsInfo.UseVisualStyleBackColor = true;
            this.btnPatientsInfo.Click += new System.EventHandler(this.btnPatientsInfo_Click);
            // 
            // btnAppointmentList
            // 
            this.btnAppointmentList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentList.Location = new System.Drawing.Point(3, 222);
            this.btnAppointmentList.Name = "btnAppointmentList";
            this.btnAppointmentList.Size = new System.Drawing.Size(239, 77);
            this.btnAppointmentList.TabIndex = 22;
            this.btnAppointmentList.Text = "Appointment List";
            this.btnAppointmentList.UseVisualStyleBackColor = true;
            this.btnAppointmentList.Click += new System.EventHandler(this.btnAppointmentList_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAppointment.Location = new System.Drawing.Point(271, 337);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(239, 77);
            this.btnBookAppointment.TabIndex = 25;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // HospitalReceptionistMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.btnCheckInPatients);
            this.Controls.Add(this.btnPatientsInfo);
            this.Controls.Add(this.btnAppointmentList);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HospitalReceptionistMainPage";
            this.Text = "HospitalReceptionistMainPage";
            this.Load += new System.EventHandler(this.HospitalReceptionistMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckInPatients;
        private System.Windows.Forms.Button btnPatientsInfo;
        private System.Windows.Forms.Button btnAppointmentList;
        private System.Windows.Forms.Button btnBookAppointment;
    }
}