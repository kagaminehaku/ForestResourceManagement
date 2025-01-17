namespace ForestResourceManagement.MixForm.QLGiongCay
{
    partial class QuanLyGiongCay
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
            label1 = new Label();
            textBox1 = new TextBox();
            SuaGiongCay = new Button();
            dataGridView1 = new DataGridView();
            XoaGiongCay = new Button();
            ThemGiongCay = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 48);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 11;
            label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // SuaGiongCay
            // 
            SuaGiongCay.Location = new Point(633, 318);
            SuaGiongCay.Name = "SuaGiongCay";
            SuaGiongCay.Size = new Size(109, 31);
            SuaGiongCay.TabIndex = 9;
            SuaGiongCay.Text = "SuaGiongCay";
            SuaGiongCay.UseVisualStyleBackColor = true;
            SuaGiongCay.Click += SuaGiongCay_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(114, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(385, 248);
            dataGridView1.TabIndex = 8;
            // 
            // XoaGiongCay
            // 
            XoaGiongCay.Location = new Point(633, 262);
            XoaGiongCay.Name = "XoaGiongCay";
            XoaGiongCay.Size = new Size(109, 30);
            XoaGiongCay.TabIndex = 7;
            XoaGiongCay.Text = "XoaGiongCay";
            XoaGiongCay.UseVisualStyleBackColor = true;
            XoaGiongCay.Click += XoaGiongCay_Click;
            // 
            // ThemGiongCay
            // 
            ThemGiongCay.Location = new Point(633, 205);
            ThemGiongCay.Name = "ThemGiongCay";
            ThemGiongCay.Size = new Size(109, 31);
            ThemGiongCay.TabIndex = 6;
            ThemGiongCay.Text = "ThemGiongCay";
            ThemGiongCay.UseVisualStyleBackColor = true;
            ThemGiongCay.Click += ThemGiongCay_Click;
            // 
            // QuanLyGiongCay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(SuaGiongCay);
            Controls.Add(dataGridView1);
            Controls.Add(XoaGiongCay);
            Controls.Add(ThemGiongCay);
            Name = "QuanLyGiongCay";
            Text = "QuanLyGiongCay";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button SuaGiongCay;
        private DataGridView dataGridView1;
        private Button XoaGiongCay;
        private Button ThemGiongCay;
    }
}