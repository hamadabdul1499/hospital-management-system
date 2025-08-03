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
    public partial class HospitalReceptionistMainPage: Form
    {
        public HospitalReceptionistMainPage()
        {
            InitializeComponent();
        }

        private void HospitalReceptionistMainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage MainPage = new MainPage();
            MainPage.Show();
        }

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            this.Hide();

            Appointment_List AppointmentList = new Appointment_List();
            AppointmentList.Show();
        }

        private void btnPatientsInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            PatientInfo PatientInfo = new PatientInfo();
            PatientInfo.Show();
        }

        private void btnCheckInPatients_Click(object sender, EventArgs e)
        {
            this.Hide();

            CheckInPatients CheckInPatients = new CheckInPatients();
            CheckInPatients.Show();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();

            BookAppointment BookAppointment = new BookAppointment();
            BookAppointment.Show();
        }
    }
}
