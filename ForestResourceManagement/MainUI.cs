using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using ForestResourceManagement.Models;
using ForestResourceManagement.MixForm;

namespace ForestResourceManagement
{
    public partial class MainUI : Form
    {
        private FrdbContext _dbContext;

        public MainUI()
        {
            InitializeComponent();
            _dbContext = new FrdbContext();

            // Load data into controls on form load
            LoadHuyenList();

            // Attach event handlers
            DanhSachHuyen.SelectedIndexChanged += DanhSachHuyen_SelectedIndexChanged;
        }

        // Load Huyen list into ComboBox
        private void LoadHuyenList()
        {
            //DanhSachHuyen.Items.Clear();
            DanhSachHuyen.DataSource = null;
            DanhSachHuyen.DataSource = _dbContext.HuyenTables.ToList();
            DanhSachHuyen.DisplayMember = "TenHuyen"; // Assuming the Huyen entity has a "TenHuyen" property
            DanhSachHuyen.ValueMember = "HuyenId";        // Assuming the Huyen entity has an "Id" property
            DanhSachHuyen.SelectedIndex = -1;
        }

        // Load Xa list into DataGridView based on selected Huyen
        private void LoadXaList(int huyenId)
        {
            DanhSachXa.DataSource = null;
            var xaList = _dbContext.XaTables.Where(x => x.HuyenId == huyenId).ToList();
            DanhSachXa.DataSource = xaList;
        }

        private void ClearXaList()
        {
            DanhSachXa.DataSource = null;
        }

        // Event: Huyen selection changed
        private void DanhSachHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DanhSachHuyen.SelectedValue is int selectedHuyenId)
            {
                LoadXaList(selectedHuyenId);
            }
        }

        // Add a new Huyen
        private void ThemHuyen_Click(object sender, EventArgs e)
        {
            using (var form = new HuyenForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var newHuyen = form.Huyen;
                    _dbContext.HuyenTables.Add(newHuyen);
                    _dbContext.SaveChanges();
                    LoadHuyenList();
                }
            }
        }

        // Edit the selected Huyen
        private void SuaHuyen_Click(object sender, EventArgs e)
        {
            if (DanhSachHuyen.SelectedValue is int selectedHuyenId)
            {
                var huyen = _dbContext.HuyenTables.Find(selectedHuyenId);
                if (huyen != null)
                {
                    using (var form = new HuyenForm(huyen))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _dbContext.SaveChanges();
                            LoadHuyenList();
                        }
                    }
                }
            }
        }

        // Delete the selected Huyen
        private void XoaHuyen_Click(object sender, EventArgs e)
        {
            if (DanhSachHuyen.SelectedValue is int selectedHuyenId)
            {
                var huyen = _dbContext.HuyenTables.Find(selectedHuyenId);
                if (huyen != null && 
                    MessageBox.Show("Bạn có chắc chắn muốn xoá huyện này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var xas = _dbContext.XaTables.Where(x => x.HuyenId == selectedHuyenId).ToList();
                    _dbContext.XaTables.RemoveRange(xas);

                    _dbContext.HuyenTables.Remove(huyen);
                    _dbContext.SaveChanges();
                    LoadHuyenList();
                    ClearXaList();
                }
            }
        }

        // Add a new Xa
        private void ThemXa_Click(object sender, EventArgs e)
        {
            if (DanhSachHuyen.SelectedValue is int selectedHuyenId)
            {
                using (var form = new XaForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var newXa = form.Xa;
                        newXa.HuyenId = selectedHuyenId;
                        _dbContext.XaTables.Add(newXa);
                        _dbContext.SaveChanges();
                        LoadXaList(selectedHuyenId);
                    }
                }
            }
        }

        // Edit the selected Xa
        private void SuaXa_Click(object sender, EventArgs e)
        {
            if (DanhSachXa.SelectedRows.Count > 0)
            {
                var selectedXa = DanhSachXa.SelectedRows[0].DataBoundItem as XaTable;
                if (selectedXa != null)
                {
                    using (var form = new XaForm(selectedXa))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _dbContext.SaveChanges();
                            LoadXaList(selectedXa.HuyenId);
                            LoadHuyenList();
                        }
                    }
                }
            }
        }

        // Delete the selected Xa
        private void XoaXa_Click(object sender, EventArgs e)
        {
            if (DanhSachXa.SelectedRows.Count > 0)
            {
                var selectedXa = DanhSachXa.SelectedRows[0].DataBoundItem as XaTable;
                if (selectedXa != null && 
                    MessageBox.Show("Bạn có chắc chắn muốn xoá xã này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dbContext.XaTables.Remove(selectedXa);
                    _dbContext.SaveChanges();
                    LoadXaList(selectedXa.HuyenId);
                }
            }
        }
    }
}
