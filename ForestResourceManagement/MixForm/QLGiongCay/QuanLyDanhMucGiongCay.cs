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

namespace ForestResourceManagement.MixForm.QLGiongCay
{
    public partial class QuanLyDanhMucGiongCay : Form
    {
        public UserAccount Account;
        private FrdbContext FrdbContext;
        private BindingSource _bindingSource;
        public QuanLyDanhMucGiongCay(UserAccount userAccount)
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

            var danhMucDongVats = FrdbContext.DanhMucDongVats.ToList();
            _bindingSource.DataSource = danhMucDongVats;
            dataGridView1.DataSource = _bindingSource;
        }

        private void ThemDV_Click(object sender, EventArgs e)
        {
            var newDanhMucDongVat = new DanhMucDongVat();
            var form = new DanhMucDongVatForm(newDanhMucDongVat);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FrdbContext.DanhMucDongVats.Add(newDanhMucDongVat);
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

            var selectedDanhMucDongVat = dataGridView1.CurrentRow.DataBoundItem as DanhMucDongVat;

            if (selectedDanhMucDongVat != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        FrdbContext.DanhMucDongVats.Remove(selectedDanhMucDongVat);
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

            var selectedDanhMucDongVat = dataGridView1.CurrentRow.DataBoundItem as DanhMucDongVat;

            if (selectedDanhMucDongVat != null)
            {
                var form = new DanhMucDongVatForm(selectedDanhMucDongVat);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FrdbContext.DanhMucDongVats.Update(selectedDanhMucDongVat);
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
                var filteredList = FrdbContext.DanhMucDongVats
                    .AsEnumerable()
                    .Where(x => x.TenDanhMucDv.Contains(searchText, StringComparison.OrdinalIgnoreCase))
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
