using System;
using System.Linq;
using System.Windows.Forms;

namespace ForestResourceManagement.MixForm.QLGiongCay
{
    public partial class QuanLyGiongCay : Form
    {
        private FrdbContext _dbContext;
        private BindingSource _bindingSource;

        public QuanLyGiongCay(UserAccount uac)
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

            var giongCayTrongs = _dbContext.GiongCayTrongs.ToList();
            _bindingSource.DataSource = giongCayTrongs;
            dataGridView1.DataSource = _bindingSource;
        }

        private void ThemGiongCay_Click(object sender, EventArgs e)
        {
            var newGiongCayTrong = new GiongCayTrong();
            var form = new GiongCayForm(newGiongCayTrong);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _dbContext.GiongCayTrongs.Add(newGiongCayTrong);
                    _dbContext.SaveChanges();
                    LoadDataToDGV();
                    MessageBox.Show("Thêm giống cây trồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm giống cây trồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XoaGiongCay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedGiongCayTrong = dataGridView1.CurrentRow.DataBoundItem as GiongCayTrong;

            if (selectedGiongCayTrong != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa giống cây trồng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dbContext.GiongCayTrongs.Remove(selectedGiongCayTrong);
                        _dbContext.SaveChanges();
                        LoadDataToDGV();
                        MessageBox.Show("Xóa giống cây trồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa giống cây trồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SuaGiongCay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedGiongCayTrong = dataGridView1.CurrentRow.DataBoundItem as GiongCayTrong;

            if (selectedGiongCayTrong != null)
            {
                var form = new GiongCayForm(selectedGiongCayTrong);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _dbContext.GiongCayTrongs.Update(selectedGiongCayTrong);
                        _dbContext.SaveChanges();
                        LoadDataToDGV();
                        MessageBox.Show("Sửa giống cây trồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi sửa giống cây trồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var filteredList = _dbContext.GiongCayTrongs
                    .AsEnumerable()
                    .Where(x => x.TenGiongCayTrong.Contains(searchText, StringComparison.OrdinalIgnoreCase))
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
