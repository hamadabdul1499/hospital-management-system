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
    public partial class PatientInfo: Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }

        private void dgvPatientsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientInfo_Load(object sender, EventArgs e)
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

            dgvPatientsInfo.DataSource = dt;

            conn.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a patient name or ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvPatientsInfo.DataSource is DataTable dt)
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

                dgvPatientsInfo.DataSource = dv.ToTable();
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBackToReceptionistPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalReceptionistMainPage hospitalReceptionistMainPage = new HospitalReceptionistMainPage();
            hospitalReceptionistMainPage.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            txtName.Text = "";
            txtDOB.Text = "";
            txtHomeAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtRegistrationDate.Text = "";

        }

        private void dgvPatientsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvPatientsInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtDOB.Text = dgvPatientsInfo.SelectedRows[0].Cells[2].Value.ToString();
            txtHomeAddress.Text = dgvPatientsInfo.SelectedRows[0].Cells[3].Value.ToString();
            txtPhoneNumber.Text = dgvPatientsInfo.SelectedRows[0].Cells[4].Value.ToString();
            txtEmailAddress.Text = dgvPatientsInfo.SelectedRows[0].Cells[5].Value.ToString();
            txtRegistrationDate.Text = dgvPatientsInfo.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
