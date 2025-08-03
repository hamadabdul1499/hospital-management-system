namespace HospitalManagementSystem
{
    partial class CheckInPatients
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
            this.dgvCheckInPatients = new System.Windows.Forms.DataGridView();
            this.btnBackToReceptionistPage = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.txtCheckInStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckInPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 47);
            this.label1.TabIndex = 77;
            this.label1.Text = "Check In Patients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCheckInPatients
            // 
            this.dgvCheckInPatients.AllowUserToAddRows = false;
            this.dgvCheckInPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInPatients.Location = new System.Drawing.Point(45, 98);
            this.dgvCheckInPatients.MultiSelect = false;
            this.dgvCheckInPatients.Name = "dgvCheckInPatients";
            this.dgvCheckInPatients.ReadOnly = true;
            this.dgvCheckInPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckInPatients.Size = new System.Drawing.Size(709, 150);
            this.dgvCheckInPatients.TabIndex = 78;
            this.dgvCheckInPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckInPatients_CellClick);
            // 
            // btnBackToReceptionistPage
            // 
            this.btnBackToReceptionistPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToReceptionistPage.Location = new System.Drawing.Point(12, 385);
            this.btnBackToReceptionistPage.Name = "btnBackToReceptionistPage";
            this.btnBackToReceptionistPage.Size = new System.Drawing.Size(116, 53);
            this.btnBackToReceptionistPage.TabIndex = 84;
            this.btnBackToReceptionistPage.Text = "Back To Receptionist Main Page";
            this.btnBackToReceptionistPage.UseVisualStyleBackColor = true;
            this.btnBackToReceptionistPage.Click += new System.EventHandler(this.btnBackToReceptionistPage_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowData.Location = new System.Drawing.Point(576, 33);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(178, 59);
            this.btnShowData.TabIndex = 85;
            this.btnShowData.Text = "Show The Full List Of Appointments";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // txtCheckInStatus
            // 
            this.txtCheckInStatus.Location = new System.Drawing.Point(608, 340);
            this.txtCheckInStatus.Name = "txtCheckInStatus";
            this.txtCheckInStatus.Size = new System.Drawing.Size(142, 20);
            this.txtCheckInStatus.TabIndex = 132;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 131;
            this.label8.Text = "Check In Status";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(608, 291);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(142, 20);
            this.txtDateTime.TabIndex = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 25);
            this.label7.TabIndex = 129;
            this.label7.Text = "Appointment Date and Time";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(196, 360);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(142, 20);
            this.txtStaffID.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 127;
            this.label6.Text = "Staff ID";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(196, 314);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(142, 20);
            this.txtPatientID.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 123;
            this.label4.Text = "Patient ID";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Location = new System.Drawing.Point(196, 270);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(142, 20);
            this.txtAppointmentID.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 121;
            this.label3.Text = "Appointment ID";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(123, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 34);
            this.btnClear.TabIndex = 133;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckInPatient
            // 
            this.btnCheckInPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInPatient.Location = new System.Drawing.Point(308, 385);
            this.btnCheckInPatient.Name = "btnCheckInPatient";
            this.btnCheckInPatient.Size = new System.Drawing.Size(191, 59);
            this.btnCheckInPatient.TabIndex = 134;
            this.btnCheckInPatient.Text = "Check In Patient";
            this.btnCheckInPatient.UseVisualStyleBackColor = true;
            this.btnCheckInPatient.Click += new System.EventHandler(this.btnCheckInPatient_Click);
            // 
            // CheckInPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckInPatient);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCheckInStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAppointmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnBackToReceptionistPage);
            this.Controls.Add(this.dgvCheckInPatients);
            this.Controls.Add(this.label1);
            this.Name = "CheckInPatients";
            this.Text = "CheckInPatients";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCheckInPatients;
        private System.Windows.Forms.Button btnBackToReceptionistPage;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.TextBox txtCheckInStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckInPatient;
    }
}