using System;
using System.Drawing;
using System.Windows.Forms;
using HospitalAutomation.GUI;
using HospitalAutomation.GUI.Properties;
using HospitalAutomation.Services;
using HospitalAutomation.Util;

namespace HastaneArsiv
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            errorProviderLoginForm.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var eTracker = new ErrorTracker(errorProviderLoginForm);

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                eTracker.SetError(txtUserName, "Geçersiz alan");
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                eTracker.SetError(txtPassword, "Geçersiz alan");
            }

            if (eTracker.Count != 0)
            {
                return;
            }

            if (UserService.IsValidLogin(txtUserName.Text, txtPassword.Text))
            {
                Logger.I("Succesfully logged in");
                Hide();
                var formHome = new MainForm();
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
