using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class HospitalAdminMainPage: Form
    {
        public HospitalAdminMainPage()
        {
            InitializeComponent();
        }

        private void HospitalAdminMainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage MainPage = new MainPage();
            MainPage.Show();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddPatient AddPatient = new AddPatient();
            AddPatient.Show();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddStaff AddStaff = new AddStaff();
            AddStaff.Show();
        }

        private void btnUpdateStaffInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdateStaffInfo UpdateStaffInfo = new UpdateStaffInfo();
            UpdateStaffInfo.Show();
        }

        private void btnUpdatePatientsInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdatePatientInfo UpdatePatientInfo = new UpdatePatientInfo();
            UpdatePatientInfo.Show();
        }

        private void btnStaffSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();

            AssignStaffSchedule AssignStaffSchedule = new AssignStaffSchedule();
            AssignStaffSchedule.Show();
        }

        private void btnStaffDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();

            AssignStaffDepartment AssignStaffDepartment = new AssignStaffDepartment();
            AssignStaffDepartment.Show();
        }

        private void btnResetPasswords_Click(object sender, EventArgs e)
        {
            this.Hide();

            ResetPasswords ResetPasswords = new ResetPasswords();
            ResetPasswords.Show();
        }

        private void btnAddCredentials_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddCredentials AddCredentials = new AddCredentials();
            AddCredentials.Show();
        }
    }
}
