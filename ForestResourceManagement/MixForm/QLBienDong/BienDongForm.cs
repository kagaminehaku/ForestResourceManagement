using System;
using System.Linq;
using System.Windows.Forms;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.MixForm.QLBienDong
{
    public partial class BienDongForm : Form
    {
        private readonly FrdbContext _dbcontext;
        public BienDongSoLuong BienDong { get; private set; }

        public BienDongForm(BienDongSoLuong bienDongSoLuong)
        {
            InitializeComponent();
            _dbcontext = new FrdbContext();
            LoadDataToComboBox();
            BienDong = bienDongSoLuong ?? new BienDongSoLuong();

            textBox1.Text = BienDong.TenBienDong;
            textBox2.Text = BienDong.SoLuongBienDong.ToString();

            if (BienDong.DanhMucBienDongId.HasValue)
            {
                comboBox1.SelectedValue = BienDong.DanhMucBienDongId.Value;
            }

            //if (!string.IsNullOrEmpty(BienDong.DongVat))
            //{
            //    comboBox2.SelectedItem = _dbcontext.DongVats
            //        .FirstOrDefault(dv => dv.TenDongVat.Equals(BienDong.DongVat, StringComparison.OrdinalIgnoreCase));
            //}
        }

        private void LoadDataToComboBox()
        {
            comboBox1.DataSource = _dbcontext.DanhMucBienDongs.ToList();
            comboBox1.DisplayMember = "TenDanhMucBienDong";
            comboBox1.ValueMember = "DanhMucBienDongId";
            comboBox1.SelectedIndex = -1; 

            comboBox2.DataSource = _dbcontext.DongVats.ToList();
            comboBox2.DisplayMember = "TenDongVat";
            comboBox2.ValueMember = "DongVatId";
            comboBox2.SelectedIndex = -1; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                comboBox1.SelectedValue == null ||
                comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các trường dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox2.Text, out int soLuongBienDong) || soLuongBienDong < 0)
            {
                MessageBox.Show("Số lượng biến động phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BienDong.TenBienDong = textBox1.Text;
            BienDong.SoLuongBienDong = soLuongBienDong;
            BienDong.DanhMucBienDongId = (int)comboBox1.SelectedValue;

            BienDong.DongVat = ((DongVat)comboBox2.SelectedItem).TenDongVat;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
