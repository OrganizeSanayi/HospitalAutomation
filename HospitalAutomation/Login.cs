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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //txtUserName ve txtUserPassword ile sisteme giriş yapılacak
            this.Hide();

            // Login işlemi doğru şekilde sağlandığında hastanın tcNo ve dosya numarasının alınması için yönlendirme yapılacak
            FormEnterTCNoFileNumber frm = new FormEnterTCNoFileNumber();
            frm.Show();
        }
    }
}
