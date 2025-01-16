using System;
using System.Linq;
using System.Windows.Forms;
using ForestResourceManagement.MixForm.QLBienDong;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.MixForm
{
    public partial class QuanLyBienDong : Form
    {
        private readonly FrdbContext _dbContext;
        private BindingSource _bindingSource;

        public QuanLyBienDong(UserAccount userAccount)
        {
            InitializeComponent();
            _dbContext = new FrdbContext();
            LoadDataToDGV();
        }

        private void LoadDataToDGV()
        {
            if (_bindingSource == null)
            {
                _bindingSource = new BindingSource();
            }

            var bienDongs = _dbContext.BienDongSoLuongs.ToList();
            _bindingSource.DataSource = bienDongs;
            dataGridView1.DataSource = _bindingSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_bindingSource == null)
            {
                return;
            }

            string searchText = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredList = _dbContext.BienDongSoLuongs
                    .AsEnumerable()
                    .Where(bd => bd.TenBienDong.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                _bindingSource.DataSource = filteredList;
            }
            else
            {
                LoadDataToDGV();
            }
        }

        private void ThemBienDong_Click(object sender, EventArgs e)
        {
            using (var form = new BienDongForm(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _dbContext.BienDongSoLuongs.Add(form.BienDong);
                    _dbContext.SaveChanges();

                    LoadDataToDGV();
                }
            }
        }

        private void SuaBienDong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is BienDongSoLuong selectedBienDong)
            {
                using (var form = new BienDongForm(selectedBienDong))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _dbContext.Entry(selectedBienDong).CurrentValues.SetValues(form.BienDong);
                        _dbContext.SaveChanges();

                        LoadDataToDGV();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một biến động để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XoaDV_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is BienDongSoLuong selectedBienDong)
            {
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa biến động này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    _dbContext.BienDongSoLuongs.Remove(selectedBienDong);
                    _dbContext.SaveChanges();

                    LoadDataToDGV();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một biến động để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
