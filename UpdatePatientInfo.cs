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
    public partial class UpdatePatientInfo: Form
    {
        public UpdatePatientInfo()
        {
            InitializeComponent();
        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            this.Hide();

            HospitalAdminMainPage HospitalAdminMainPage = new HospitalAdminMainPage();

            HospitalAdminMainPage.Show();
        }

        private void UpdatePatientInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM PATIENT";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvPatientInfo.DataSource = dt;

            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            txtPatientID.Text = "";
            txtName.Text = "";
            txtDOB.Text = "";
            txtHomeAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtRegistrationDate.Text = "";

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDOB.Text) ||
                string.IsNullOrWhiteSpace(txtHomeAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) ||
                string.IsNullOrWhiteSpace(txtRegistrationDate.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("All fields must be filled out before updating Patients details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string editSQL = "UPDATE PATIENT SET PATIENT_FULLNAME='" + txtName.Text + "'," + "PATIENT_DATEOFBIRTH='" + txtDOB.Text + "'," + "PATIENT_HOMEADDRESS='" + txtHomeAddress.Text + "'," + "PATIENT_PHONENUMBER='" + txtPhoneNumber.Text + "'," + "PATIENT_EMAILADDRESS='" + txtEmailAddress.Text + "'," + "PATIENT_REGISTRATIONDATE='" + txtRegistrationDate.Text + "' WHERE PATIENT_ID='" + txtPatientID.Text + "'";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(editSQL, conn);
            int Details = cmd.ExecuteNonQuery();

            if (Details > 0)
            {
                MessageBox.Show("Patient details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed! No records were modified.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AmendDatabase(editSQL);
            LoadData();
        }

        private void dgvPatientInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatientID.Text = dgvPatientInfo.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvPatientInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtDOB.Text = dgvPatientInfo.SelectedRows[0].Cells[2].Value.ToString();
            txtHomeAddress.Text = dgvPatientInfo.SelectedRows[0].Cells[3].Value.ToString();
            txtPhoneNumber.Text = dgvPatientInfo.SelectedRows[0].Cells[4].Value.ToString();
            txtEmailAddress.Text = dgvPatientInfo.SelectedRows[0].Cells[5].Value.ToString();
            txtRegistrationDate.Text = dgvPatientInfo.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string delSQL = "DELETE FROM PATIENT WHERE PATIENT_ID = '" + txtPatientID.Text + "'";
                AmendDatabase(delSQL);

                MessageBox.Show("Patient deleted from the system successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a patient name or ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvPatientInfo.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Patient_FullName LIKE '%{searchValue}%' OR Patient_ID LIKE '%{searchValue}%'";
                if (dv.Count > 0)
                {
                    MessageBox.Show("Patient Found", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Patient Not Found In The System", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvPatientInfo.DataSource = dv.ToTable();
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

