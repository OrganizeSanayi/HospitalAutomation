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
    public partial class FormEnterTCNoFileNumber : Form
    {
        public FormEnterTCNoFileNumber()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // txtTcNo ve txtFileNumber textboxları kullanılarak işlem yapılacak
            //Bilgiler girildikten sonra tarih bilgisi alınması işlemine geçilecek
            this.Hide();
            FormEnterDate formEnterDate = new FormEnterDate();
            formEnterDate.Show();
        }
    }
}
