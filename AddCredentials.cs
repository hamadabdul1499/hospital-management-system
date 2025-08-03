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
    public partial class AddCredentials : Form
    {
        public AddCredentials()
        {
            InitializeComponent();
        }

        private void btnAddCredentials_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtIDNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields before adding credentials.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (txtUser.Text.Trim().ToLower() == "hospital receptionist")
            {
                directoryPath = "HospitalReceptionistCredentials";
                filePath = Path.Combine(directoryPath, "receptionist_credentials.txt");
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] credentials = line.Split(':');
                if (credentials.Length == 3)
                {
                    string storedID = credentials[0].Trim();
                    string storedEmail = credentials[1].Trim();

                    if (id == storedID || email == storedEmail)
                    {
                        MessageBox.Show("Error: ID or Email already exists.");
                        return;
                    }
                }
            }

            // Append new credentials
            string newCredential = $"{id}: {email}: {password}";
            File.AppendAllText(filePath, newCredential + Environment.NewLine);

            MessageBox.Show("Credentials added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            this.Hide();

            HospitalAdminMainPage HospitalAdminMainPage = new HospitalAdminMainPage();

            HospitalAdminMainPage.Show();
        }
    }
}
