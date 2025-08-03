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
    public partial class Appointments: Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                LoadData();
                return;
            }

            if (dgvAppointment.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Staff_ID LIKE '%{searchValue}%'";
                if (dv.Count > 0)
                {
                    MessageBox.Show("Appointments found for this staff!", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No appointments found for this staff.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvAppointment.DataSource = dv.ToTable();
            }
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

            dgvAppointment.DataSource = dt;

            conn.Close();
        }

        private void btnBackToDoctorPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorMainPage DoctorMainPage = new DoctorMainPage();
            DoctorMainPage.Show();
        }

        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShowAppointments_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAppointmentID.Text = dgvAppointment.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientID.Text = dgvAppointment.SelectedRows[0].Cells[1].Value.ToString();
            txtStaffID.Text = dgvAppointment.SelectedRows[0].Cells[2].Value.ToString();
            txtDateTime.Text = dgvAppointment.SelectedRows[0].Cells[3].Value.ToString();
            txtCheckInStatus.Text = dgvAppointment.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
