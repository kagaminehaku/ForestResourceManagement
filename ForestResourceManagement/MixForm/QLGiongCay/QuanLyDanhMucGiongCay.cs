using System;
using System.Linq;
using System.Windows.Forms;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.MixForm.QLGiongCay
{
    public partial class QuanLyDanhMucGiongCay : Form
    {
        public UserAccount Account;
        private FrdbContext _dbContext;
        private BindingSource _bindingSource;

        public QuanLyDanhMucGiongCay(UserAccount userAccount)
        {
            InitializeComponent();
            Account = userAccount;
            _dbContext = new FrdbContext();
            LoadDataToDGV();
        }

        private void LoadDataToDGV()
        {
            if (_bindingSource == null)
            {
                _bindingSource = new BindingSource();
            }

            var danhMucGiongCays = _dbContext.DanhMucGiongCays.ToList();
            _bindingSource.DataSource = danhMucGiongCays;
            dataGridView1.DataSource = _bindingSource;
        }

        private void ThemDV_Click(object sender, EventArgs e)
        {
            var newDanhMucGiongCay = new DanhMucGiongCay();
            var form = new DanhMucGiongCayForm(newDanhMucGiongCay);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _dbContext.DanhMucGiongCays.Add(newDanhMucGiongCay);
                    _dbContext.SaveChanges();
                    LoadDataToDGV();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XoaDV_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDanhMucGiongCay = dataGridView1.CurrentRow.DataBoundItem as DanhMucGiongCay;

            if (selectedDanhMucGiongCay != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dbContext.DanhMucGiongCays.Remove(selectedDanhMucGiongCay);
                        _dbContext.SaveChanges();
                        LoadDataToDGV();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SuaDV_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDanhMucGiongCay = dataGridView1.CurrentRow.DataBoundItem as DanhMucGiongCay;

            if (selectedDanhMucGiongCay != null)
            {
                var form = new DanhMucGiongCayForm(selectedDanhMucGiongCay);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _dbContext.DanhMucGiongCays.Update(selectedDanhMucGiongCay);
                        _dbContext.SaveChanges();
                        LoadDataToDGV();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                var filteredList = _dbContext.DanhMucGiongCays
                    .AsEnumerable()
                    .Where(x => x.TenDanhMuc.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                _bindingSource.DataSource = filteredList;
            }
            else
            {
                LoadDataToDGV();
            }
        }
    }
}
