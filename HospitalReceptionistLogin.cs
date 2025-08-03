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

namespace HospitalManagementSystem
{
    public partial class HospitalReceptionistLogin: Form
    {
        public HospitalReceptionistLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbacktomenu_Click(object sender, EventArgs e)
        {
            this.Close();

            MainPage MainPage = new MainPage();
            MainPage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string id = txtIDNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            string directoryPath = "HospitalReceptionistCredentials";
            string filePath = Path.Combine(directoryPath, "receptionist_credentials.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Error: Credentials file not found at:\n" + filePath);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool loginSuccess = false;

            foreach (var line in lines)
            {
                string[] credentials = line.Split(':');

                if (credentials.Length != 3)
                {
                    MessageBox.Show("Error: Invalid credentials file format.");
                    return;
                }

                string storedID = credentials[0].Trim();
                string storedEmail = credentials[1].Trim();
                string storedPassword = credentials[2].Trim();

                if (id == storedID && email == storedEmail && password == storedPassword)
                {
                    MessageBox.Show("Login successful!");
                    this.Close();
                    HospitalReceptionistMainPage HospitalReceptionistMainPage = new HospitalReceptionistMainPage();
                    HospitalReceptionistMainPage.Show();
                    loginSuccess = true;
                    break;
                }
            }

            // If login was not successful, show the error message
            if (!loginSuccess)
            {
                MessageBox.Show("Error: Invalid ID, email, or password.");
            }
        }

        private void HospitalReceptionistLogin_Load(object sender, EventArgs e)
        {

        }
    }

 }

