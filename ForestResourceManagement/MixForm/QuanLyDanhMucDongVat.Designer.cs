﻿namespace ForestResourceManagement.MixForm
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SuaDV
            // 
            SuaDV.Location = new Point(684, 269);
            SuaDV.Name = "SuaDV";
            SuaDV.Size = new Size(75, 23);
            SuaDV.TabIndex = 6;
            SuaDV.Text = "SuaDV";
            SuaDV.UseVisualStyleBackColor = true;
            // 
            // XoaDV
            // 
            XoaDV.Location = new Point(684, 213);
            XoaDV.Name = "XoaDV";
            XoaDV.Size = new Size(75, 23);
            XoaDV.TabIndex = 5;
            XoaDV.Text = "XoaDV";
            XoaDV.UseVisualStyleBackColor = true;
            // 
            // ThemDV
            // 
            ThemDV.Location = new Point(684, 158);
            ThemDV.Name = "ThemDV";
            ThemDV.Size = new Size(75, 23);
            ThemDV.TabIndex = 4;
            ThemDV.Text = "ThemDV";
            ThemDV.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(94, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(310, 173);
            dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(450, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(450, 196);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 114);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // QuanLyDanhMucDongVat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(SuaDV);
            Controls.Add(XoaDV);
            Controls.Add(ThemDV);
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
    }
}