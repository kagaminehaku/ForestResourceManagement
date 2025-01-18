using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestResourceManagement.MixForm.QLCoSoLuuTruDV
{
    public partial class DanhMucCoSoLuuTruDVForm : Form
    {
        public DanhMucCoSoLuuTru danhMucCoSoLuuTru { get;private set; }
        public DanhMucCoSoLuuTruDVForm(DanhMucCoSoLuuTru mucCoSoLuuTru)
        {
            InitializeComponent();
            danhMucCoSoLuuTru = mucCoSoLuuTru ?? new DanhMucCoSoLuuTru();
            textBox1.Text = danhMucCoSoLuuTru.TenDanhMucCoSoLuuTru;
            richTextBox1.Text = danhMucCoSoLuuTru.ThongTin;
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
                danhMucCoSoLuuTru.TenDanhMucCoSoLuuTru = textBox1.Text;
                danhMucCoSoLuuTru.ThongTin = richTextBox1.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
