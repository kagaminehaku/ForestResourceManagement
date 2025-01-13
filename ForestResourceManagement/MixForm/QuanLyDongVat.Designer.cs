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
            ThemDV.Location = new Point(827, 355);
            ThemDV.Margin = new Padding(4, 5, 4, 5);
            ThemDV.Name = "ThemDV";
            ThemDV.Size = new Size(107, 38);
            ThemDV.TabIndex = 0;
            ThemDV.Text = "ThemDV";
            ThemDV.UseVisualStyleBackColor = true;
            ThemDV.Click += ThemDV_Click;
            // 
            // XoaDV
            // 
            XoaDV.Location = new Point(827, 450);
            XoaDV.Margin = new Padding(4, 5, 4, 5);
            XoaDV.Name = "XoaDV";
            XoaDV.Size = new Size(107, 38);
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
            dataGridView1.Location = new Point(86, 235);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(550, 413);
            dataGridView1.TabIndex = 2;
            // 
            // SuaDV
            // 
            SuaDV.Location = new Point(827, 543);
            SuaDV.Margin = new Padding(4, 5, 4, 5);
            SuaDV.Name = "SuaDV";
            SuaDV.Size = new Size(107, 38);
            SuaDV.TabIndex = 3;
            SuaDV.Text = "SuaDV";
            SuaDV.UseVisualStyleBackColor = true;
            SuaDV.Click += SuaDV_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 145);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(548, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 5;
            label1.Text = "Tìm kiếm";
            // 
            // QuanLyDongVat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(SuaDV);
            Controls.Add(dataGridView1);
            Controls.Add(XoaDV);
            Controls.Add(ThemDV);
            Margin = new Padding(4, 5, 4, 5);
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