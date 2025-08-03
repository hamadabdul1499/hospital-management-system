namespace HospitalManagementSystem
{
    partial class PatientMedicalHistory
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
            this.dgvPatientMedicalHistory = new System.Windows.Forms.DataGridView();
            this.txtVaccinationHistory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMedications = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedicalHistoryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoctorNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackToDoctorPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedicalHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 47);
            this.label1.TabIndex = 76;
            this.label1.Text = "Patient Medical History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPatientMedicalHistory
            // 
            this.dgvPatientMedicalHistory.AllowUserToAddRows = false;
            this.dgvPatientMedicalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientMedicalHistory.Location = new System.Drawing.Point(43, 80);
            this.dgvPatientMedicalHistory.MultiSelect = false;
            this.dgvPatientMedicalHistory.Name = "dgvPatientMedicalHistory";
            this.dgvPatientMedicalHistory.ReadOnly = true;
            this.dgvPatientMedicalHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientMedicalHistory.Size = new System.Drawing.Size(709, 150);
            this.dgvPatientMedicalHistory.TabIndex = 77;
            this.dgvPatientMedicalHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientMedicalHistory_CellClick);
            // 
            // txtVaccinationHistory
            // 
            this.txtVaccinationHistory.Location = new System.Drawing.Point(608, 342);
            this.txtVaccinationHistory.Name = "txtVaccinationHistory";
            this.txtVaccinationHistory.Size = new System.Drawing.Size(142, 20);
            this.txtVaccinationHistory.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 119;
            this.label8.Text = "Vaccination History";
            // 
            // txtMedications
            // 
            this.txtMedications.Location = new System.Drawing.Point(608, 296);
            this.txtMedications.Name = "txtMedications";
            this.txtMedications.Size = new System.Drawing.Size(142, 20);
            this.txtMedications.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 25);
            this.label7.TabIndex = 117;
            this.label7.Text = "Current/Previous Medications";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(608, 250);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(142, 20);
            this.txtDiagnosis.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 115;
            this.label6.Text = "Diagnosis";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(192, 341);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(142, 20);
            this.txtStaffID.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 113;
            this.label5.Text = "Staff ID";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(192, 295);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(142, 20);
            this.txtPatientID.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 111;
            this.label4.Text = "Patient ID";
            // 
            // txtMedicalHistoryID
            // 
            this.txtMedicalHistoryID.Location = new System.Drawing.Point(192, 251);
            this.txtMedicalHistoryID.Name = "txtMedicalHistoryID";
            this.txtMedicalHistoryID.ReadOnly = true;
            this.txtMedicalHistoryID.Size = new System.Drawing.Size(142, 20);
            this.txtMedicalHistoryID.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 109;
            this.label3.Text = "Medical History ID";
            // 
            // txtDoctorNotes
            // 
            this.txtDoctorNotes.Location = new System.Drawing.Point(158, 382);
            this.txtDoctorNotes.Name = "txtDoctorNotes";
            this.txtDoctorNotes.Size = new System.Drawing.Size(560, 20);
            this.txtDoctorNotes.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 121;
            this.label2.Text = "Doctor Notes";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(226, 408);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 36);
            this.btnEdit.TabIndex = 123;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(454, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 33);
            this.btnDelete.TabIndex = 125;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(340, 409);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 34);
            this.btnClear.TabIndex = 124;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackToDoctorPage
            // 
            this.btnBackToDoctorPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDoctorPage.Location = new System.Drawing.Point(634, 12);
            this.btnBackToDoctorPage.Name = "btnBackToDoctorPage";
            this.btnBackToDoctorPage.Size = new System.Drawing.Size(116, 53);
            this.btnBackToDoctorPage.TabIndex = 127;
            this.btnBackToDoctorPage.Text = "Back To Doctor Page";
            this.btnBackToDoctorPage.UseVisualStyleBackColor = true;
            this.btnBackToDoctorPage.Click += new System.EventHandler(this.btnBackToDoctorPage_Click);
            // 
            // PatientMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToDoctorPage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtDoctorNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVaccinationHistory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMedications);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedicalHistoryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPatientMedicalHistory);
            this.Controls.Add(this.label1);
            this.Name = "PatientMedicalHistory";
            this.Text = "PatientMedicalHistory";
            this.Load += new System.EventHandler(this.PatientMedicalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedicalHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPatientMedicalHistory;
        private System.Windows.Forms.TextBox txtVaccinationHistory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMedications;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedicalHistoryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctorNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackToDoctorPage;
    }
}