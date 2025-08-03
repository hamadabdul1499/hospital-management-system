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
    public partial class PatientMedicalHistory: Form
    {
        public PatientMedicalHistory()
        {
            InitializeComponent();
        }

        private void btnBackToDoctorPage_Click(object sender, EventArgs e)
        {
            this.Hide();

            DoctorMainPage doctorMainPage = new DoctorMainPage();

            doctorMainPage.Show();
        }

        private void PatientMedicalHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM MEDICALHISTORY";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvPatientMedicalHistory.DataSource = dt;

            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            txtMedicalHistoryID.Text = "";
            txtPatientID.Text = "";
            txtStaffID.Text = "";
            txtDiagnosis.Text = "";
            txtMedications.Text = "";
            txtVaccinationHistory.Text = "";
            txtDoctorNotes.Text = "";

        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            ClearTextFields();
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

        private void dgvPatientMedicalHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicalHistoryID.Text = dgvPatientMedicalHistory.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientID.Text = dgvPatientMedicalHistory.SelectedRows[0].Cells[1].Value.ToString();
            txtStaffID.Text = dgvPatientMedicalHistory.SelectedRows[0].Cells[2].Value.ToString();
            txtDiagnosis.Text = dgvPatientMedicalHistory.SelectedRows[0].Cells[3].Value.ToString();
            txtMedications.Text = dgvPatientMedicalHistory.SelectedRows[0].Cells[4].Value.ToString();
            txtVaccinationHistory.Text = dgvPatientMedicalHistory.SelectedRows[0].Cells[5].Value.ToString();
            txtDoctorNotes.Text = dgvPatientMedicalHistory.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicalHistoryID.Text) ||
                string.IsNullOrWhiteSpace(txtPatientID.Text) ||
                string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnosis.Text) ||
                string.IsNullOrWhiteSpace(txtMedications.Text) ||
                string.IsNullOrWhiteSpace(txtVaccinationHistory.Text) ||
                string.IsNullOrWhiteSpace(txtDoctorNotes.Text))
            {
                MessageBox.Show("All fields must be filled out before updating Patients Medical History.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string editSQL = "UPDATE MEDICALHISTORY SET PATIENT_ID='" + txtPatientID.Text + "'," + "STAFF_ID='" + txtStaffID.Text + "'," + "MEDICALHISTORY_DIAGNOSIS='" + txtDiagnosis.Text + "'," + "MEDICALHISTORY_CURRENTPREVIOUSMEDICATIONS='" + txtMedications.Text + "'," + "MEDICALHISTORY_VACCINATIONHISTORY='" + txtVaccinationHistory.Text + "'," + "MEDICALHISTORY_DOCTORNOTES='" + txtDoctorNotes.Text + "' WHERE MEDICALHISTORY_ID='" + txtMedicalHistoryID.Text + "'";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(editSQL, conn);
            int Details = cmd.ExecuteNonQuery();

            if (Details > 0)
            {
                MessageBox.Show("Medical History updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Medical History Update failed! No records were modified.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AmendDatabase(editSQL);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this medical history?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string delSQL = "DELETE FROM MEDICALHISTORY WHERE MEDICALHISTORY_ID = '" + txtMedicalHistoryID.Text + "'";
                    AmendDatabase(delSQL);

                    MessageBox.Show("Medical History deleted from the system successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
        }
    }
}
