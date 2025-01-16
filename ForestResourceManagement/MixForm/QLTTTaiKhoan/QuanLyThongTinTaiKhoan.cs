using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForestResourceManagement.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ForestResourceManagement.MixForm
{
    public partial class QuanLyThongTinTaiKhoan : Form
    {
        public UserAccount _userAccount { get; private set; }
        public QuanLyThongTinTaiKhoan(UserAccount uac)
        {
            _userAccount = uac;
            InitializeComponent();
            LoadDataTaiKhoan();

        }

        private void LoadDataTaiKhoan()
        {
            usernametb.Text = _userAccount.Username;
            phnbtb.Text = _userAccount.Phone;
            emailtb.Text = _userAccount.Email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phnbtb.Text) || string.IsNullOrEmpty(emailtb.Text))
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _userAccount.Phone = phnbtb.Text;
                _userAccount.Email = emailtb.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
