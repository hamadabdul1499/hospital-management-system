namespace HospitalManagementSystem
{
    partial class AssignStaffDepartment
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
            this.dgvStaffDepartment = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackToAdminPage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAssignDepartment = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffDepartment
            // 
            this.dgvStaffDepartment.AllowUserToAddRows = false;
            this.dgvStaffDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffDepartment.Location = new System.Drawing.Point(72, 49);
            this.dgvStaffDepartment.MultiSelect = false;
            this.dgvStaffDepartment.Name = "dgvStaffDepartment";
            this.dgvStaffDepartment.ReadOnly = true;
            this.dgvStaffDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffDepartment.Size = new System.Drawing.Size(644, 150);
            this.dgvStaffDepartment.TabIndex = 75;
            this.dgvStaffDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffDepartment_CellClick);
            this.dgvStaffDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffDepartment_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 284);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Full Name";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(218, 330);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(142, 20);
            this.txtDepartmentID.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Department ID";
            // 
            // btnBackToAdminPage
            // 
            this.btnBackToAdminPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAdminPage.Location = new System.Drawing.Point(12, 394);
            this.btnBackToAdminPage.Name = "btnBackToAdminPage";
            this.btnBackToAdminPage.Size = new System.Drawing.Size(116, 53);
            this.btnBackToAdminPage.TabIndex = 80;
            this.btnBackToAdminPage.Text = "Back To Admin Main Page";
            this.btnBackToAdminPage.UseVisualStyleBackColor = true;
            this.btnBackToAdminPage.Click += new System.EventHandler(this.btnBackToAdminPage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(350, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 34);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAssignDepartment
            // 
            this.btnAssignDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignDepartment.Location = new System.Drawing.Point(268, 361);
            this.btnAssignDepartment.Name = "btnAssignDepartment";
            this.btnAssignDepartment.Size = new System.Drawing.Size(239, 77);
            this.btnAssignDepartment.TabIndex = 82;
            this.btnAssignDepartment.Text = "Assign Department";
            this.btnAssignDepartment.UseVisualStyleBackColor = true;
            this.btnAssignDepartment.Click += new System.EventHandler(this.btnAssignDepartment_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(533, 284);
            this.dgvDepartments.MultiSelect = false;
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(255, 150);
            this.dgvDepartments.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 21);
            this.label2.TabIndex = 84;
            this.label2.Text = "Select The Department From The List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Staff ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(218, 246);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(142, 20);
            this.txtStaffID.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 47);
            this.label5.TabIndex = 87;
            this.label5.Text = "Assign Staff To Department";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AssignStaffDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.btnAssignDepartment);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackToAdminPage);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStaffDepartment);
            this.Name = "AssignStaffDepartment";
            this.Text = "AssignStaffSchedule";
            this.Load += new System.EventHandler(this.AssignStaffDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffDepartment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToAdminPage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAssignDepartment;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label5;
    }
}