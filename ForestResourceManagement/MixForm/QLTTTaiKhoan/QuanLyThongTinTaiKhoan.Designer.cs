namespace ForestResourceManagement.MixForm
{
    partial class QuanLyThongTinTaiKhoan
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
            usernametb = new TextBox();
            phnbtb = new TextBox();
            emailtb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            thongtintb = new RichTextBox();
            SuspendLayout();
            // 
            // usernametb
            // 
            usernametb.Enabled = false;
            usernametb.Location = new Point(133, 83);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(523, 31);
            usernametb.TabIndex = 0;
            // 
            // phnbtb
            // 
            phnbtb.Location = new Point(133, 168);
            phnbtb.Name = "phnbtb";
            phnbtb.Size = new Size(523, 31);
            phnbtb.TabIndex = 1;
            // 
            // emailtb
            // 
            emailtb.Location = new Point(133, 248);
            emailtb.Name = "emailtb";
            emailtb.Size = new Size(523, 31);
            emailtb.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(135, 587);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(546, 587);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Huỷ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 55);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 6;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 140);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 7;
            label2.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 220);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 327);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 9;
            label4.Text = "Thông tin";
            // 
            // thongtintb
            // 
            thongtintb.Location = new Point(133, 355);
            thongtintb.Name = "thongtintb";
            thongtintb.Size = new Size(523, 144);
            thongtintb.TabIndex = 11;
            thongtintb.Text = "";
            // 
            // QuanLyThongTinTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 694);
            Controls.Add(thongtintb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(emailtb);
            Controls.Add(phnbtb);
            Controls.Add(usernametb);
            Name = "QuanLyThongTinTaiKhoan";
            Text = "QuanLyThongTinTaiKhoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametb;
        private TextBox phnbtb;
        private TextBox emailtb;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox thongtintb;
    }
}