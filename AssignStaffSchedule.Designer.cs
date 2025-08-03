namespace HospitalManagementSystem
{
    partial class AssignStaffSchedule
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
            this.dgvStaffSchedule = new System.Windows.Forms.DataGridView();
            this.btnBackToAdminPage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.txtScheduleTiming = new System.Windows.Forms.TextBox();
            this.btnAssignSchedule = new System.Windows.Forms.Button();
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffSchedule
            // 
            this.dgvStaffSchedule.AllowUserToAddRows = false;
            this.dgvStaffSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSchedule.Location = new System.Drawing.Point(121, 48);
            this.dgvStaffSchedule.MultiSelect = false;
            this.dgvStaffSchedule.Name = "dgvStaffSchedule";
            this.dgvStaffSchedule.ReadOnly = true;
            this.dgvStaffSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffSchedule.Size = new System.Drawing.Size(553, 150);
            this.dgvStaffSchedule.TabIndex = 76;
            this.dgvStaffSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffSchedule_CellClick);
            this.dgvStaffSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffSchedule_CellContentClick);
            // 
            // btnBackToAdminPage
            // 
            this.btnBackToAdminPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAdminPage.Location = new System.Drawing.Point(12, 395);
            this.btnBackToAdminPage.Name = "btnBackToAdminPage";
            this.btnBackToAdminPage.Size = new System.Drawing.Size(116, 53);
            this.btnBackToAdminPage.TabIndex = 81;
            this.btnBackToAdminPage.Text = "Back To Admin Main Page";
            this.btnBackToAdminPage.UseVisualStyleBackColor = true;
            this.btnBackToAdminPage.Click += new System.EventHandler(this.btnBackToAdminPage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 47);
            this.label5.TabIndex = 88;
            this.label5.Text = "Assign Staff Schedule";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(357, 303);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(142, 20);
            this.txtStaffID.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 90;
            this.label4.Text = "Staff ID";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(345, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 34);
            this.btnClear.TabIndex = 89;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "Schedule Timing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Department ID";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(357, 353);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(142, 20);
            this.txtDepartmentID.TabIndex = 94;
            // 
            // txtScheduleTiming
            // 
            this.txtScheduleTiming.Location = new System.Drawing.Point(357, 402);
            this.txtScheduleTiming.Name = "txtScheduleTiming";
            this.txtScheduleTiming.Size = new System.Drawing.Size(142, 20);
            this.txtScheduleTiming.TabIndex = 95;
            // 
            // btnAssignSchedule
            // 
            this.btnAssignSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignSchedule.Location = new System.Drawing.Point(538, 371);
            this.btnAssignSchedule.Name = "btnAssignSchedule";
            this.btnAssignSchedule.Size = new System.Drawing.Size(239, 77);
            this.btnAssignSchedule.TabIndex = 96;
            this.btnAssignSchedule.Text = "Assign Schedule";
            this.btnAssignSchedule.UseVisualStyleBackColor = true;
            this.btnAssignSchedule.Click += new System.EventHandler(this.btnAssignSchedule_Click);
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Location = new System.Drawing.Point(357, 260);
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.ReadOnly = true;
            this.txtScheduleID.Size = new System.Drawing.Size(142, 20);
            this.txtScheduleID.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 97;
            this.label3.Text = "Schedule ID";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.Location = new System.Drawing.Point(538, 288);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(239, 77);
            this.btnAddSchedule.TabIndex = 99;
            this.btnAddSchedule.Text = "Add New Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(538, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(239, 77);
            this.btnDelete.TabIndex = 100;
            this.btnDelete.Text = "Delete Schedule";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AssignStaffSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.txtScheduleID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAssignSchedule);
            this.Controls.Add(this.txtScheduleTiming);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBackToAdminPage);
            this.Controls.Add(this.dgvStaffSchedule);
            this.Name = "AssignStaffSchedule";
            this.Text = "AssignStaffSchedule";
            this.Load += new System.EventHandler(this.AssignStaffSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffSchedule;
        private System.Windows.Forms.Button btnBackToAdminPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtScheduleTiming;
        private System.Windows.Forms.Button btnAssignSchedule;
        private System.Windows.Forms.TextBox txtScheduleID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnDelete;
    }
}