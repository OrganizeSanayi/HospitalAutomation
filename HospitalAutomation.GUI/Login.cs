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
                _eTracker.SetError(txtUserName, Constants.Errors.Invalid);
            }

            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                _eTracker.SetError(txtUserPassword, Constants.Errors.Invalid);
            }

            if (_eTracker.Count != 0)
            {
                return;
            }

            var userService = new UserService();
            if (userService.isValidLogin(txtUserName.Text, txtUserPassword.Text))
            {
                Logger.i("Succesfully logged in");
                this.Hide();
                var formHome = new formHomePage {Size = new Size(450, 300)};
                formHome.ShowDialog();

                Environment.Exit(0);
            }
            else
            {
                Logger.i("Invalid login");
                MessageBox.Show(Resources.invalid_credidentials);
            }
        }
    }
}
