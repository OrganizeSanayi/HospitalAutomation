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
    public partial class FormEnterPatientExamination : Form
    {
        public FormEnterPatientExamination()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Hasta muayene ve epikriz bilgileri comboBoxPatientExamination combobox'ından alınır
            // Raporların girilmesi için forma yönlendirilir
            this.Hide();
            FormEnterReports formEnterReports = new FormEnterReports();
            formEnterReports.Show();
        }
    }
}
