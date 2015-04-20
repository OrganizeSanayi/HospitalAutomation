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
    public partial class FormEnterFacultyMember : Form
    {
        public FormEnterFacultyMember()
        {
            InitializeComponent();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            //İlgili öğretim üyesi(comboBoxFacultyMember) seçildikten sonra hasta tanısı girişi için yönlendirme yapılır.
            this.Hide();
            FormEnterPatientDiagnosed formEnterPatientsDiagnosed = new FormEnterPatientDiagnosed();
            formEnterPatientsDiagnosed.Show();
        }
    }
}
