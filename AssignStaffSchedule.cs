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
    public partial class AssignStaffSchedule: Form
    {
        public AssignStaffSchedule()
        {
            InitializeComponent();
        }

        private void dgvStaffSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source =hospitalmanagement.db");
            conn.Open();

            string query = "SELECT * FROM SCHEDULE";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvStaffSchedule.DataSource = dt;

            conn.Close();
        }

        private void AssignStaffSchedule_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void ClearTextFields()
        {
            txtScheduleID.Text = "";
            txtStaffID.Text = "";
            txtDepartmentID.Text = "";
            txtScheduleTiming.Text = "";

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

        private void btnAssignSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtScheduleID.Text) ||
                string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text) ||
                string.IsNullOrWhiteSpace(txtScheduleTiming.Text))
            {
                MessageBox.Show("All fields must be filled out before assigning staff schedule.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string departmentID = txtDepartmentID.Text.Trim().ToLower();
            if (!IsValidDepartmentID(departmentID))
            {
                MessageBox.Show("Invalid Department ID! Please enter a value between d001 and d010.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string editSQL = "UPDATE SCHEDULE SET SCHEDULE_ID='" +txtScheduleID.Text+ "'," + "DEPARTMENT_ID='" + txtDepartmentID.Text + "'," + "SCHEDULE_TIMING='" + txtScheduleTiming.Text + "' WHERE STAFF_ID='" + txtStaffID.Text + "'";
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(editSQL, conn);
            int Details = cmd.ExecuteNonQuery();

            if (Details > 0)
            {
                MessageBox.Show("Staff Schedule updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed! No Staff Schedule has been modified.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AmendDatabase(editSQL);
            LoadData();
        }

            private bool IsValidDepartmentID(string departmentID)
        {
            return departmentID.Length == 4 && departmentID.StartsWith("d") &&
                   int.TryParse(departmentID.Substring(1), out int id) && id >= 1 && id <= 10;
        }
        private void dgvStaffSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtScheduleID.Text = dgvStaffSchedule.SelectedRows[0].Cells[0].Value.ToString();
            txtStaffID.Text = dgvStaffSchedule.SelectedRows[0].Cells[1].Value.ToString();
            txtDepartmentID.Text = dgvStaffSchedule.SelectedRows[0].Cells[2].Value.ToString();
            txtScheduleTiming.Text = dgvStaffSchedule.SelectedRows[0].Cells[3].Value.ToString();

        }

        private string GenerateScheduleID()
        {
            string newScheduleID = "SCH001";
            string query = "SELECT SCHEDULE_ID FROM SCHEDULE ORDER BY SCHEDULE_ID DESC LIMIT 1";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastID = result.ToString();
                        int num = int.Parse(lastID.Substring(3)) + 1;
                        newScheduleID = "SCH" + num.ToString("D3");
                    }
                }
            }
            return newScheduleID;
        }
        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text) ||
                string.IsNullOrWhiteSpace(txtScheduleTiming.Text))
            {
                MessageBox.Show("All fields must be filled out before updating staff schedule.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newScheduleID = GenerateScheduleID();

            string addQuery = "INSERT INTO SCHEDULE(SCHEDULE_ID, STAFF_ID, DEPARTMENT_ID, SCHEDULE_TIMING) " +
                              "VALUES('" + newScheduleID + "', '" + txtStaffID.Text + "', '" + txtDepartmentID.Text + "', '" + txtScheduleTiming.Text + "')";

            AmendDatabase(addQuery);

            MessageBox.Show("Schedule added to the database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string delSQL = "DELETE FROM SCHEDULE WHERE SCHEDULE_ID = '" + txtScheduleID.Text + "'";
                AmendDatabase(delSQL);

                MessageBox.Show("Schedule deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
        }
    }
    
}
