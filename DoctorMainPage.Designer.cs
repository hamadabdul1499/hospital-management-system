namespace HospitalManagementSystem
{
    partial class DoctorMainPage
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
            this.btnPatientTreatmentNotes = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnPatientMedicalHistory = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPatientTreatmentNotes
            // 
            this.btnPatientTreatmentNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientTreatmentNotes.Location = new System.Drawing.Point(550, 205);
            this.btnPatientTreatmentNotes.Name = "btnPatientTreatmentNotes";
            this.btnPatientTreatmentNotes.Size = new System.Drawing.Size(239, 77);
            this.btnPatientTreatmentNotes.TabIndex = 30;
            this.btnPatientTreatmentNotes.Text = "Patient\'s Treatment Notes";
            this.btnPatientTreatmentNotes.UseVisualStyleBackColor = true;
            this.btnPatientTreatmentNotes.Click += new System.EventHandler(this.btnPatientTreatmentNotes_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.Location = new System.Drawing.Point(281, 205);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(239, 77);
            this.btnAppointments.TabIndex = 29;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnPatientMedicalHistory
            // 
            this.btnPatientMedicalHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientMedicalHistory.Location = new System.Drawing.Point(12, 205);
            this.btnPatientMedicalHistory.Name = "btnPatientMedicalHistory";
            this.btnPatientMedicalHistory.Size = new System.Drawing.Size(239, 77);
            this.btnPatientMedicalHistory.TabIndex = 28;
            this.btnPatientMedicalHistory.Text = "Patient\'s Medical History";
            this.btnPatientMedicalHistory.UseVisualStyleBackColor = true;
            this.btnPatientMedicalHistory.Click += new System.EventHandler(this.btnPatientMedicalHistory_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(13, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 31);
            this.btnLogOut.TabIndex = 27;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 47);
            this.label2.TabIndex = 26;
            this.label2.Text = "Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "Doctor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoctorMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPatientTreatmentNotes);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.btnPatientMedicalHistory);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoctorMainPage";
            this.Text = "DoctorMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPatientTreatmentNotes;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnPatientMedicalHistory;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}