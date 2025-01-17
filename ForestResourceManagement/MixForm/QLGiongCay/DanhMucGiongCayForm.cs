using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestResourceManagement.MixForm.QLGiongCay
{
    public partial class DanhMucGiongCayForm : Form
    {
        public DanhMucGiongCay danhMucGiongCay { get; set; }
        public DanhMucGiongCayForm(DanhMucGiongCay danhMucGiongCay1)
        {
            InitializeComponent();
            danhMucGiongCay = danhMucGiongCay1 ?? new DanhMucGiongCay();
            textBox1.Text = danhMucGiongCay.TenDanhMuc;
            richTextBox1.Text = danhMucGiongCay.ThongTin;
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
                danhMucGiongCay.TenDanhMuc = textBox1.Text;
                danhMucGiongCay.ThongTin = richTextBox1.Text;
                DialogResult = DialogResult.OK;
            }
        }


    }
}
