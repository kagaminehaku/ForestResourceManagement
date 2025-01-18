
using ForestResourceManagement.Models;

namespace ForestResourceManagement
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            formtabcontrol1 = new TabControl();
            QuanLyDonViTab = new TabPage();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            DanhSachHuyenDGV = new DataGridView();
            SuaHuyen = new Button();
            XoaHuyen = new Button();
            ThemHuyen = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            SuaXa = new Button();
            label2 = new Label();
            XoaXa = new Button();
            ThemXa = new Button();
            DanhSachHuyen = new ComboBox();
            DanhSachXa = new DataGridView();
            QuanLyDongVatTab = new TabPage();
            button9 = new Button();
            button8 = new Button();
            button4 = new Button();
            QuanLyDanhMucDongVat = new Button();
            TaiKhoanTab = new TabPage();
            button6 = new Button();
            renterpwdlb = new Label();
            ChangePwd = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            renterpwd = new TextBox();
            newpwd = new TextBox();
            crpwd = new TextBox();
            button5 = new Button();
            QuanLyGiongCayTab = new TabPage();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            QLCheBienGo = new TabPage();
            HuongDanTab = new TabPage();
            groupBox5 = new GroupBox();
            richTextBox4 = new RichTextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            groupBox3 = new GroupBox();
            richTextBox3 = new RichTextBox();
            button2 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            UserControlTab = new TabPage();
            label8 = new Label();
            textBox5 = new TextBox();
            dataGridView2 = new DataGridView();
            SystemLogTab = new TabPage();
            button7 = new Button();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            DanhSachLog = new DataGridView();
            logIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logIndexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logEventDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            richTextBox1 = new RichTextBox();
            logTableBindingSource1 = new BindingSource(components);
            button13 = new Button();
            formtabcontrol1.SuspendLayout();
            QuanLyDonViTab.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachHuyenDGV).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachXa).BeginInit();
            QuanLyDongVatTab.SuspendLayout();
            TaiKhoanTab.SuspendLayout();
            QuanLyGiongCayTab.SuspendLayout();
            HuongDanTab.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            UserControlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SystemLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logTableBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // formtabcontrol1
            // 
            formtabcontrol1.Controls.Add(QuanLyDonViTab);
            formtabcontrol1.Controls.Add(QuanLyDongVatTab);
            formtabcontrol1.Controls.Add(TaiKhoanTab);
            formtabcontrol1.Controls.Add(QuanLyGiongCayTab);
            formtabcontrol1.Controls.Add(QLCheBienGo);
            formtabcontrol1.Controls.Add(HuongDanTab);
            formtabcontrol1.Controls.Add(UserControlTab);
            formtabcontrol1.Controls.Add(SystemLogTab);
            formtabcontrol1.Location = new Point(8, 7);
            formtabcontrol1.Margin = new Padding(2);
            formtabcontrol1.Multiline = true;
            formtabcontrol1.Name = "formtabcontrol1";
            formtabcontrol1.SelectedIndex = 0;
            formtabcontrol1.Size = new Size(592, 494);
            formtabcontrol1.TabIndex = 0;
            // 
            // QuanLyDonViTab
            // 
            QuanLyDonViTab.Controls.Add(groupBox2);
            QuanLyDonViTab.Controls.Add(groupBox1);
            QuanLyDonViTab.Location = new Point(4, 44);
            QuanLyDonViTab.Margin = new Padding(2);
            QuanLyDonViTab.Name = "QuanLyDonViTab";
            QuanLyDonViTab.Padding = new Padding(2);
            QuanLyDonViTab.Size = new Size(584, 446);
            QuanLyDonViTab.TabIndex = 0;
            QuanLyDonViTab.Text = "Quản Lý Đơn Vị";
            QuanLyDonViTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(DanhSachHuyenDGV);
            groupBox2.Controls.Add(SuaHuyen);
            groupBox2.Controls.Add(XoaHuyen);
            groupBox2.Controls.Add(ThemHuyen);
            groupBox2.Location = new Point(18, 13);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(547, 207);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Huyện";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // DanhSachHuyenDGV
            // 
            DanhSachHuyenDGV.AllowUserToAddRows = false;
            DanhSachHuyenDGV.AllowUserToDeleteRows = false;
            DanhSachHuyenDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachHuyenDGV.Location = new Point(21, 50);
            DanhSachHuyenDGV.Name = "DanhSachHuyenDGV";
            DanhSachHuyenDGV.RowHeadersWidth = 62;
            DanhSachHuyenDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DanhSachHuyenDGV.Size = new Size(326, 152);
            DanhSachHuyenDGV.TabIndex = 5;
            // 
            // SuaHuyen
            // 
            SuaHuyen.Location = new Point(396, 125);
            SuaHuyen.Margin = new Padding(2);
            SuaHuyen.Name = "SuaHuyen";
            SuaHuyen.Size = new Size(107, 38);
            SuaHuyen.TabIndex = 4;
            SuaHuyen.Text = "Sửa";
            SuaHuyen.UseVisualStyleBackColor = true;
            SuaHuyen.Click += SuaHuyen_Click;
            // 
            // XoaHuyen
            // 
            XoaHuyen.Location = new Point(396, 83);
            XoaHuyen.Margin = new Padding(2);
            XoaHuyen.Name = "XoaHuyen";
            XoaHuyen.Size = new Size(107, 38);
            XoaHuyen.TabIndex = 3;
            XoaHuyen.Text = "Xoá";
            XoaHuyen.UseVisualStyleBackColor = true;
            XoaHuyen.Click += XoaHuyen_Click;
            // 
            // ThemHuyen
            // 
            ThemHuyen.Location = new Point(396, 41);
            ThemHuyen.Margin = new Padding(2);
            ThemHuyen.Name = "ThemHuyen";
            ThemHuyen.Size = new Size(107, 38);
            ThemHuyen.TabIndex = 2;
            ThemHuyen.Text = "Thêm";
            ThemHuyen.UseVisualStyleBackColor = true;
            ThemHuyen.Click += ThemHuyen_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(SuaXa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(XoaXa);
            groupBox1.Controls.Add(ThemXa);
            groupBox1.Controls.Add(DanhSachHuyen);
            groupBox1.Controls.Add(DanhSachXa);
            groupBox1.Location = new Point(18, 224);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(547, 215);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xã";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // SuaXa
            // 
            SuaXa.Location = new Point(396, 160);
            SuaXa.Margin = new Padding(2);
            SuaXa.Name = "SuaXa";
            SuaXa.Size = new Size(107, 45);
            SuaXa.TabIndex = 3;
            SuaXa.Text = "Sửa";
            SuaXa.UseVisualStyleBackColor = true;
            SuaXa.Click += SuaXa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 16);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Chọn Huyện";
            // 
            // XoaXa
            // 
            XoaXa.Location = new Point(396, 111);
            XoaXa.Margin = new Padding(2);
            XoaXa.Name = "XoaXa";
            XoaXa.Size = new Size(107, 45);
            XoaXa.TabIndex = 2;
            XoaXa.Text = "Xoá";
            XoaXa.UseVisualStyleBackColor = true;
            XoaXa.Click += XoaXa_Click;
            // 
            // ThemXa
            // 
            ThemXa.Location = new Point(396, 62);
            ThemXa.Margin = new Padding(2);
            ThemXa.Name = "ThemXa";
            ThemXa.Size = new Size(107, 46);
            ThemXa.TabIndex = 1;
            ThemXa.Text = "Thêm";
            ThemXa.UseVisualStyleBackColor = true;
            ThemXa.Click += ThemXa_Click;
            // 
            // DanhSachHuyen
            // 
            DanhSachHuyen.FormattingEnabled = true;
            DanhSachHuyen.Location = new Point(354, 33);
            DanhSachHuyen.Margin = new Padding(2);
            DanhSachHuyen.Name = "DanhSachHuyen";
            DanhSachHuyen.Size = new Size(189, 23);
            DanhSachHuyen.TabIndex = 1;
            DanhSachHuyen.SelectedIndexChanged += DanhSachHuyen_SelectedIndexChanged;
            // 
            // DanhSachXa
            // 
            DanhSachXa.AllowUserToAddRows = false;
            DanhSachXa.AllowUserToDeleteRows = false;
            DanhSachXa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachXa.Location = new Point(21, 44);
            DanhSachXa.Margin = new Padding(2);
            DanhSachXa.Name = "DanhSachXa";
            DanhSachXa.RowHeadersWidth = 62;
            DanhSachXa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DanhSachXa.Size = new Size(326, 160);
            DanhSachXa.TabIndex = 0;
            // 
            // QuanLyDongVatTab
            // 
            QuanLyDongVatTab.Controls.Add(button13);
            QuanLyDongVatTab.Controls.Add(button9);
            QuanLyDongVatTab.Controls.Add(button8);
            QuanLyDongVatTab.Controls.Add(button4);
            QuanLyDongVatTab.Controls.Add(QuanLyDanhMucDongVat);
            QuanLyDongVatTab.Location = new Point(4, 44);
            QuanLyDongVatTab.Margin = new Padding(2);
            QuanLyDongVatTab.Name = "QuanLyDongVatTab";
            QuanLyDongVatTab.Padding = new Padding(2);
            QuanLyDongVatTab.Size = new Size(584, 446);
            QuanLyDongVatTab.TabIndex = 1;
            QuanLyDongVatTab.Text = "Quản Lý Động Vật";
            QuanLyDongVatTab.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(321, 168);
            button9.Name = "button9";
            button9.Size = new Size(189, 53);
            button9.TabIndex = 3;
            button9.Text = "Quản Lý Danh Mục Biến Động";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(72, 168);
            button8.Name = "button8";
            button8.Size = new Size(189, 53);
            button8.TabIndex = 2;
            button8.Text = "Quản Lý Biến Động";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.Location = new Point(72, 69);
            button4.Name = "button4";
            button4.Size = new Size(189, 52);
            button4.TabIndex = 1;
            button4.Text = "Quản Lý Động Vật";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // QuanLyDanhMucDongVat
            // 
            QuanLyDanhMucDongVat.Location = new Point(321, 69);
            QuanLyDanhMucDongVat.Name = "QuanLyDanhMucDongVat";
            QuanLyDanhMucDongVat.Size = new Size(189, 60);
            QuanLyDanhMucDongVat.TabIndex = 0;
            QuanLyDanhMucDongVat.Text = "Quản Lý Danh Mục Động Vật";
            QuanLyDanhMucDongVat.UseVisualStyleBackColor = true;
            QuanLyDanhMucDongVat.Click += QuanLyDanhMucDongVat_Click;
            // 
            // TaiKhoanTab
            // 
            TaiKhoanTab.Controls.Add(button6);
            TaiKhoanTab.Controls.Add(renterpwdlb);
            TaiKhoanTab.Controls.Add(ChangePwd);
            TaiKhoanTab.Controls.Add(label7);
            TaiKhoanTab.Controls.Add(label6);
            TaiKhoanTab.Controls.Add(label5);
            TaiKhoanTab.Controls.Add(renterpwd);
            TaiKhoanTab.Controls.Add(newpwd);
            TaiKhoanTab.Controls.Add(crpwd);
            TaiKhoanTab.Controls.Add(button5);
            TaiKhoanTab.Location = new Point(4, 44);
            TaiKhoanTab.Margin = new Padding(2);
            TaiKhoanTab.Name = "TaiKhoanTab";
            TaiKhoanTab.Padding = new Padding(2);
            TaiKhoanTab.Size = new Size(584, 446);
            TaiKhoanTab.TabIndex = 2;
            TaiKhoanTab.Text = "Tài Khoản";
            TaiKhoanTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(240, 251);
            button6.Name = "button6";
            button6.Size = new Size(117, 45);
            button6.TabIndex = 9;
            button6.Text = "Thông tin tài khoản";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // renterpwdlb
            // 
            renterpwdlb.AutoSize = true;
            renterpwdlb.Location = new Point(184, 147);
            renterpwdlb.Name = "renterpwdlb";
            renterpwdlb.Size = new Size(104, 15);
            renterpwdlb.TabIndex = 8;
            renterpwdlb.Text = "Nhập lại mật khẩu";
            // 
            // ChangePwd
            // 
            ChangePwd.Location = new Point(238, 204);
            ChangePwd.Name = "ChangePwd";
            ChangePwd.Size = new Size(119, 23);
            ChangePwd.TabIndex = 7;
            ChangePwd.Text = "Đổi mật khẩu";
            ChangePwd.UseVisualStyleBackColor = true;
            ChangePwd.Click += ChangePwd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 146);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 101);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 55);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu hiện tại";
            // 
            // renterpwd
            // 
            renterpwd.Location = new Point(183, 165);
            renterpwd.Name = "renterpwd";
            renterpwd.PasswordChar = '●';
            renterpwd.Size = new Size(229, 23);
            renterpwd.TabIndex = 3;
            // 
            // newpwd
            // 
            newpwd.Location = new Point(183, 119);
            newpwd.Name = "newpwd";
            newpwd.PasswordChar = '●';
            newpwd.Size = new Size(229, 23);
            newpwd.TabIndex = 2;
            // 
            // crpwd
            // 
            crpwd.Location = new Point(183, 73);
            crpwd.Name = "crpwd";
            crpwd.PasswordChar = '●';
            crpwd.Size = new Size(229, 23);
            crpwd.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(260, 314);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            button5.Text = "Đăng Xuất";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // QuanLyGiongCayTab
            // 
            QuanLyGiongCayTab.Controls.Add(button12);
            QuanLyGiongCayTab.Controls.Add(button11);
            QuanLyGiongCayTab.Controls.Add(button10);
            QuanLyGiongCayTab.Location = new Point(4, 44);
            QuanLyGiongCayTab.Margin = new Padding(2);
            QuanLyGiongCayTab.Name = "QuanLyGiongCayTab";
            QuanLyGiongCayTab.Padding = new Padding(2);
            QuanLyGiongCayTab.Size = new Size(584, 446);
            QuanLyGiongCayTab.TabIndex = 3;
            QuanLyGiongCayTab.Text = "Quản Lý Giống Cây";
            QuanLyGiongCayTab.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(214, 237);
            button12.Name = "button12";
            button12.Size = new Size(186, 89);
            button12.TabIndex = 2;
            button12.Text = "Quản Lý Cơ Sở Sản Xuất Giống Cây";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(329, 127);
            button11.Name = "button11";
            button11.Size = new Size(189, 65);
            button11.TabIndex = 1;
            button11.Text = "Quản Lý Giống Cây";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(94, 127);
            button10.Name = "button10";
            button10.Size = new Size(201, 65);
            button10.TabIndex = 0;
            button10.Text = "Quản Lý Danh Mục Giống Cây";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // QLCheBienGo
            // 
            QLCheBienGo.Location = new Point(4, 44);
            QLCheBienGo.Margin = new Padding(2);
            QLCheBienGo.Name = "QLCheBienGo";
            QLCheBienGo.Padding = new Padding(2);
            QLCheBienGo.Size = new Size(584, 446);
            QLCheBienGo.TabIndex = 4;
            QLCheBienGo.Text = "Quản Lý Chế Biến Gỗ";
            QLCheBienGo.UseVisualStyleBackColor = true;
            // 
            // HuongDanTab
            // 
            HuongDanTab.Controls.Add(groupBox5);
            HuongDanTab.Controls.Add(groupBox3);
            HuongDanTab.Location = new Point(4, 44);
            HuongDanTab.Margin = new Padding(2);
            HuongDanTab.Name = "HuongDanTab";
            HuongDanTab.Padding = new Padding(2);
            HuongDanTab.Size = new Size(584, 446);
            HuongDanTab.TabIndex = 5;
            HuongDanTab.Text = "Hướng Dẫn";
            HuongDanTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(richTextBox4);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(22, 245);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(534, 197);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Xem hướng dẫn";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(7, 80);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(316, 96);
            richTextBox4.TabIndex = 2;
            richTextBox4.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(7, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(316, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(371, 57);
            button3.Name = "button3";
            button3.Size = new Size(105, 67);
            button3.TabIndex = 0;
            button3.Text = "Xoá Hướng Dẫn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(22, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(534, 197);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm Hướng Dẫn";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(6, 82);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(324, 96);
            richTextBox3.TabIndex = 0;
            richTextBox3.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(371, 59);
            button2.Name = "button2";
            button2.Size = new Size(105, 79);
            button2.TabIndex = 4;
            button2.Text = "Thêm Hướng Dẫn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(7, 33);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 23);
            textBox4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 59);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 3;
            label4.Text = "Nội dung hướng dẫn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 15);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Tiêu đề hướng dẫn";
            // 
            // UserControlTab
            // 
            UserControlTab.Controls.Add(label8);
            UserControlTab.Controls.Add(textBox5);
            UserControlTab.Controls.Add(dataGridView2);
            UserControlTab.Location = new Point(4, 44);
            UserControlTab.Margin = new Padding(2);
            UserControlTab.Name = "UserControlTab";
            UserControlTab.Padding = new Padding(2);
            UserControlTab.Size = new Size(584, 446);
            UserControlTab.TabIndex = 6;
            UserControlTab.Text = "Quản Lý Người Dùng";
            UserControlTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 25);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 2;
            label8.Text = "Tìm kiếm";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 52);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(368, 23);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 83);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(367, 135);
            dataGridView2.TabIndex = 0;
            // 
            // SystemLogTab
            // 
            SystemLogTab.Controls.Add(button7);
            SystemLogTab.Controls.Add(button1);
            SystemLogTab.Controls.Add(richTextBox2);
            SystemLogTab.Controls.Add(label1);
            SystemLogTab.Controls.Add(textBox1);
            SystemLogTab.Controls.Add(DanhSachLog);
            SystemLogTab.Controls.Add(richTextBox1);
            SystemLogTab.Location = new Point(4, 44);
            SystemLogTab.Margin = new Padding(2);
            SystemLogTab.Name = "SystemLogTab";
            SystemLogTab.Padding = new Padding(2);
            SystemLogTab.Size = new Size(584, 446);
            SystemLogTab.TabIndex = 7;
            SystemLogTab.Text = "SystemLog";
            SystemLogTab.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(428, 396);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(99, 40);
            button7.TabIndex = 7;
            button7.Text = "Báo cáo tác động hệ thống";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(242, 396);
            button1.Name = "button1";
            button1.Size = new Size(92, 40);
            button1.TabIndex = 6;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(19, 234);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(554, 26);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 13);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DanhSachLog
            // 
            DanhSachLog.AllowUserToAddRows = false;
            DanhSachLog.AllowUserToDeleteRows = false;
            DanhSachLog.AllowUserToOrderColumns = true;
            DanhSachLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DanhSachLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachLog.Columns.AddRange(new DataGridViewColumn[] { logIdDataGridViewTextBoxColumn, logIndexDataGridViewTextBoxColumn, logTypeDataGridViewTextBoxColumn, logEventDataGridViewTextBoxColumn });
            DanhSachLog.Location = new Point(17, 67);
            DanhSachLog.MultiSelect = false;
            DanhSachLog.Name = "DanhSachLog";
            DanhSachLog.ReadOnly = true;
            DanhSachLog.RowHeadersVisible = false;
            DanhSachLog.RowHeadersWidth = 62;
            DanhSachLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DanhSachLog.Size = new Size(555, 150);
            DanhSachLog.TabIndex = 2;
            DanhSachLog.CellClick += DanhSachLog_CellClick;
            // 
            // logIdDataGridViewTextBoxColumn
            // 
            logIdDataGridViewTextBoxColumn.DataPropertyName = "LogId";
            logIdDataGridViewTextBoxColumn.HeaderText = "LogId";
            logIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            logIdDataGridViewTextBoxColumn.Name = "logIdDataGridViewTextBoxColumn";
            logIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logIndexDataGridViewTextBoxColumn
            // 
            logIndexDataGridViewTextBoxColumn.DataPropertyName = "LogIndex";
            logIndexDataGridViewTextBoxColumn.HeaderText = "LogIndex";
            logIndexDataGridViewTextBoxColumn.MinimumWidth = 8;
            logIndexDataGridViewTextBoxColumn.Name = "logIndexDataGridViewTextBoxColumn";
            logIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logTypeDataGridViewTextBoxColumn
            // 
            logTypeDataGridViewTextBoxColumn.DataPropertyName = "LogType";
            logTypeDataGridViewTextBoxColumn.HeaderText = "LogType";
            logTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            logTypeDataGridViewTextBoxColumn.Name = "logTypeDataGridViewTextBoxColumn";
            logTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logEventDataGridViewTextBoxColumn
            // 
            logEventDataGridViewTextBoxColumn.DataPropertyName = "LogEvent";
            logEventDataGridViewTextBoxColumn.HeaderText = "LogEvent";
            logEventDataGridViewTextBoxColumn.MinimumWidth = 8;
            logEventDataGridViewTextBoxColumn.Name = "logEventDataGridViewTextBoxColumn";
            logEventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(19, 265);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(554, 102);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // logTableBindingSource1
            // 
            logTableBindingSource1.DataSource = typeof(LogTable);
            // 
            // button13
            // 
            button13.Location = new Point(321, 280);
            button13.Name = "button13";
            button13.Size = new Size(189, 57);
            button13.TabIndex = 4;
            button13.Text = "Quản Lý Danh Mục Lưu Trữ";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 512);
            Controls.Add(formtabcontrol1);
            Margin = new Padding(2);
            Name = "MainUI";
            Text = "MainUI";
            formtabcontrol1.ResumeLayout(false);
            QuanLyDonViTab.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachHuyenDGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachXa).EndInit();
            QuanLyDongVatTab.ResumeLayout(false);
            TaiKhoanTab.ResumeLayout(false);
            TaiKhoanTab.PerformLayout();
            QuanLyGiongCayTab.ResumeLayout(false);
            HuongDanTab.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            UserControlTab.ResumeLayout(false);
            UserControlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            SystemLogTab.ResumeLayout(false);
            SystemLogTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)logTableBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl formtabcontrol1;
        private TabPage QuanLyDonViTab;
        private TabPage QuanLyDongVatTab;
        private TabPage TaiKhoanTab;
        private TabPage QuanLyGiongCayTab;
        private TabPage QLCheBienGo;
        private TabPage HuongDanTab;
        private TabPage UserControlTab;
        private TabPage SystemLogTab;
        private RichTextBox richTextBox1;
        private DataGridView DanhSachLog;
        private RichTextBox richTextBox2;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn logIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn logIndexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn logTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn logEventDataGridViewTextBoxColumn;
        private BindingSource logTableBindingSource1;
        private DataGridView dataGridView2;
        private ComboBox DanhSachHuyen;
        private DataGridView DanhSachXa;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button XoaHuyen;
        private Button ThemHuyen;
        private Button SuaHuyen;
        private Button SuaXa;
        private Button XoaXa;
        private Button ThemXa;
        private TextBox textBox2;
        private Label label2;
        private DataGridView DanhSachHuyenDGV;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private RichTextBox richTextBox3;
        private Button button2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private RichTextBox richTextBox4;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Button QuanLyDanhMucDongVat;
        private Button button5;
        private Button ChangePwd;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox renterpwd;
        private TextBox newpwd;
        private TextBox crpwd;
        private Label renterpwdlb;
        private Button button6;
        private Button button7;
        private Label label8;
        private TextBox textBox5;
        private Button button9;
        private Button button8;
        private Button button11;
        private Button button10;
        private Button button12;
        private Button button13;
    }
}