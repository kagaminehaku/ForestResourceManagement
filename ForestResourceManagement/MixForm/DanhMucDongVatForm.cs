using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestResourceManagement.MixForm
{
    public partial class DanhMucDongVatForm : Form
    {
        public DanhMucDongVat danhMucDongVat { get; private set; }
        public DanhMucDongVatForm(DanhMucDongVat danhMucDongVat1)
        {
            InitializeComponent();
            danhMucDongVat = danhMucDongVat1 ?? new DanhMucDongVat();
            textBox1.Text = danhMucDongVat.TenDanhMucDv;
            richTextBox1.Text = danhMucDongVat.ThongTin;
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
            else {
                danhMucDongVat.TenDanhMucDv = textBox1.Text;
                danhMucDongVat.ThongTin = richTextBox1.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
