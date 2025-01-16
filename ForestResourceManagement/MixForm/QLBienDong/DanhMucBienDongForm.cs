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

namespace ForestResourceManagement.MixForm.QLBienDong
{
    public partial class DanhMucBienDongForm : Form
    {
        public DanhMucBienDong danhMucBienDong { get; private set; }
        public DanhMucBienDongForm(DanhMucBienDong danhmucbiendong)
        {
            InitializeComponent();
            danhMucBienDong = danhmucbiendong ?? new DanhMucBienDong();
            textBox1.Text = danhmucbiendong.TenDanhMucBienDong;
            richTextBox1.Text = danhmucbiendong.ThongTin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                danhMucBienDong.TenDanhMucBienDong = textBox1.Text;
                danhMucBienDong.ThongTin = richTextBox1.Text;
                DialogResult = DialogResult.OK;
            }
        }

    }
}
