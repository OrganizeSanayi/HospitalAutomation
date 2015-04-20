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
    public partial class FormEnterPatientDiagnosed : Form
    {
        public FormEnterPatientDiagnosed()
        {
            InitializeComponent();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            // txtPatientDiagnosed textbox'ından hasta tanısı alınacak
            // Hasta statüsü sayfasına geçilecek
            this.Hide();
            FormEnterPatientStatus formPatientsStatus = new FormEnterPatientStatus();
            formPatientsStatus.Show();
        }
    }
}
