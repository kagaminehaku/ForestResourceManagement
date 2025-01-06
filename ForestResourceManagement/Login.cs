using ForestResourceManagement.Controllers;
using ForestResourceManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ForestResourceManagement
{
    public partial class Login : Form
    {
        private ForestControllerUserAccounts _controllerUserAccounts;
        private FrdbContext _dbContext;
        public Login()
        {
            InitializeComponent();
            _dbContext = new FrdbContext();
            _controllerUserAccounts = new ForestControllerUserAccounts(_dbContext);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var useraccount = GoLogin();
            if (useraccount == null)
            {
                MessageBox.Show("Wrong username or password");
                return;
            }
            if (useraccount.IsForgotPassword)
            {
                MessageBox.Show("Your forgot password request has been sent,please wait");
                return;
            }
            if (useraccount.Password == "reset")
            {
                MessageBox.Show("Your password has been reset,please set a new one");
            }
            var mainuiform = new MainUI(useraccount);
            mainuiform.FormClosed += (s, args) => this.Show();
            mainuiform.Show();
            this.Hide();
        }

        private UserAccount GoLogin()
        {
            var uac = _controllerUserAccounts.Login(tbusername.Text, tbpassword.Text);
            return uac;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
