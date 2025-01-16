namespace ForestResourceManagement.MixForm
{
    partial class QuanLyDanhMucBienDong
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
            SuaDanhMucBienDong = new Button();
            XoaDanhMucBienDong = new Button();
            ThemDanhMucBienDong = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SuaDanhMucBienDong
            // 
            SuaDanhMucBienDong.Location = new Point(582, 291);
            SuaDanhMucBienDong.Name = "SuaDanhMucBienDong";
            SuaDanhMucBienDong.Size = new Size(161, 48);
            SuaDanhMucBienDong.TabIndex = 15;
            SuaDanhMucBienDong.Text = "SuaDanhMucBienDong";
            SuaDanhMucBienDong.UseVisualStyleBackColor = true;
            SuaDanhMucBienDong.Click += SuaDanhMucBienDong_Click;
            // 
            // XoaDanhMucBienDong
            // 
            XoaDanhMucBienDong.Location = new Point(582, 235);
            XoaDanhMucBienDong.Name = "XoaDanhMucBienDong";
            XoaDanhMucBienDong.Size = new Size(161, 50);
            XoaDanhMucBienDong.TabIndex = 14;
            XoaDanhMucBienDong.Text = "XoaDanhMucBienDong";
            XoaDanhMucBienDong.UseVisualStyleBackColor = true;
            XoaDanhMucBienDong.Click += XoaDanhMucBienDong_Click;
            // 
            // ThemDanhMucBienDong
            // 
            ThemDanhMucBienDong.Location = new Point(582, 180);
            ThemDanhMucBienDong.Name = "ThemDanhMucBienDong";
            ThemDanhMucBienDong.Size = new Size(161, 49);
            ThemDanhMucBienDong.TabIndex = 13;
            ThemDanhMucBienDong.Text = "ThemDanhMucBienDong";
            ThemDanhMucBienDong.UseVisualStyleBackColor = true;
            ThemDanhMucBienDong.Click += ThemDanhMucBienDong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(452, 226);
            dataGridView1.TabIndex = 10;
            // 
            // QuanLyDanhMucBienDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SuaDanhMucBienDong);
            Controls.Add(XoaDanhMucBienDong);
            Controls.Add(ThemDanhMucBienDong);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "QuanLyDanhMucBienDong";
            Text = "QuanLyDanhMucBienDong";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SuaDanhMucBienDong;
        private Button XoaDanhMucBienDong;
        private Button ThemDanhMucBienDong;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}