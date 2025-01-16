using ForestResourceManagement.Controllers;
using ForestResourceManagement.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class QuanLyDongVat : Form
    {
        private FrdbContext _dbContext;
        private ForestControllerUserAccounts _controllerUserAccounts;
        private BindingSource _bindingSource;
        private UserAccount userAccount;

        public QuanLyDongVat(UserAccount usn)
        {
            _dbContext = new FrdbContext();
            _controllerUserAccounts = new ForestControllerUserAccounts(_dbContext);
            userAccount = usn;
            InitializeComponent();
            LoadDongVatData();
        }

        private void LoadDongVatData()
        {
            if (_bindingSource == null)
            {
                _bindingSource = new BindingSource();
            }

            var dvlist = _dbContext.DongVats.ToList();

            _bindingSource.DataSource = dvlist;
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
                var filteredList = _dbContext.DongVats
                    .AsEnumerable()
                    .Where(h => h.TenDongVat.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _bindingSource.DataSource = filteredList;
                dataGridView1.DataSource = _bindingSource;
            }
            else
            {
                _bindingSource.DataSource = _dbContext.DongVats.ToList();
                dataGridView1.DataSource = _bindingSource;
            }
        }

        private void ThemDV_Click(object sender, EventArgs e)
        {
            var newDongVat = new DongVat();
            var form = new DongVatForm(newDongVat);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _dbContext.DongVats.Add(newDongVat);
                    _dbContext.SaveChanges();
                    LoadDongVatData();
                    MessageBox.Show("Thêm động vật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            var selectedDongVat = dataGridView1.CurrentRow.DataBoundItem as DongVat;

            if (selectedDongVat != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dbContext.DongVats.Remove(selectedDongVat);
                        _dbContext.SaveChanges();
                        LoadDongVatData();
                        MessageBox.Show("Xóa động vật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            var selectedDongVat = dataGridView1.CurrentRow.DataBoundItem as DongVat;

            if (selectedDongVat != null)
            {
                var form = new DongVatForm(selectedDongVat);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _dbContext.DongVats.Update(selectedDongVat);
                        _dbContext.SaveChanges();
                        LoadDongVatData();
                        MessageBox.Show("Sửa động vật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
