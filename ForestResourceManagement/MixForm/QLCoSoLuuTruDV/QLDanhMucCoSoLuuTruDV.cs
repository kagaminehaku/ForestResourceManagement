using System;
using System.Linq;
using System.Windows.Forms;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.MixForm.QLCoSoLuuTruDV
{
    public partial class QLDanhMucCoSoLuuTruDV : Form
    {
        public UserAccount Account;
        private FrdbContext FrdbContext;
        private BindingSource _bindingSource;

        public QLDanhMucCoSoLuuTruDV(UserAccount userAccount)
        {
            InitializeComponent();
            Account = userAccount;
            FrdbContext = new FrdbContext();
            LoadDataToDGV();
        }

        private void LoadDataToDGV()
        {
            if (_bindingSource == null)
            {
                _bindingSource = new BindingSource();
            }

            var danhMucCoSoLuuTrus = FrdbContext.DanhMucCoSoLuuTrus.ToList();
            _bindingSource.DataSource = danhMucCoSoLuuTrus;
            dataGridView1.DataSource = _bindingSource;
        }

        private void ThemDV_Click(object sender, EventArgs e)
        {
            var newDanhMucCoSoLuuTru = new DanhMucCoSoLuuTru();
            var form = new DanhMucCoSoLuuTruDVForm(newDanhMucCoSoLuuTru);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FrdbContext.DanhMucCoSoLuuTrus.Add(newDanhMucCoSoLuuTru);
                    FrdbContext.SaveChanges();
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

            var selectedDanhMucCoSoLuuTru = dataGridView1.CurrentRow.DataBoundItem as DanhMucCoSoLuuTru;

            if (selectedDanhMucCoSoLuuTru != null)
            {
                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc muốn xóa danh mục '{selectedDanhMucCoSoLuuTru.TenDanhMucCoSoLuuTru}'?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        FrdbContext.DanhMucCoSoLuuTrus.Remove(selectedDanhMucCoSoLuuTru);
                        FrdbContext.SaveChanges();
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

            var selectedDanhMucCoSoLuuTru = dataGridView1.CurrentRow.DataBoundItem as DanhMucCoSoLuuTru;

            if (selectedDanhMucCoSoLuuTru != null)
            {
                var form = new DanhMucCoSoLuuTruDVForm(selectedDanhMucCoSoLuuTru);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FrdbContext.DanhMucCoSoLuuTrus.Update(selectedDanhMucCoSoLuuTru);
                        FrdbContext.SaveChanges();
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
                var filteredList = FrdbContext.DanhMucCoSoLuuTrus
                    .AsEnumerable()
                    .Where(x => x.TenDanhMucCoSoLuuTru.Contains(searchText, StringComparison.OrdinalIgnoreCase))
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
