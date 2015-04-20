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
    public partial class FormEnterDate : Form
    {
        public FormEnterDate()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Tarih bilgisi(dateTimePicker) alındıktan sonra ilgili öğretim üyesi bilgisi alınması için form yönlendirmesi yapılır.
            this.Hide();
            FormEnterFacultyMember formEnterFacultyMember = new FormEnterFacultyMember();
            formEnterFacultyMember.Show();
        }
    }
}
