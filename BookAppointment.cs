using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagementSystem
{
    public partial class BookAppointment: Form
    {
        public BookAppointment()
        {
            InitializeComponent();
        }

        private void btnBackToReceptionistPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalReceptionistMainPage hospitalReceptionistMainPage = new HospitalReceptionistMainPage();
            hospitalReceptionistMainPage.Show();
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

        private string GenerateAppointmentID()
        {
            string newAppointmentID = "A001";
            string query = "SELECT APPOINTMENT_ID FROM APPOINTMENT ORDER BY APPOINTMENT_ID DESC LIMIT 1";

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
                        newAppointmentID = "A" + num.ToString("D3");
                    }
                }
            }
            return newAppointmentID;
        }


        private bool RecordExists(string tableName, string columnName, string id)
        {
            string query = "SELECT COUNT(*) FROM " + tableName + " WHERE " + columnName + " = '" + id + "'";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private void txtCheckInStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtAppointmentDateTime.Text) || string.IsNullOrWhiteSpace(txtCheckInStatus.Text))
            {
                MessageBox.Show("Please fill in all the fields before booking the appointment.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!RecordExists("PATIENT", "PATIENT_ID", txtPatientID.Text))
            {
                MessageBox.Show("Error: Patient ID does not exist in the system.", "Invalid Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!RecordExists("STAFF", "STAFF_ID", txtStaffID.Text))
            {
                MessageBox.Show("Error: Staff ID does not exist in the system.", "Invalid Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(RecordExists("APPOINTMENT","APPOINTMENT_DATETIME", txtAppointmentDateTime.Text))
            {
                MessageBox.Show("Error: Appointment with the same date and time already exists.", "Invalid Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newAppointmentID = GenerateAppointmentID();

            string addQuery = "INSERT INTO APPOINTMENT(APPOINTMENT_ID, PATIENT_ID, STAFF_ID, APPOINTMENT_DATETIME, APPOINTMENT_CHECKINSTATUS) " +
                              "VALUES('" + newAppointmentID + "', '" + txtPatientID.Text + "', '" + txtStaffID.Text + "', '" + txtAppointmentDateTime.Text + "', '" + txtCheckInStatus.Text + "')";

            AmendDatabase(addQuery);

            MessageBox.Show($"Appointment {newAppointmentID} has been booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
