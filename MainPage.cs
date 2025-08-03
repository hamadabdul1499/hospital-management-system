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
    public partial class MainPage: Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnhospitaladminlogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            HospitalAdminLogin HospitalAdminLogin = new HospitalAdminLogin();
            HospitalAdminLogin.Show();
        }

        private void btnhospitalreceptionistlogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            HospitalReceptionistLogin HospitalReceptionistLogin = new HospitalReceptionistLogin();
            HospitalReceptionistLogin.Show();

            
        }

        private void btndoctorlogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            DoctorLogin DoctorLogin = new DoctorLogin();
            DoctorLogin.Show();
        }
    }
}
