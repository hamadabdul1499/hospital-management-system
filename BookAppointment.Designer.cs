namespace HospitalManagementSystem
{
    partial class BookAppointment
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
            this.btnBackToReceptionistPage = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppointmentDateTime = new System.Windows.Forms.TextBox();
            this.txtCheckInStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 47);
            this.label1.TabIndex = 35;
            this.label1.Text = "Appointment Booking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 86;
            this.label13.Text = "Staff ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(153, 190);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(142, 20);
            this.txtStaffID.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Patient ID";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(153, 137);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(142, 20);
            this.txtPatientID.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Appointment Date Time";
            // 
            // txtAppointmentDateTime
            // 
            this.txtAppointmentDateTime.Location = new System.Drawing.Point(612, 142);
            this.txtAppointmentDateTime.Name = "txtAppointmentDateTime";
            this.txtAppointmentDateTime.Size = new System.Drawing.Size(142, 20);
            this.txtAppointmentDateTime.TabIndex = 89;
            // 
            // txtCheckInStatus
            // 
            this.txtCheckInStatus.Location = new System.Drawing.Point(612, 196);
            this.txtCheckInStatus.Name = "txtCheckInStatus";
            this.txtCheckInStatus.Size = new System.Drawing.Size(142, 20);
            this.txtCheckInStatus.TabIndex = 91;
            this.txtCheckInStatus.TextChanged += new System.EventHandler(this.txtCheckInStatus_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Check In Status";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.Location = new System.Drawing.Point(283, 303);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(239, 77);
            this.btnAddAppointment.TabIndex = 93;
            this.btnAddAppointment.Text = "Book Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 21);
            this.label5.TabIndex = 94;
            this.label5.Text = "Use this format (YYYY-MM-DD 00:00:00)";
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheckInStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAppointmentDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.btnBackToReceptionistPage);
            this.Controls.Add(this.label1);
            this.Name = "BookAppointment";
            this.Text = "BookAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToReceptionistPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppointmentDateTime;
        private System.Windows.Forms.TextBox txtCheckInStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label label5;
    }
}