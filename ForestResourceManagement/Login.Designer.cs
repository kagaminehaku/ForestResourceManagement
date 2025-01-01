namespace ForestResourceManagement
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbusername = new TextBox();
            tbpassword = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.Location = new Point(148, 76);
            tbusername.Margin = new Padding(2, 2, 2, 2);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(255, 23);
            tbusername.TabIndex = 0;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(148, 137);
            tbpassword.Margin = new Padding(2, 2, 2, 2);
            tbpassword.Name = "tbpassword";
            tbpassword.PasswordChar = '●';
            tbpassword.Size = new Size(250, 23);
            tbpassword.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(320, 190);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(148, 190);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            Text = "ForestResouceManagerment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusername;
        private TextBox tbpassword;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
