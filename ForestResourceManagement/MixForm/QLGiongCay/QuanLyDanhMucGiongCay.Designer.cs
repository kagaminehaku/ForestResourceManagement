﻿namespace ForestResourceManagement.MixForm.QLGiongCay
{
    partial class QuanLyDanhMucGiongCay
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
            label1.Location = new Point(60, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 19;
            label1.Text = "Tìm kiếm";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(416, 218);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 114);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(416, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(310, 173);
            dataGridView1.TabIndex = 15;
            // 
            // SuaDV
            // 
            SuaDV.Location = new Point(650, 291);
            SuaDV.Name = "SuaDV";
            SuaDV.Size = new Size(104, 23);
            SuaDV.TabIndex = 14;
            SuaDV.Text = "SuaDanhMuc";
            SuaDV.UseVisualStyleBackColor = true;
            // 
            // XoaDV
            // 
            XoaDV.Location = new Point(650, 235);
            XoaDV.Name = "XoaDV";
            XoaDV.Size = new Size(104, 23);
            XoaDV.TabIndex = 13;
            XoaDV.Text = "XoaDanhMuc";
            XoaDV.UseVisualStyleBackColor = true;
            // 
            // ThemDV
            // 
            ThemDV.Location = new Point(650, 180);
            ThemDV.Name = "ThemDV";
            ThemDV.Size = new Size(104, 23);
            ThemDV.TabIndex = 12;
            ThemDV.Text = "ThemDanhMuc";
            ThemDV.UseVisualStyleBackColor = true;
            // 
            // QuanLyDanhMucGiongCay
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
            Name = "QuanLyDanhMucGiongCay";
            Text = "QuanLyDanhMucGiongCay";
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