namespace ForestResourceManagement.MixForm
{
    partial class QuanLyDongVat
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
            ThemDV = new Button();
            XoaDV = new Button();
            dataGridView1 = new DataGridView();
            SuaDV = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ThemDV
            // 
            ThemDV.Location = new Point(610, 208);
            ThemDV.Name = "ThemDV";
            ThemDV.Size = new Size(75, 23);
            ThemDV.TabIndex = 0;
            ThemDV.Text = "ThemDV";
            ThemDV.UseVisualStyleBackColor = true;
            ThemDV.Click += ThemDV_Click;
            // 
            // XoaDV
            // 
            XoaDV.Location = new Point(610, 265);
            XoaDV.Name = "XoaDV";
            XoaDV.Size = new Size(75, 23);
            XoaDV.TabIndex = 1;
            XoaDV.Text = "XoaDV";
            XoaDV.UseVisualStyleBackColor = true;
            XoaDV.Click += XoaDV_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(385, 248);
            dataGridView1.TabIndex = 2;
            // 
            // SuaDV
            // 
            SuaDV.Location = new Point(610, 321);
            SuaDV.Name = "SuaDV";
            SuaDV.Size = new Size(75, 23);
            SuaDV.TabIndex = 3;
            SuaDV.Text = "SuaDV";
            SuaDV.UseVisualStyleBackColor = true;
            SuaDV.Click += SuaDV_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 51);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Tìm kiếm";
            // 
            // QuanLyDongVat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(SuaDV);
            Controls.Add(dataGridView1);
            Controls.Add(XoaDV);
            Controls.Add(ThemDV);
            Name = "QuanLyDongVat";
            Text = "QuanLyDongVat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ThemDV;
        private Button XoaDV;
        private DataGridView dataGridView1;
        private Button SuaDV;
        private TextBox textBox1;
        private Label label1;
    }
}