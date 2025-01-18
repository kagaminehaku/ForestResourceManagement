namespace ForestResourceManagement.MixForm.QLCoSoLuuTruDV
{
    partial class QLDanhMucCoSoLuuTruDV
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
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            SuaDV = new Button();
            XoaDV = new Button();
            ThemDV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 27;
            label1.Text = "Tìm kiếm";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(421, 222);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 114);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(421, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(310, 173);
            dataGridView1.TabIndex = 23;
            // 
            // SuaDV
            // 
            SuaDV.Location = new Point(655, 295);
            SuaDV.Name = "SuaDV";
            SuaDV.Size = new Size(104, 23);
            SuaDV.TabIndex = 22;
            SuaDV.Text = "SuaDanhMuc";
            SuaDV.UseVisualStyleBackColor = true;
            SuaDV.Click += SuaDV_Click;
            // 
            // XoaDV
            // 
            XoaDV.Location = new Point(655, 239);
            XoaDV.Name = "XoaDV";
            XoaDV.Size = new Size(104, 23);
            XoaDV.TabIndex = 21;
            XoaDV.Text = "XoaDanhMuc";
            XoaDV.UseVisualStyleBackColor = true;
            XoaDV.Click += XoaDV_Click;
            // 
            // ThemDV
            // 
            ThemDV.Location = new Point(655, 184);
            ThemDV.Name = "ThemDV";
            ThemDV.Size = new Size(104, 23);
            ThemDV.TabIndex = 20;
            ThemDV.Text = "ThemDanhMuc";
            ThemDV.UseVisualStyleBackColor = true;
            ThemDV.Click += ThemDV_Click;
            // 
            // QLDanhMucCoSoLuuTruDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(SuaDV);
            Controls.Add(XoaDV);
            Controls.Add(ThemDV);
            Name = "QLDanhMucCoSoLuuTruDV";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button SuaDV;
        private Button XoaDV;
        private Button ThemDV;
    }
}