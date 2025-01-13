namespace ForestResourceManagement.MixForm
{
    partial class QuanLyDanhMucDongVat
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
            SuaDV = new Button();
            XoaDV = new Button();
            ThemDV = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SuaDV
            // 
            SuaDV.Location = new Point(977, 448);
            SuaDV.Margin = new Padding(4, 5, 4, 5);
            SuaDV.Name = "SuaDV";
            SuaDV.Size = new Size(107, 38);
            SuaDV.TabIndex = 6;
            SuaDV.Text = "SuaDV";
            SuaDV.UseVisualStyleBackColor = true;
            SuaDV.Click += SuaDV_Click;
            // 
            // XoaDV
            // 
            XoaDV.Location = new Point(977, 355);
            XoaDV.Margin = new Padding(4, 5, 4, 5);
            XoaDV.Name = "XoaDV";
            XoaDV.Size = new Size(107, 38);
            XoaDV.TabIndex = 5;
            XoaDV.Text = "XoaDV";
            XoaDV.UseVisualStyleBackColor = true;
            XoaDV.Click += XoaDV_Click;
            // 
            // ThemDV
            // 
            ThemDV.Location = new Point(977, 263);
            ThemDV.Margin = new Padding(4, 5, 4, 5);
            ThemDV.Name = "ThemDV";
            ThemDV.Size = new Size(107, 38);
            ThemDV.TabIndex = 4;
            ThemDV.Text = "ThemDV";
            ThemDV.UseVisualStyleBackColor = true;
            ThemDV.Click += ThemDV_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 228);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(443, 288);
            dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 112);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 31);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(643, 228);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 31);
            textBox2.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(643, 327);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(284, 187);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 72);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 11;
            label1.Text = "Tìm kiếm";
            // 
            // QuanLyDanhMucDongVat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(SuaDV);
            Controls.Add(XoaDV);
            Controls.Add(ThemDV);
            Margin = new Padding(4, 5, 4, 5);
            Name = "QuanLyDanhMucDongVat";
            Text = "QuanLyDanhMucDongVat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SuaDV;
        private Button XoaDV;
        private Button ThemDV;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}