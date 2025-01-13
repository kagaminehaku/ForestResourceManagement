
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
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            button4 = new Button();
            QuanLyDanhMucDongVat = new Button();
            tabPage3 = new TabPage();
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
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
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
            tabPage7 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage8 = new TabPage();
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
            textBox5 = new TextBox();
            label8 = new Label();
            formtabcontrol1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachHuyenDGV).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachXa).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logTableBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // formtabcontrol1
            // 
            formtabcontrol1.Controls.Add(tabPage1);
            formtabcontrol1.Controls.Add(tabPage2);
            formtabcontrol1.Controls.Add(tabPage3);
            formtabcontrol1.Controls.Add(tabPage4);
            formtabcontrol1.Controls.Add(tabPage5);
            formtabcontrol1.Controls.Add(tabPage6);
            formtabcontrol1.Controls.Add(tabPage7);
            formtabcontrol1.Controls.Add(tabPage8);
            formtabcontrol1.Location = new Point(11, 12);
            formtabcontrol1.Multiline = true;
            formtabcontrol1.Name = "formtabcontrol1";
            formtabcontrol1.SelectedIndex = 0;
            formtabcontrol1.Size = new Size(846, 823);
            formtabcontrol1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 64);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(838, 755);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Đơn Vị";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(DanhSachHuyenDGV);
            groupBox2.Controls.Add(SuaHuyen);
            groupBox2.Controls.Add(XoaHuyen);
            groupBox2.Controls.Add(ThemHuyen);
            groupBox2.Location = new Point(26, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(781, 345);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Huyện";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 40);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(468, 31);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // DanhSachHuyenDGV
            // 
            DanhSachHuyenDGV.AllowUserToAddRows = false;
            DanhSachHuyenDGV.AllowUserToDeleteRows = false;
            DanhSachHuyenDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachHuyenDGV.Location = new Point(30, 83);
            DanhSachHuyenDGV.Margin = new Padding(4, 5, 4, 5);
            DanhSachHuyenDGV.Name = "DanhSachHuyenDGV";
            DanhSachHuyenDGV.RowHeadersWidth = 62;
            DanhSachHuyenDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DanhSachHuyenDGV.Size = new Size(466, 253);
            DanhSachHuyenDGV.TabIndex = 5;
            // 
            // SuaHuyen
            // 
            SuaHuyen.Location = new Point(566, 208);
            SuaHuyen.Name = "SuaHuyen";
            SuaHuyen.Size = new Size(153, 63);
            SuaHuyen.TabIndex = 4;
            SuaHuyen.Text = "Sửa";
            SuaHuyen.UseVisualStyleBackColor = true;
            SuaHuyen.Click += SuaHuyen_Click;
            // 
            // XoaHuyen
            // 
            XoaHuyen.Location = new Point(566, 138);
            XoaHuyen.Name = "XoaHuyen";
            XoaHuyen.Size = new Size(153, 63);
            XoaHuyen.TabIndex = 3;
            XoaHuyen.Text = "Xoá";
            XoaHuyen.UseVisualStyleBackColor = true;
            XoaHuyen.Click += XoaHuyen_Click;
            // 
            // ThemHuyen
            // 
            ThemHuyen.Location = new Point(566, 68);
            ThemHuyen.Name = "ThemHuyen";
            ThemHuyen.Size = new Size(153, 63);
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
            groupBox1.Location = new Point(26, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 358);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xã";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 27);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(465, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // SuaXa
            // 
            SuaXa.Location = new Point(566, 267);
            SuaXa.Name = "SuaXa";
            SuaXa.Size = new Size(153, 75);
            SuaXa.TabIndex = 3;
            SuaXa.Text = "Sửa";
            SuaXa.UseVisualStyleBackColor = true;
            SuaXa.Click += SuaXa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 4;
            label2.Text = "Chọn Huyện";
            // 
            // XoaXa
            // 
            XoaXa.Location = new Point(566, 185);
            XoaXa.Name = "XoaXa";
            XoaXa.Size = new Size(153, 75);
            XoaXa.TabIndex = 2;
            XoaXa.Text = "Xoá";
            XoaXa.UseVisualStyleBackColor = true;
            XoaXa.Click += XoaXa_Click;
            // 
            // ThemXa
            // 
            ThemXa.Location = new Point(566, 103);
            ThemXa.Name = "ThemXa";
            ThemXa.Size = new Size(153, 77);
            ThemXa.TabIndex = 1;
            ThemXa.Text = "Thêm";
            ThemXa.UseVisualStyleBackColor = true;
            ThemXa.Click += ThemXa_Click;
            // 
            // DanhSachHuyen
            // 
            DanhSachHuyen.FormattingEnabled = true;
            DanhSachHuyen.Location = new Point(506, 55);
            DanhSachHuyen.Name = "DanhSachHuyen";
            DanhSachHuyen.Size = new Size(268, 33);
            DanhSachHuyen.TabIndex = 1;
            DanhSachHuyen.SelectedIndexChanged += DanhSachHuyen_SelectedIndexChanged;
            // 
            // DanhSachXa
            // 
            DanhSachXa.AllowUserToAddRows = false;
            DanhSachXa.AllowUserToDeleteRows = false;
            DanhSachXa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachXa.Location = new Point(30, 73);
            DanhSachXa.Name = "DanhSachXa";
            DanhSachXa.RowHeadersWidth = 62;
            DanhSachXa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DanhSachXa.Size = new Size(466, 267);
            DanhSachXa.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(QuanLyDanhMucDongVat);
            tabPage2.Location = new Point(4, 64);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(838, 755);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản Lý Động Vật";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(116, 253);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(270, 87);
            button4.TabIndex = 1;
            button4.Text = "Quản Lý Động Vật";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // QuanLyDanhMucDongVat
            // 
            QuanLyDanhMucDongVat.Location = new Point(471, 253);
            QuanLyDanhMucDongVat.Margin = new Padding(4, 5, 4, 5);
            QuanLyDanhMucDongVat.Name = "QuanLyDanhMucDongVat";
            QuanLyDanhMucDongVat.Size = new Size(270, 100);
            QuanLyDanhMucDongVat.TabIndex = 0;
            QuanLyDanhMucDongVat.Text = "Quản Lý Danh Mục";
            QuanLyDanhMucDongVat.UseVisualStyleBackColor = true;
            QuanLyDanhMucDongVat.Click += QuanLyDanhMucDongVat_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(renterpwdlb);
            tabPage3.Controls.Add(ChangePwd);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(renterpwd);
            tabPage3.Controls.Add(newpwd);
            tabPage3.Controls.Add(crpwd);
            tabPage3.Controls.Add(button5);
            tabPage3.Location = new Point(4, 64);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(838, 755);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tài Khoản";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(343, 418);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(167, 75);
            button6.TabIndex = 9;
            button6.Text = "Thông tin tài khoản";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // renterpwdlb
            // 
            renterpwdlb.AutoSize = true;
            renterpwdlb.Location = new Point(263, 245);
            renterpwdlb.Margin = new Padding(4, 0, 4, 0);
            renterpwdlb.Name = "renterpwdlb";
            renterpwdlb.Size = new Size(156, 25);
            renterpwdlb.TabIndex = 8;
            renterpwdlb.Text = "Nhập lại mật khẩu";
            // 
            // ChangePwd
            // 
            ChangePwd.Location = new Point(340, 340);
            ChangePwd.Margin = new Padding(4, 5, 4, 5);
            ChangePwd.Name = "ChangePwd";
            ChangePwd.Size = new Size(170, 38);
            ChangePwd.TabIndex = 7;
            ChangePwd.Text = "Đổi mật khẩu";
            ChangePwd.UseVisualStyleBackColor = true;
            ChangePwd.Click += ChangePwd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 243);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 168);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 92);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu hiện tại";
            // 
            // renterpwd
            // 
            renterpwd.Location = new Point(261, 275);
            renterpwd.Margin = new Padding(4, 5, 4, 5);
            renterpwd.Name = "renterpwd";
            renterpwd.PasswordChar = '●';
            renterpwd.Size = new Size(325, 31);
            renterpwd.TabIndex = 3;
            // 
            // newpwd
            // 
            newpwd.Location = new Point(261, 198);
            newpwd.Margin = new Padding(4, 5, 4, 5);
            newpwd.Name = "newpwd";
            newpwd.PasswordChar = '●';
            newpwd.Size = new Size(325, 31);
            newpwd.TabIndex = 2;
            // 
            // crpwd
            // 
            crpwd.Location = new Point(261, 122);
            crpwd.Margin = new Padding(4, 5, 4, 5);
            crpwd.Name = "crpwd";
            crpwd.PasswordChar = '●';
            crpwd.Size = new Size(325, 31);
            crpwd.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(371, 523);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(107, 38);
            button5.TabIndex = 0;
            button5.Text = "Đăng Xuất";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 64);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(838, 755);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 64);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(838, 755);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(groupBox5);
            tabPage6.Controls.Add(groupBox3);
            tabPage6.Location = new Point(4, 64);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(838, 755);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Instruction";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(richTextBox4);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(31, 408);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(763, 328);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Xem hướng dẫn";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(10, 133);
            richTextBox4.Margin = new Padding(4, 5, 4, 5);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(450, 157);
            richTextBox4.TabIndex = 2;
            richTextBox4.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 57);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(450, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(530, 95);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(150, 112);
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
            groupBox3.Location = new Point(31, 25);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(763, 328);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm Hướng Dẫn";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(9, 137);
            richTextBox3.Margin = new Padding(4, 5, 4, 5);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(461, 157);
            richTextBox3.TabIndex = 0;
            richTextBox3.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(530, 98);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(150, 132);
            button2.TabIndex = 4;
            button2.Text = "Thêm Hướng Dẫn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(10, 55);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(460, 31);
            textBox4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 3;
            label4.Text = "Nội dung hướng dẫn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 2;
            label3.Text = "Tiêu đề hướng dẫn";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(label8);
            tabPage7.Controls.Add(textBox5);
            tabPage7.Controls.Add(dataGridView2);
            tabPage7.Location = new Point(4, 64);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(838, 755);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "UserManager";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(39, 138);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(524, 225);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(button7);
            tabPage8.Controls.Add(button1);
            tabPage8.Controls.Add(richTextBox2);
            tabPage8.Controls.Add(label1);
            tabPage8.Controls.Add(textBox1);
            tabPage8.Controls.Add(DanhSachLog);
            tabPage8.Controls.Add(richTextBox1);
            tabPage8.Location = new Point(4, 64);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(838, 755);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "SystemLog";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(611, 660);
            button7.Name = "button7";
            button7.Size = new Size(141, 67);
            button7.TabIndex = 7;
            button7.Text = "Báo cáo tác động hệ thống";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(346, 660);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(131, 67);
            button1.TabIndex = 6;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(27, 390);
            richTextBox2.Margin = new Padding(4, 5, 4, 5);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(790, 41);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 63);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(793, 31);
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
            DanhSachLog.Location = new Point(24, 112);
            DanhSachLog.Margin = new Padding(4, 5, 4, 5);
            DanhSachLog.MultiSelect = false;
            DanhSachLog.Name = "DanhSachLog";
            DanhSachLog.ReadOnly = true;
            DanhSachLog.RowHeadersVisible = false;
            DanhSachLog.RowHeadersWidth = 62;
            DanhSachLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DanhSachLog.Size = new Size(793, 250);
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
            richTextBox1.Location = new Point(27, 442);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(790, 167);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // logTableBindingSource1
            // 
            logTableBindingSource1.DataSource = typeof(LogTable);
            // 
            // textBox5
            // 
            textBox5.Location = new Point(39, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(524, 31);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 41);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 2;
            label8.Text = "Tìm kiếm";
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 853);
            Controls.Add(formtabcontrol1);
            Name = "MainUI";
            Text = "MainUI";
            formtabcontrol1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachHuyenDGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachXa).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)logTableBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl formtabcontrol1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
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
    }
}