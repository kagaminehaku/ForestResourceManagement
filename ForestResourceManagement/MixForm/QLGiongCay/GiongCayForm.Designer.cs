﻿namespace ForestResourceManagement.MixForm.QLGiongCay
{
    partial class GiongCayForm
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
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(446, 351);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Huỷ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(280, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 77);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "Danh Mục";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(282, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 197);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 15;
            label2.Text = "Thông Tin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 136);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 14;
            label1.Text = "Tên Giống Cây";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(281, 223);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(240, 96);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 12;
            // 
            // GiongCayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Name = "GiongCayForm";
            Text = "GiongCay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }
}