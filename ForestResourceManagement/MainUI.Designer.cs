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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DanhSachXa = new DataGridView();
            groupBox1 = new GroupBox();
            DanhSachHuyen = new ComboBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage8 = new TabPage();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            logIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logIndexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logEventDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            richTextBox1 = new RichTextBox();
            logTableBindingSource1 = new BindingSource(components);
            groupBox2 = new GroupBox();
            ThemHuyen = new Button();
            XoaHuyen = new Button();
            SuaHuyen = new Button();
            ThemXa = new Button();
            XoaXa = new Button();
            SuaXa = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachXa).BeginInit();
            groupBox1.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logTableBindingSource1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Location = new Point(11, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(845, 715);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(837, 677);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Administrative Unit";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DanhSachXa
            // 
            DanhSachXa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachXa.Location = new Point(30, 47);
            DanhSachXa.Name = "DanhSachXa";
            DanhSachXa.RowHeadersWidth = 62;
            DanhSachXa.Size = new Size(465, 293);
            DanhSachXa.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SuaXa);
            groupBox1.Controls.Add(XoaXa);
            groupBox1.Controls.Add(ThemXa);
            groupBox1.Controls.Add(DanhSachXa);
            groupBox1.Location = new Point(25, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 367);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xã";
            // 
            // DanhSachHuyen
            // 
            DanhSachHuyen.FormattingEnabled = true;
            DanhSachHuyen.Location = new Point(30, 52);
            DanhSachHuyen.Name = "DanhSachHuyen";
            DanhSachHuyen.Size = new Size(465, 33);
            DanhSachHuyen.TabIndex = 1;
            DanhSachHuyen.SelectedIndexChanged += DanhSachHuyen_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(837, 677);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1035, 677);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(837, 677);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1035, 677);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(837, 677);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "another";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dataGridView2);
            tabPage7.Location = new Point(4, 34);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(837, 677);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "UserManager";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(53, 47);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(360, 225);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(richTextBox2);
            tabPage8.Controls.Add(label1);
            tabPage8.Controls.Add(textBox1);
            tabPage8.Controls.Add(dataGridView1);
            tabPage8.Controls.Add(richTextBox1);
            tabPage8.Location = new Point(4, 34);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(837, 677);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "SystemLog";
            tabPage8.UseVisualStyleBackColor = true;
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
            textBox1.Size = new Size(1081, 31);
            textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { logIdDataGridViewTextBoxColumn, logIndexDataGridViewTextBoxColumn, logTypeDataGridViewTextBoxColumn, logEventDataGridViewTextBoxColumn });
            dataGridView1.Location = new Point(24, 112);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(793, 250);
            dataGridView1.TabIndex = 2;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(SuaHuyen);
            groupBox2.Controls.Add(XoaHuyen);
            groupBox2.Controls.Add(ThemHuyen);
            groupBox2.Controls.Add(DanhSachHuyen);
            groupBox2.Location = new Point(25, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(781, 251);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Huyện";
            // 
            // ThemHuyen
            // 
            ThemHuyen.Location = new Point(565, 21);
            ThemHuyen.Name = "ThemHuyen";
            ThemHuyen.Size = new Size(153, 64);
            ThemHuyen.TabIndex = 2;
            ThemHuyen.Text = "Thêm";
            ThemHuyen.UseVisualStyleBackColor = true;
            ThemHuyen.Click += ThemHuyen_Click;
            // 
            // XoaHuyen
            // 
            XoaHuyen.Location = new Point(565, 92);
            XoaHuyen.Name = "XoaHuyen";
            XoaHuyen.Size = new Size(153, 63);
            XoaHuyen.TabIndex = 3;
            XoaHuyen.Text = "Xoá";
            XoaHuyen.UseVisualStyleBackColor = true;
            XoaHuyen.Click += XoaHuyen_Click;
            // 
            // SuaHuyen
            // 
            SuaHuyen.Location = new Point(565, 161);
            SuaHuyen.Name = "SuaHuyen";
            SuaHuyen.Size = new Size(153, 63);
            SuaHuyen.TabIndex = 4;
            SuaHuyen.Text = "Sửa";
            SuaHuyen.UseVisualStyleBackColor = true;
            SuaHuyen.Click += SuaHuyen_Click;
            // 
            // ThemXa
            // 
            ThemXa.Location = new Point(565, 73);
            ThemXa.Name = "ThemXa";
            ThemXa.Size = new Size(153, 76);
            ThemXa.TabIndex = 1;
            ThemXa.Text = "Thêm";
            ThemXa.UseVisualStyleBackColor = true;
            ThemXa.Click += ThemXa_Click;
            // 
            // XoaXa
            // 
            XoaXa.Location = new Point(565, 155);
            XoaXa.Name = "XoaXa";
            XoaXa.Size = new Size(153, 75);
            XoaXa.TabIndex = 2;
            XoaXa.Text = "Xoá";
            XoaXa.UseVisualStyleBackColor = true;
            XoaXa.Click += XoaXa_Click;
            // 
            // SuaXa
            // 
            SuaXa.Location = new Point(565, 236);
            SuaXa.Name = "SuaXa";
            SuaXa.Size = new Size(153, 75);
            SuaXa.TabIndex = 3;
            SuaXa.Text = "Sửa";
            SuaXa.UseVisualStyleBackColor = true;
            SuaXa.Click += SuaXa_Click;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 738);
            Controls.Add(tabControl1);
            Name = "MainUI";
            Text = "MainUI";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DanhSachXa).EndInit();
            groupBox1.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logTableBindingSource1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
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
    }
}