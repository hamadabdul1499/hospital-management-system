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
    public partial class DoctorMainPage: Form
    {
        public DoctorMainPage()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage MainPage = new MainPage();
            MainPage.Show();
        }

        private void btnPatientMedicalHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMedicalHistory PatientMedicalHistory = new PatientMedicalHistory();
            PatientMedicalHistory.Show();
        }

        private void btnPatientTreatmentNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientTreatmentNotes PatientTreatmentNotes = new PatientTreatmentNotes();
            PatientTreatmentNotes.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointments Appointments = new Appointments();
            Appointments.Show();
        }
    }
}
