namespace HospitalManagementSystem
{
    partial class MainPage
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
            this.btnhospitaladminlogin = new System.Windows.Forms.Button();
            this.btnhospitalreceptionistlogin = new System.Windows.Forms.Button();
            this.btndoctorlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "PineView Health Hospital";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnhospitaladminlogin
            // 
            this.btnhospitaladminlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhospitaladminlogin.Location = new System.Drawing.Point(12, 201);
            this.btnhospitaladminlogin.Name = "btnhospitaladminlogin";
            this.btnhospitaladminlogin.Size = new System.Drawing.Size(239, 77);
            this.btnhospitaladminlogin.TabIndex = 1;
            this.btnhospitaladminlogin.Text = "Hospital Admin Login";
            this.btnhospitaladminlogin.UseVisualStyleBackColor = true;
            this.btnhospitaladminlogin.Click += new System.EventHandler(this.btnhospitaladminlogin_Click);
            // 
            // btnhospitalreceptionistlogin
            // 
            this.btnhospitalreceptionistlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhospitalreceptionistlogin.Location = new System.Drawing.Point(279, 201);
            this.btnhospitalreceptionistlogin.Name = "btnhospitalreceptionistlogin";
            this.btnhospitalreceptionistlogin.Size = new System.Drawing.Size(239, 77);
            this.btnhospitalreceptionistlogin.TabIndex = 2;
            this.btnhospitalreceptionistlogin.Text = "Hospital Receptionist Login";
            this.btnhospitalreceptionistlogin.UseVisualStyleBackColor = true;
            this.btnhospitalreceptionistlogin.Click += new System.EventHandler(this.btnhospitalreceptionistlogin_Click);
            // 
            // btndoctorlogin
            // 
            this.btndoctorlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoctorlogin.Location = new System.Drawing.Point(549, 201);
            this.btndoctorlogin.Name = "btndoctorlogin";
            this.btndoctorlogin.Size = new System.Drawing.Size(239, 77);
            this.btndoctorlogin.TabIndex = 3;
            this.btndoctorlogin.Text = "Doctor Login";
            this.btndoctorlogin.UseVisualStyleBackColor = true;
            this.btndoctorlogin.Click += new System.EventHandler(this.btndoctorlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndoctorlogin);
            this.Controls.Add(this.btnhospitalreceptionistlogin);
            this.Controls.Add(this.btnhospitaladminlogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhospitaladminlogin;
        private System.Windows.Forms.Button btnhospitalreceptionistlogin;
        private System.Windows.Forms.Button btndoctorlogin;
    }
}

