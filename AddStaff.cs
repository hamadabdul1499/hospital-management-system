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
    public partial class AddStaff: Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            this.Close();

            HospitalAdminMainPage HospitalAdminMainPage = new HospitalAdminMainPage();

            HospitalAdminMainPage.Show();
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



        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private string GenerateStaffID()
        {
            string newStaffID = "S001";
            string query = "SELECT STAFF_ID FROM STAFF ORDER BY STAFF_ID DESC LIMIT 1";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=hospitalmanagement.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastID = result.ToString();
                        int num = int.Parse(lastID.Substring(1)) + 1;
                        newStaffID = "S" + num.ToString("D3");
                    }
                }
            }
            return newStaffID;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtRole.Text) ||
                string.IsNullOrWhiteSpace(txtDOB.Text) || string.IsNullOrWhiteSpace(txtHomeAddress.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(txtRegistrationDate.Text) || string.IsNullOrWhiteSpace(txtWorkStatus.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text))
            {
                MessageBox.Show("Please fill in all the fields before adding the staff.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStaffID = GenerateStaffID();

            string addQuery = "INSERT INTO STAFF(STAFF_ID, STAFF_FULLNAME, STAFF_ROLE, STAFF_DATEOFBIRTH, STAFF_HOMEADDRESS, STAFF_PHONENUMBER, STAFF_EMAILADDRESS, STAFF_REGISTRATIONDATE, STAFF_WORKSTATUS, DEPARTMENT_ID) " +
                              "VALUES('" + newStaffID + "', '" + txtName.Text + "', '" + txtRole.Text + "', '" + txtDOB.Text + "', '" + txtHomeAddress.Text + "', '" + txtPhoneNumber.Text + "', '" + txtEmailAddress.Text + "', '" + txtRegistrationDate.Text + "', '" + txtWorkStatus.Text + "', '" + txtDepartmentID.Text + "')";

            AmendDatabase(addQuery);

            MessageBox.Show($"Staff {newStaffID} added to the database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
