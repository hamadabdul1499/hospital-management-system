namespace HospitalManagementSystem
{
    partial class PatientTreatmentNotes
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
            this.dgvPatientTreatmentNotes = new System.Windows.Forms.DataGridView();
            this.btnBackToDoctorPage = new System.Windows.Forms.Button();
            this.txtMedicationChanges = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTreatmentPlan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTreatmentNotesID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFollowUpDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.txtTimeStamp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientTreatmentNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 47);
            this.label1.TabIndex = 77;
            this.label1.Text = "Patient Treatment Notes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPatientTreatmentNotes
            // 
            this.dgvPatientTreatmentNotes.AllowUserToAddRows = false;
            this.dgvPatientTreatmentNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientTreatmentNotes.Location = new System.Drawing.Point(44, 80);
            this.dgvPatientTreatmentNotes.MultiSelect = false;
            this.dgvPatientTreatmentNotes.Name = "dgvPatientTreatmentNotes";
            this.dgvPatientTreatmentNotes.ReadOnly = true;
            this.dgvPatientTreatmentNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientTreatmentNotes.Size = new System.Drawing.Size(709, 150);
            this.dgvPatientTreatmentNotes.TabIndex = 78;
            this.dgvPatientTreatmentNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientTreatmentNotes_CellClick);
            // 
            // btnBackToDoctorPage
            // 
            this.btnBackToDoctorPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDoctorPage.Location = new System.Drawing.Point(650, 12);
            this.btnBackToDoctorPage.Name = "btnBackToDoctorPage";
            this.btnBackToDoctorPage.Size = new System.Drawing.Size(116, 53);
            this.btnBackToDoctorPage.TabIndex = 128;
            this.btnBackToDoctorPage.Text = "Back To Doctor Page";
            this.btnBackToDoctorPage.UseVisualStyleBackColor = true;
            this.btnBackToDoctorPage.Click += new System.EventHandler(this.btnBackToDoctorPage_Click);
            // 
            // txtMedicationChanges
            // 
            this.txtMedicationChanges.Location = new System.Drawing.Point(541, 287);
            this.txtMedicationChanges.Name = "txtMedicationChanges";
            this.txtMedicationChanges.Size = new System.Drawing.Size(247, 20);
            this.txtMedicationChanges.TabIndex = 140;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 25);
            this.label8.TabIndex = 139;
            this.label8.Text = "Medication Changes";
            // 
            // txtTreatmentPlan
            // 
            this.txtTreatmentPlan.Location = new System.Drawing.Point(524, 249);
            this.txtTreatmentPlan.Name = "txtTreatmentPlan";
            this.txtTreatmentPlan.Size = new System.Drawing.Size(264, 20);
            this.txtTreatmentPlan.TabIndex = 138;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 137;
            this.label7.Text = "Treatment Plan";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(211, 364);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(142, 20);
            this.txtDiagnosis.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 135;
            this.label6.Text = "Diagnosis";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(211, 326);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(142, 20);
            this.txtStaffID.TabIndex = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 133;
            this.label5.Text = "Staff ID";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(211, 287);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(142, 20);
            this.txtPatientID.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 131;
            this.label4.Text = "Patient ID";
            // 
            // txtTreatmentNotesID
            // 
            this.txtTreatmentNotesID.Location = new System.Drawing.Point(211, 249);
            this.txtTreatmentNotesID.Name = "txtTreatmentNotesID";
            this.txtTreatmentNotesID.ReadOnly = true;
            this.txtTreatmentNotesID.Size = new System.Drawing.Size(142, 20);
            this.txtTreatmentNotesID.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 129;
            this.label3.Text = "Treatment Notes ID";
            // 
            // txtFollowUpDate
            // 
            this.txtFollowUpDate.Location = new System.Drawing.Point(608, 320);
            this.txtFollowUpDate.Name = "txtFollowUpDate";
            this.txtFollowUpDate.Size = new System.Drawing.Size(142, 20);
            this.txtFollowUpDate.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 141;
            this.label2.Text = "Follow Up Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 143;
            this.label9.Text = "Additional Notes";
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(518, 354);
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.Size = new System.Drawing.Size(270, 20);
            this.txtAdditionalNotes.TabIndex = 144;
            // 
            // txtTimeStamp
            // 
            this.txtTimeStamp.Location = new System.Drawing.Point(608, 393);
            this.txtTimeStamp.Name = "txtTimeStamp";
            this.txtTimeStamp.Size = new System.Drawing.Size(142, 20);
            this.txtTimeStamp.TabIndex = 146;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 145;
            this.label10.Text = "Time Stamp";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(344, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 34);
            this.btnClear.TabIndex = 147;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(230, 402);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 36);
            this.btnEdit.TabIndex = 148;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PatientTreatmentNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTimeStamp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAdditionalNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFollowUpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedicationChanges);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTreatmentPlan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTreatmentNotesID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackToDoctorPage);
            this.Controls.Add(this.dgvPatientTreatmentNotes);
            this.Controls.Add(this.label1);
            this.Name = "PatientTreatmentNotes";
            this.Text = "PatientTreatmentNotes";
            this.Load += new System.EventHandler(this.PatientTreatmentNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientTreatmentNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPatientTreatmentNotes;
        private System.Windows.Forms.Button btnBackToDoctorPage;
        private System.Windows.Forms.TextBox txtMedicationChanges;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTreatmentPlan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTreatmentNotesID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFollowUpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.TextBox txtTimeStamp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
    }
}