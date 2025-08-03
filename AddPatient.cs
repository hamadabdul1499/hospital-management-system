using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HospitalManagementSystem
{
    public partial class AddPatient: Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            this.Close();

            HospitalAdminMainPage HospitalAdminMainPage = new HospitalAdminMainPage();

            HospitalAdminMainPage.Show();
        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        private string GeneratePatientID()
        {
            string newPatientID = "P001";
            string query = "SELECT PATIENT_ID FROM PATIENT ORDER BY PATIENT_ID DESC LIMIT 1";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastID = result.ToString();
                        int num = int.Parse(lastID.Substring(1)) + 1;
                        newPatientID = "P" + num.ToString("D3");
                    }
                }
            }
            return newPatientID;
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDOB.Text) ||
                string.IsNullOrWhiteSpace(txtHomeAddress.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(txtRegistrationDate.Text))
            {
                MessageBox.Show("Please fill in all the fields before adding the patient.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newPatientID = GeneratePatientID();

            string addQuery = "INSERT INTO PATIENT(PATIENT_ID, PATIENT_FULLNAME, PATIENT_DATEOFBIRTH, PATIENT_HOMEADDRESS, PATIENT_PHONENUMBER, PATIENT_EMAILADDRESS, PATIENT_REGISTRATIONDATE) " +
                              "VALUES('" + newPatientID + "', '" + txtName.Text + "', '" + txtDOB.Text + "', '" + txtHomeAddress.Text + "', '" + txtPhoneNumber.Text + "', '" + txtEmailAddress.Text + "', '" + txtRegistrationDate.Text + "')";

            AmendDatabase(addQuery);

            MessageBox.Show($"Patient {newPatientID} added to the database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtRegistrationDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
