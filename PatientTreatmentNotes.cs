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

namespace HospitalManagementSystem
{
    public partial class PatientTreatmentNotes: Form
    {
        public PatientTreatmentNotes()
        {
            InitializeComponent();
        }

        private void btnBackToDoctorPage_Click(object sender, EventArgs e)
        {
            this.Hide();

            DoctorMainPage doctorMainPage = new DoctorMainPage();

            doctorMainPage.Show();
        }

        private void PatientTreatmentNotes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM TREATMENTNOTES";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvPatientTreatmentNotes.DataSource = dt;

            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            txtTreatmentNotesID.Text = "";
            txtPatientID.Text = "";
            txtStaffID.Text = "";
            txtDiagnosis.Text = "";
            txtTreatmentPlan.Text = "";
            txtMedicationChanges.Text = "";
            txtFollowUpDate.Text = "";
            txtAdditionalNotes.Text = "";
            txtTimeStamp.Text = "";
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

        private void dgvPatientTreatmentNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTreatmentNotesID.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientID.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[1].Value.ToString();
            txtStaffID.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[2].Value.ToString();
            txtDiagnosis.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[3].Value.ToString();
            txtTreatmentPlan.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[4].Value.ToString();
            txtMedicationChanges.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[5].Value.ToString();
            txtFollowUpDate.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[6].Value.ToString();
            txtAdditionalNotes.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[7].Value.ToString();
            txtTimeStamp.Text = dgvPatientTreatmentNotes.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTreatmentNotesID.Text) ||
                string.IsNullOrWhiteSpace(txtPatientID.Text) ||
                string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnosis.Text) ||
                string.IsNullOrWhiteSpace(txtTreatmentPlan.Text) ||
                string.IsNullOrWhiteSpace(txtMedicationChanges.Text) ||
                string.IsNullOrWhiteSpace(txtFollowUpDate.Text) ||
                string.IsNullOrWhiteSpace(txtAdditionalNotes.Text) ||
                string.IsNullOrWhiteSpace(txtTimeStamp.Text))
            {
                MessageBox.Show("All fields must be filled out before updating Patients Treatment Notes.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string editSQL = "UPDATE TREATMENTNOTES SET PATIENT_ID='" + txtPatientID.Text + "'," + "STAFF_ID='" + txtStaffID.Text + "'," + "TREATMENTNOTES_DIAGNOSIS='" + txtDiagnosis.Text + "'," + "TREATMENTNOTES_TREATMENTPLAN='" + txtTreatmentPlan.Text + "'," + "TREATMENTNOTES_MEDICATIONCHANGES='" + txtMedicationChanges.Text + "'," + "TREATMENTNOTES_FOLLOWUPDATE='" + txtFollowUpDate.Text + "'," + "TREATMENTNOTES_ADDITIONALNOTES='" + txtAdditionalNotes.Text + "', " + "TREATMENTNOTES_TIMESTAMP='" + txtTimeStamp.Text + "' WHERE TREATMENTNOTES_ID='" + txtTreatmentNotesID.Text + "'";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(editSQL, conn);
            int Details = cmd.ExecuteNonQuery();

            if (Details > 0)
            {
                MessageBox.Show("Treatment Notes updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Treatment Notes Update failed! No records were modified.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AmendDatabase(editSQL);
            LoadData();
        

         }
    }
}
