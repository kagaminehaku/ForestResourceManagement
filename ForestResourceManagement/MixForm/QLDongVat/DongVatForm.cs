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

namespace ForestResourceManagement.MixForm
{
    public partial class DongVatForm : Form
    {
        private FrdbContext _dbcontext;
        public DongVat dongVat { get; private set; }
        public DongVatForm(DongVat dongVat1)
        {
            InitializeComponent();
            _dbcontext = new FrdbContext();
            dongVat = dongVat1 ?? new DongVat();
            textBox1.Text = dongVat.TenDongVat;
            richTextBox1.Text = dongVat.ThongTinDongVat; 
            LoadDataComboBox();
        }

        private void LoadDataComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = _dbcontext.DanhMucDongVats.ToList();
            comboBox1.DisplayMember = "TenDanhMucDV";
            comboBox1.ValueMember = "DanhMucDVID";
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1||textBox1.Text == null || richTextBox1.Text == null)
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(comboBox1.SelectedValue is int selecteddanhmuc) { 
                dongVat.TenDongVat = textBox1.Text;
                dongVat.DanhMucDvid = selecteddanhmuc;
                dongVat.ThongTinDongVat = richTextBox1.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
