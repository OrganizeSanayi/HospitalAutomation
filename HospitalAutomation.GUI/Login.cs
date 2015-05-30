using System;
using System.Drawing;
using System.Windows.Forms;
using HospitalAutomation.GUI.Properties;
using HospitalAutomation.Services;
using HospitalAutomation.Util;

namespace HospitalAutomation.GUI
{
    public partial class LoginForm : Form
    {

        ErrorTracker _eTracker;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _eTracker = new ErrorTracker(errorProvider);
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _eTracker.Clear();

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                _eTracker.SetError(txtUserName, "Geçersiz alan");
            }

            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                _eTracker.SetError(txtUserPassword, "Geçersiz alan");
            }

            if (_eTracker.Count != 0)
            {
                return;
            }

            if (UserService.IsValidLogin(txtUserName.Text, txtUserPassword.Text))
            {
                Logger.I("Succesfully logged in");
                Hide();
                var formHome = new FormHomePage {Size = new Size(450, 300)};
                formHome.ShowDialog();

                Environment.Exit(0);
            }
            else
            {
                Logger.I("Invalid login");
                MessageBox.Show(Resources.invalid_credidentials);
            }
        }
    }
}
