using ForestResourceManagement.Controllers;
using ForestResourceManagement.MixForm;
using ForestResourceManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                return;//change password form here
            }
            tbusername.Text = string.Empty;
            tbpassword.Text = string.Empty; 
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
            using (var form = new ForgetPassword())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string user = form.Username;
                    var useraccount = _dbContext.UserAccounts.FirstOrDefault(u => u.Username == user);
                    if (useraccount == null) {
                        MessageBox.Show("Không tìm thấy người dùng");
                        return;
                    }
                    if (useraccount.IsForgotPassword) {
                        MessageBox.Show("Đã gửi yêu cầu vui lòng đợi");
                        return;
                    }
                    useraccount.IsForgotPassword = true;
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
