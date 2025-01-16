namespace ForestResourceManagement.MixForm
{
    partial class QuanLyBienDong
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            SuaBienDong = new Button();
            XoaDV = new Button();
            ThemBienDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(452, 226);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // SuaBienDong
            // 
            SuaBienDong.Location = new Point(647, 274);
            SuaBienDong.Name = "SuaBienDong";
            SuaBienDong.Size = new Size(106, 33);
            SuaBienDong.TabIndex = 9;
            SuaBienDong.Text = "SuaBienDong";
            SuaBienDong.UseVisualStyleBackColor = true;
            SuaBienDong.Click += SuaBienDong_Click;
            // 
            // XoaDV
            // 
            XoaDV.Location = new Point(647, 218);
            XoaDV.Name = "XoaDV";
            XoaDV.Size = new Size(106, 34);
            XoaDV.TabIndex = 8;
            XoaDV.Text = "XoaBienDong";
            XoaDV.UseVisualStyleBackColor = true;
            XoaDV.Click += XoaDV_Click;
            // 
            // ThemBienDong
            // 
            ThemBienDong.Location = new Point(647, 163);
            ThemBienDong.Name = "ThemBienDong";
            ThemBienDong.Size = new Size(106, 33);
            ThemBienDong.TabIndex = 7;
            ThemBienDong.Text = "ThemBienDong";
            ThemBienDong.UseVisualStyleBackColor = true;
            ThemBienDong.Click += ThemBienDong_Click;
            // 
            // QuanLyBienDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SuaBienDong);
            Controls.Add(XoaDV);
            Controls.Add(ThemBienDong);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "QuanLyBienDong";
            Text = "QuanLyBienDong";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button SuaBienDong;
        private Button XoaDV;
        private Button ThemBienDong;
    }
}