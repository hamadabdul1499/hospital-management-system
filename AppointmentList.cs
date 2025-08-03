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
    public partial class Appointment_List : Form
    {
        public Appointment_List()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                LoadData();
                return;
            }

            if (dgvAppointmentList.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Appointment_DateTime LIKE '%{searchValue}%'";
                if (dv.Count > 0)
                {
                    MessageBox.Show("Appointments found for the selected date!", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No appointments found for the selected date.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvAppointmentList.DataSource = dv.ToTable();
            }
        }

        private void Appointment_List_Load(object sender, EventArgs e)
        {
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

            dgvAppointmentList.DataSource = dt;

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

            ClearTextFields();
        }


        private void dgvAppointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBackToReceptionistPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HospitalReceptionistMainPage hospitalReceptionistMainPage = new HospitalReceptionistMainPage();
            hospitalReceptionistMainPage.Show();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string delSQL = "DELETE FROM APPOINTMENT WHERE APPOINTMENT_ID = '" + txtAppointmentID.Text + "'";
                AmendDatabase(delSQL);

                MessageBox.Show("Appointment deleted from the system successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            txtAppointmentID.Text = "";
        }

        private void dgvAppointmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAppointmentID.Text = dgvAppointmentList.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
