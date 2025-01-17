using System;
using System.Linq;
using System.Windows.Forms;
using ForestResourceManagement;

namespace ForestResourceManagement.MixForm.QLGiongCay
{
    public partial class GiongCayForm : Form
    {
        private FrdbContext _dbContext;
        public GiongCayTrong GiongCay { get; private set; }

        public GiongCayForm(GiongCayTrong giongCay)
        {
            InitializeComponent();
            _dbContext = new FrdbContext();
            GiongCay = giongCay ?? new GiongCayTrong();
            InitializeFormData();
            LoadDataComboBox();
        }

        private void InitializeFormData()
        {
            textBox1.Text = GiongCay.TenGiongCayTrong;
            richTextBox1.Text = GiongCay.ThongTin;
        }

        private void LoadDataComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = _dbContext.DanhMucGiongCays.ToList();
            comboBox1.DisplayMember = "TenDanhMuc";
            comboBox1.ValueMember = "DanhMucGiongCayId";
            comboBox1.SelectedIndex = -1;

            if (GiongCay.DanhMucGiongCayId != 0)
            {
                comboBox1.SelectedValue = GiongCay.DanhMucGiongCayId;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Vui lòng không để trống các trường dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedValue is int selectedDanhMucId)
            {
                GiongCay.TenGiongCayTrong = textBox1.Text.Trim();
                GiongCay.ThongTin = richTextBox1.Text.Trim();
                GiongCay.DanhMucGiongCayId = selectedDanhMucId;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
