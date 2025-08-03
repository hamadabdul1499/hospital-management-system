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
    public partial class AssignStaffDepartment: Form
    {
        public AssignStaffDepartment()
        {
            InitializeComponent();
        }

        private void AssignStaffDepartment_Load(object sender, EventArgs e)
        {
            LoadData1();
            LoadData2();
        }

        private void LoadData1()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM STAFF";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvStaffDepartment.DataSource = dt;

            conn.Close();
        }

        private void dgvStaffDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            this.Hide();

            HospitalAdminMainPage HospitalAdminMainPage = new HospitalAdminMainPage();

            HospitalAdminMainPage.Show();
        }

        private void dgvStaffDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStaffID.Text = dgvStaffDepartment.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvStaffDepartment.SelectedRows[0].Cells[1].Value.ToString();
            txtDepartmentID.Text = dgvStaffDepartment.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            txtStaffID.Text = "";
            txtName.Text = "";
            txtDepartmentID.Text = "";

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

        private void btnAssignDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text))
            {
                MessageBox.Show("All fields must be filled out before updating staff department.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string departmentID = txtDepartmentID.Text.Trim().ToLower();
            if (!IsValidDepartmentID(departmentID))
            {
                MessageBox.Show("Invalid Department ID! Please enter a value between d001 and d010.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string editSQL = "UPDATE STAFF SET STAFF_FULLNAME='" + txtName.Text + "'," + "DEPARTMENT_ID='" + txtDepartmentID.Text + "' WHERE STAFF_ID='" + txtStaffID.Text + "'";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(editSQL, conn);
            int Details = cmd.ExecuteNonQuery();

            if (Details > 0)
            {
                MessageBox.Show("Staff Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed! No Staff Department has been modified.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AmendDatabase(editSQL);
            LoadData1();
        }

        private bool IsValidDepartmentID(string departmentID)
        {
            return departmentID.Length == 4 && departmentID.StartsWith("d") &&
                   int.TryParse(departmentID.Substring(1), out int id) && id >= 1 && id <= 10;
        }

        private void LoadData2()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM DEPARTMENT";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvDepartments.DataSource = dt;

            conn.Close();
        }
    }
}
