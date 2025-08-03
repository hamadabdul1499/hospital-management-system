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
using System.Xml.Linq;

namespace HospitalManagementSystem
{
    public partial class CheckInPatients: Form
    {
        public CheckInPatients()
        {
            InitializeComponent();
        }

        private void btnBackToReceptionistPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalReceptionistMainPage hospitalReceptionistMainPage = new HospitalReceptionistMainPage();
            hospitalReceptionistMainPage.Show();
        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM APPOINTMENT";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvCheckInPatients.DataSource = dt;

            conn.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            txtAppointmentID.Text = "";
            txtPatientID.Text = "";
            txtStaffID.Text = "";
            txtDateTime.Text = "";
            txtCheckInStatus.Text = "";

        }

        private void dgvCheckInPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAppointmentID.Text = dgvCheckInPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientID.Text = dgvCheckInPatients.SelectedRows[0].Cells[1].Value.ToString();
            txtStaffID.Text = dgvCheckInPatients.SelectedRows[0].Cells[2].Value.ToString();
            txtDateTime.Text = dgvCheckInPatients.SelectedRows[0].Cells[3].Value.ToString();
            txtCheckInStatus.Text = dgvCheckInPatients.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnCheckInPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAppointmentID.Text) || string.IsNullOrWhiteSpace(txtPatientID.Text) ||
                string.IsNullOrWhiteSpace(txtStaffID.Text) || string.IsNullOrWhiteSpace(txtDateTime.Text) || 
                string.IsNullOrWhiteSpace(txtCheckInStatus.Text))
            {
                MessageBox.Show("Please fill in all the fields before checking in a patient.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string editSQL = "UPDATE APPOINTMENT SET PATIENT_ID='" + txtPatientID.Text + "'," + "STAFF_ID='" + txtStaffID.Text + "'," + "APPOINTMENT_DATETIME='" + txtDateTime.Text + "'," + "APPOINTMENT_CHECKINSTATUS='" + txtCheckInStatus.Text + "' WHERE APPOINTMENT_ID='" + txtAppointmentID.Text + "'";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(editSQL, conn);
            int Details = cmd.ExecuteNonQuery();

            if (Details > 0)
            {
                MessageBox.Show("Patient Successfully Checked In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Check In Failed! No Check In was modified.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AmendDatabase(editSQL);
            LoadData();

        }
    }
}
