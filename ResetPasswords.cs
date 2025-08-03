using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagementSystem
{
    public partial class ResetPasswords : Form
    {
        public ResetPasswords()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtIDNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields before resetting the password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the password and confirm password match
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match. Please re-enter the passwords.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = txtIDNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            string directoryPath = "HospitalAdminCredentials";
            string filePath = Path.Combine(directoryPath, "admin_credentials.txt");

            if (txtUser.Text.Trim().ToLower() == "doctor")
            {
                directoryPath = "DoctorCredentials";
                filePath = Path.Combine(directoryPath, "doctor_credentials.txt");
            }

            if (txtUser.Text.Trim().ToLower() == "hospital receptionist")
            {
                directoryPath = "HospitalReceptionistCredentials";
                filePath = Path.Combine(directoryPath, "receptionist_credentials.txt");
            }

            // Check if the credentials file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Error: Credentials file not found at:\n" + filePath);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool resetPassword = false;

            // Iterate through the file and check if the ID and email match
            for (int i = 0; i < lines.Length; i++)
            {
                string[] credentials = lines[i].Split(':');

                if (credentials.Length != 3)
                {
                    MessageBox.Show("Error: Invalid credentials file format.");
                    return;
                }

                string storedID = credentials[0].Trim();
                string storedEmail = credentials[1].Trim();

                // If ID and email match, reset the password
                if (id == storedID && email == storedEmail)
                {
                    lines[i] = $"{storedID}: {storedEmail}: {password}";
                    resetPassword = true;
                    break;
                }
            }

            // Write the updated lines back to the file if password reset was successful
            if (resetPassword)
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Password reset successful!");
            }
            else
            {
                MessageBox.Show("Error: ID and email not found.");
            }
        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            this.Hide();

            HospitalAdminMainPage HospitalAdminMainPage = new HospitalAdminMainPage();

            HospitalAdminMainPage.Show();
        }
    }
}