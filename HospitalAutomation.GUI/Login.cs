using System;
using System.Drawing;
using System.Windows.Forms;
using HospitalAutomation.Services;
using HospitalAutomation.Util;

namespace HospitalAutomation.GUI
{
    public partial class LoginForm : Form
    {

        ErrorTracker eTracker;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            eTracker = new ErrorTracker(errorProvider);
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
   //     HospitalAutomationEntities db = new HospitalAutomationEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                eTracker.SetError(txtUserName, Constants.Errors.Invalid);
            }

            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                eTracker.SetError(txtUserPassword, Constants.Errors.Invalid);
            }

            if (eTracker.Count != 0)
            {
                return;
            }

            var userService = new UserService();
            if (userService.isValidLogin(txtUserName.Text, txtUserPassword.Text))
            {
                Logger.i("Succesfully logged in");
                this.Hide();
                formHomePage formHome = new formHomePage();
                formHome.Size = new Size(450, 300);
                formHome.ShowDialog();

                Environment.Exit(0);
            }
            else
            {
                Logger.i("Invalid login");
                MessageBox.Show("Gecersiz Giriş");
            }
        }
    }
}
