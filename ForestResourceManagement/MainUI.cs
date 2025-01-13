using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using ForestResourceManagement.MixForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ForestResourceManagement.Controllers;

namespace ForestResourceManagement
{
    public partial class MainUI : Form
    {
        private FrdbContext _dbContext;
        private ForestControllerUserAccounts _controllerUserAccounts;
        private BindingSource _bindingSource;
        private BindingSource _bindingSource2;
        private BindingSource _bindingSourceLog;
        private BindingSource _bindingSourceuacmanager;
        private string username;
        private UserAccount userAccount;
        public MainUI(UserAccount usn)
        {
            InitializeComponent();
            _dbContext = new FrdbContext();
            _controllerUserAccounts = new ForestControllerUserAccounts(_dbContext);
            username = usn.Username;
            userAccount = usn;
            LoadHuyenList();
            LoadLogList();
            LoadInsList();
            LoadUACList();

            //DanhSachHuyen.SelectedIndexChanged += DanhSachHuyen_SelectedIndexChanged;
        }

        private void LoadUACList()
        {
            if (_bindingSourceuacmanager == null)
            {
                _bindingSourceuacmanager = new BindingSource();
            }

            var uaclist = _dbContext.UserAccounts.ToList();
            _bindingSourceuacmanager.DataSource = null;
            _bindingSourceuacmanager.DataSource = uaclist;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _bindingSourceuacmanager;
        }

        private void LoadInsList()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = _dbContext.InstructionTables.ToList();
            comboBox1.DisplayMember = "InstructionName";
            comboBox1.ValueMember = "InstructionId";
            comboBox1.SelectedIndex = -1;
            //_controllerUserAccounts.LogAction(username, "Load Danh Sach Huong Dan");
        }

        private void LoadHuyenList()
        {
            if (_bindingSource2 == null)
            {
                _bindingSource2 = new BindingSource();
            }

            var huyenList = _dbContext.HuyenTables.ToList();

            _bindingSource2.DataSource = huyenList;

            DanhSachHuyenDGV.DataSource = _bindingSource2;

            DanhSachHuyen.DataSource = huyenList;
            DanhSachHuyen.DisplayMember = "TenHuyen";
            DanhSachHuyen.ValueMember = "HuyenId";
            DanhSachHuyen.SelectedIndex = -1;
            //_controllerUserAccounts.LogAction(username, "Load Danh Sach Huyen");
        }

        private void LoadLogList()
        {
            if (_bindingSourceLog == null)
            {
                _bindingSourceLog = new BindingSource();
            }

            var loglist = _dbContext.LogTables.ToList();
            _bindingSourceLog.DataSource = null;
            _bindingSourceLog.DataSource = loglist;
            DanhSachLog.DataSource = null;
            DanhSachLog.DataSource = _bindingSourceLog;

            //_controllerUserAccounts.LogAction(username, "Load Danh Sach Log");


        }

        private void LoadXaList(int huyenId)
        {
            _controllerUserAccounts.LogAction(username, "Load Danh Sach Xa");
            var xaList = _dbContext.XaTables.Where(x => x.HuyenId == huyenId).ToList();

            if (_bindingSource == null)
            {
                _bindingSource = new BindingSource();
                DanhSachXa.DataSource = _bindingSource;
            }

            _bindingSource.DataSource = xaList;
        }


        private void ClearXaList()
        {
            DanhSachXa.DataSource = null;
        }

