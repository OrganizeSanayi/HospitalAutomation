using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAutomation.Util;

namespace HospitalAutomation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void setError(object item){
            var textBox = item as TextBox;
            errorProvider.SetError(textBox, Constants.Errors.INVALID);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool isUsernameFieldEmpty = string.IsNullOrWhiteSpace(txtUserName.Text);
            bool isPasswordFieldEmpty = string.IsNullOrWhiteSpace(txtUserPassword.Text);

            if (isUsernameFieldEmpty)
            {
                setError(txtUserName);
            }

            if (isPasswordFieldEmpty)
            {
                setError(txtUserPassword);
            }

            if (!isUsernameFieldEmpty && !isPasswordFieldEmpty)
            {
                //txtUserName ve txtUserPassword ile sisteme giriş yapılacak
                this.Hide();
                // Login işlemi doğru şekilde sağlandığında hastanın tcNo ve dosya numarasının alınması için yönlendirme yapılacak

                formHomePage formHome = new formHomePage();
                formHome.Size = new System.Drawing.Size(450, 300);
                formHome.Show();
                Logger.i("Succesfully logged in");
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
    }
}
