using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class FormEnterPatientStatus : Form
    {
        public FormEnterPatientStatus()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //radioButtonOutpatient ve radioButtonInpatient'den gelen değere göre işlem yapılacak.
            // Hasta Muayene ve Epikriz sayfasına gidilecek
            this.Hide();
            FormEnterPatientExamination formPatientExamination = new FormEnterPatientExamination();
            formPatientExamination.Show();
        }
    }
}