        private void DanhSachHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DanhSachHuyen.SelectedValue is int selectedHuyenId)
            {
                LoadXaList(selectedHuyenId);
            }
        }

        private void ThemHuyen_Click(object sender, EventArgs e)
        {
            using (var form = new HuyenForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var newHuyen = form.Huyen;
                    _dbContext.HuyenTables.Add(newHuyen);
                    _dbContext.SaveChanges();
                    _controllerUserAccounts.LogAction(username, $"Them Huyen{newHuyen.TenHuyen}");
                    LoadHuyenList();
                }
            }
        }

        private void SuaHuyen_Click(object sender, EventArgs e)
        {
            if (DanhSachHuyenDGV.SelectedRows.Count > 0)
            {
                var selectedHuyen = DanhSachHuyenDGV.SelectedRows[0].DataBoundItem as HuyenTable;
                if (selectedHuyen != null)
                {
                    using (var form = new HuyenForm(selectedHuyen))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _controllerUserAccounts.LogAction(username, $"Sua Huyen{selectedHuyen.HuyenId}");
                            _dbContext.SaveChanges();
                            LoadHuyenList();
                        }
                    }
                }
            }
        }


        private void XoaHuyen_Click(object sender, EventArgs e)
        {
            if (DanhSachHuyenDGV.SelectedRows.Count > 0)
            {
                var selectedHuyen = DanhSachHuyenDGV.SelectedRows[0].DataBoundItem as HuyenTable;
                if (selectedHuyen != null &&
                    MessageBox.Show("Bạn có chắc chắn muốn xoá huyện này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var xas = _dbContext.XaTables.Where(x => x.HuyenId == selectedHuyen.HuyenId).ToList();
                    _dbContext.XaTables.RemoveRange(xas);

                    _dbContext.HuyenTables.Remove(selectedHuyen);
                    _controllerUserAccounts.LogAction(username, $"Xoa Huyen{selectedHuyen.TenHuyen}");
                    _dbContext.SaveChanges();
                    LoadHuyenList();
                    ClearXaList();
                }
            }
        }


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
                        _controllerUserAccounts.LogAction(username, $"Them Xa{newXa.TenXa}");
                        LoadXaList(selectedHuyenId);
                    }
                }
            }
        }

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
                            _controllerUserAccounts.LogAction(username, $"Sua Xa{selectedXa.XaId}");
                            LoadXaList(selectedXa.HuyenId);
                            LoadHuyenList();
                        }
                    }
                }
            }
        }

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
                    _controllerUserAccounts.LogAction(username, $"Xoa xa{selectedXa.XaId}");
                    LoadXaList(selectedXa.HuyenId);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (_bindingSource == null)
            {
                return;
            }
            string searchText = textBox2.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredList = _dbContext.XaTables
                    .AsEnumerable()
                    .Where(x => x.TenXa.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                _bindingSource.DataSource = filteredList;
            }
            else
            {
                if (DanhSachHuyen.SelectedValue is int selectedHuyenId)
                {
                    LoadXaList(selectedHuyenId);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (_bindingSource == null)
            {
                return;
            }

            string searchText = textBox3.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredList = _dbContext.HuyenTables
                    .AsEnumerable()
                    .Where(h => h.TenHuyen.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _bindingSource2.DataSource = filteredList;
                DanhSachHuyenDGV.DataSource = _bindingSource2;
            }
            else
            {
                _bindingSource2.DataSource = _dbContext.HuyenTables.ToList();
                DanhSachHuyenDGV.DataSource = _bindingSource2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLogList();
        }

        private void DanhSachLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DanhSachLog.SelectedRows.Count > 0)
            {
                var selectedlog = DanhSachLog.SelectedRows[0].DataBoundItem as LogTable;
                if (selectedlog != null)
                {
                    richTextBox1.Text = selectedlog.LogEvent;
                    richTextBox2.Text = selectedlog.LogType;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_bindingSourceLog == null)
            {
                return;
            }

            string searchText = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredList = _dbContext.LogTables
                    .AsEnumerable()
                    .Where(h => h.LogEvent.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                _bindingSourceLog.DataSource = filteredList;
                DanhSachLog.DataSource = _bindingSourceLog;
            }
            else
            {
                _bindingSourceLog.DataSource = _dbContext.LogTables.ToList();
                DanhSachLog.DataSource = _bindingSourceLog;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != null && richTextBox4.Text != null)
            {
                var newins = new InstructionTable();
                newins.InstructionName = textBox4.Text;
                newins.InstructionContent = richTextBox3.Text;
                _dbContext.InstructionTables.Add(newins);
                _dbContext.SaveChanges();
                textBox4.Text = string.Empty;
                richTextBox3.Text = string.Empty;
                LoadInsList();
                _controllerUserAccounts.LogAction(username, $"Add instruction{newins.InstructionName}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int selectinsid)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá hướng dẫn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes && selectinsid != null)
                {
                    var delins = _dbContext.InstructionTables.Find(selectinsid);
                    _dbContext.InstructionTables.Remove(delins);
                    _dbContext.SaveChanges();
                    _controllerUserAccounts.LogAction(username, $"Delete instruction{delins.InstructionName}");
                    LoadInsList();
                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int selectinsid)
            {
                var item = _dbContext.InstructionTables.Find(selectinsid);
                richTextBox4.Text = item.InstructionContent;
            }
        }

        private void QuanLyDanhMucDongVat_Click(object sender, EventArgs e)
        {
            var danhmucdongvatform = new QuanLyDanhMucDongVat(userAccount);
            danhmucdongvatform.FormClosed += (s, args) => this.Show();
            danhmucdongvatform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dongvatform = new QuanLyDongVat(userAccount);
            dongvatform.FormClosed += (s, args) => this.Show();
            dongvatform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Access log noted
            this.Close();
        }

        private void ChangePwd_Click(object sender, EventArgs e)
        {
            if (Hash.HashingPassword(crpwd.Text) != userAccount.Password)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            if (newpwd.Text != renterpwd.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp");
                return;
            }
            var useraccount = _dbContext.UserAccounts.Find(userAccount.Uid);
            useraccount.Password = Hash.HashingPassword(newpwd.Text);
            _dbContext.SaveChanges();
            MessageBox.Show("Đổi mật khẩu thành công");
            //Access log noted
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new QuanLyThongTinTaiKhoan(userAccount);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _dbContext.UserAccounts.Update(userAccount);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var reportHandler = new LogReportHandler(_dbContext);
            reportHandler.OnGenerateReportButtonClick();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (_bindingSourceuacmanager == null)
            {
                return;
            }
            string searchText = textBox5.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredList = _dbContext.UserAccounts
                    .AsEnumerable()
                    .Where(x => x.Username.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                _bindingSourceuacmanager.DataSource = filteredList;
            }
        }
    }
}
