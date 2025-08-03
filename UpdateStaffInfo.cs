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
    public partial class UpdateStaffInfo: Form
    {
        public UpdateStaffInfo()
        {
            InitializeComponent();
        }

        private void UpdateStaffInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM STAFF";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvStaffInfo.DataSource = dt;

            conn.Close();
        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
                this.Hide();

                HospitalAdminMainPage HospitalAdminMainPage = new HospitalAdminMainPage();

                HospitalAdminMainPage.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
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




        private void ClearTextFields()
        {
            txtStaffID.Text = "";
            txtName.Text = "";
            txtRole.Text = "";
            txtDOB.Text = "";
            txtHomeAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtRegistrationDate.Text = "";
            txtWorkStatus.Text = "";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtRole.Text) ||
                string.IsNullOrWhiteSpace(txtDOB.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtHomeAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) ||
                string.IsNullOrWhiteSpace(txtRegistrationDate.Text) ||
                string.IsNullOrWhiteSpace(txtWorkStatus.Text))
            {
                MessageBox.Show("All fields must be filled out before updating staff details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string editSQL = "UPDATE STAFF SET STAFF_FULLNAME='" + txtName.Text + "'," + "STAFF_ROLE='" + txtRole.Text + "'," + "STAFF_DATEOFBIRTH='" + txtDOB.Text + "'," + "STAFF_HOMEADDRESS='" + txtHomeAddress.Text + "',  " + "STAFF_PHONENUMBER='" + txtPhoneNumber.Text + "', " + "STAFF_EMAILADDRESS='" + txtEmailAddress.Text + "'," + "STAFF_REGISTRATIONDATE='" +txtRegistrationDate.Text + "'," + "STAFF_WORKSTATUS='" + txtWorkStatus.Text + "' WHERE STAFF_ID='" + txtStaffID.Text + "'";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(editSQL, conn);
            int Details = cmd.ExecuteNonQuery();

            if (Details > 0)
            {
                MessageBox.Show("Staff details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed! No records were modified.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AmendDatabase(editSQL);
            LoadData();
        }

        private void dgvStaffInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStaffID.Text = dgvStaffInfo.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvStaffInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtRole.Text = dgvStaffInfo.SelectedRows[0].Cells[2].Value.ToString();
            txtDOB.Text = dgvStaffInfo.SelectedRows[0].Cells[3].Value.ToString();
            txtHomeAddress.Text = dgvStaffInfo.SelectedRows[0].Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgvStaffInfo.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailAddress.Text = dgvStaffInfo.SelectedRows[0].Cells[6].Value.ToString();
            txtRegistrationDate.Text = dgvStaffInfo.SelectedRows[0].Cells[7].Value.ToString();
            txtWorkStatus.Text = dgvStaffInfo.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string delSQL = "DELETE FROM STAFF WHERE STAFF_ID = '" + txtStaffID.Text + "'";
                AmendDatabase(delSQL);

                MessageBox.Show("Staff member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
