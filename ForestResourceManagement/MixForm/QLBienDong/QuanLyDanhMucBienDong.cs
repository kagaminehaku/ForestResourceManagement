using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForestResourceManagement.MixForm.QLBienDong;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.MixForm
{
    public partial class QuanLyDanhMucBienDong : Form
    {
        public UserAccount Account;
        private FrdbContext FrdbContext;
        private BindingSource _bindingSource;

        public QuanLyDanhMucBienDong(UserAccount userAccount)
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

            var danhmucbiendongs = FrdbContext.DanhMucBienDongs.ToList();
            _bindingSource.DataSource = danhmucbiendongs;
            dataGridView1.DataSource = _bindingSource;
        }

        private void ThemDanhMucBienDong_Click(object sender, EventArgs e)
        {
            var newDanhMucBienDong = new DanhMucBienDong();
            var form = new DanhMucBienDongForm(newDanhMucBienDong);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FrdbContext.DanhMucBienDongs.Add(newDanhMucBienDong);
                    FrdbContext.SaveChanges();
                    LoadDataToDGV();
                    MessageBox.Show("Thêm danh mục biến động thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XoaDanhMucBienDong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDanhMucBienDong = dataGridView1.CurrentRow.DataBoundItem as DanhMucBienDong;

            if (selectedDanhMucBienDong != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        FrdbContext.DanhMucBienDongs.Remove(selectedDanhMucBienDong);
                        FrdbContext.SaveChanges();
                        LoadDataToDGV();
                        MessageBox.Show("Xóa danh mục biến động thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SuaDanhMucBienDong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDanhMucBienDong = dataGridView1.CurrentRow.DataBoundItem as DanhMucBienDong;

            if (selectedDanhMucBienDong != null)
            {
                var form = new DanhMucBienDongForm(selectedDanhMucBienDong);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FrdbContext.DanhMucBienDongs.Update(selectedDanhMucBienDong);
                        FrdbContext.SaveChanges();
                        LoadDataToDGV();
                        MessageBox.Show("Sửa danh mục biến động thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var filteredList = FrdbContext.DanhMucBienDongs
                    .AsEnumerable()
                    .Where(x => x.TenDanhMucBienDong.Contains(searchText, StringComparison.OrdinalIgnoreCase))
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
