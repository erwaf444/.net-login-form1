namespace loginApp
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            panel3 = new Panel();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            panel4 = new Panel();
            textBox_RG_Fullname = new TextBox();
            label_RG_Fullname = new Label();
            panel5 = new Panel();
            textBox_RG_Username = new TextBox();
            label_RG_Username = new Label();
            panel6 = new Panel();
            textBox_RG_Confirm = new TextBox();
            label_RG_Confirm = new Label();
            textBox_RG_Password = new TextBox();
            label_RG_Password = new Label();
            panel7 = new Panel();
            textBox_RG_Email = new TextBox();
            label_RG_Email = new Label();
            buttonLogin = new Button();
            buttonRegister = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(67, 26);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(426, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // panel1
            // 
            panel1.Location = new Point(405, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 435);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(textBoxUsername);
            panel2.Controls.Add(labelUsername);
            panel2.Location = new Point(31, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 57);
            panel2.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(145, 18);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(184, 23);
            textBoxUsername.TabIndex = 7;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(14, 15);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(114, 26);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "Username";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(textBoxPassword);
            panel3.Controls.Add(labelPassword);
            panel3.Location = new Point(31, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 57);
            panel3.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(145, 18);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(184, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(14, 15);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(107, 26);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            labelPassword.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(textBox_RG_Fullname);
            panel4.Controls.Add(label_RG_Fullname);
            panel4.Location = new Point(436, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 57);
            panel4.TabIndex = 10;
            // 
            // textBox_RG_Fullname
            // 
            textBox_RG_Fullname.Location = new Point(145, 18);
            textBox_RG_Fullname.Name = "textBox_RG_Fullname";
            textBox_RG_Fullname.Size = new Size(184, 23);
            textBox_RG_Fullname.TabIndex = 7;
            // 
            // label_RG_Fullname
            // 
            label_RG_Fullname.AutoSize = true;
            label_RG_Fullname.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_RG_Fullname.Location = new Point(14, 15);
            label_RG_Fullname.Name = "label_RG_Fullname";
            label_RG_Fullname.Size = new Size(102, 26);
            label_RG_Fullname.TabIndex = 6;
            label_RG_Fullname.Text = "Fullname";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(textBox_RG_Username);
            panel5.Controls.Add(label_RG_Username);
            panel5.Location = new Point(436, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(352, 57);
            panel5.TabIndex = 9;
            // 
            // textBox_RG_Username
            // 
            textBox_RG_Username.Location = new Point(145, 18);
            textBox_RG_Username.Name = "textBox_RG_Username";
            textBox_RG_Username.Size = new Size(184, 23);
            textBox_RG_Username.TabIndex = 7;
            // 
            // label_RG_Username
            // 
            label_RG_Username.AutoSize = true;
            label_RG_Username.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_RG_Username.Location = new Point(14, 15);
            label_RG_Username.Name = "label_RG_Username";
            label_RG_Username.Size = new Size(114, 26);
            label_RG_Username.TabIndex = 6;
            label_RG_Username.Text = "Username";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(textBox_RG_Confirm);
            panel6.Controls.Add(label_RG_Confirm);
            panel6.Controls.Add(textBox_RG_Password);
            panel6.Controls.Add(label_RG_Password);
            panel6.Location = new Point(436, 304);
            panel6.Name = "panel6";
            panel6.Size = new Size(352, 86);
            panel6.TabIndex = 12;
            // 
            // textBox_RG_Confirm
            // 
            textBox_RG_Confirm.Location = new Point(145, 36);
            textBox_RG_Confirm.Name = "textBox_RG_Confirm";
            textBox_RG_Confirm.Size = new Size(184, 23);
            textBox_RG_Confirm.TabIndex = 9;
            textBox_RG_Confirm.UseSystemPasswordChar = true;
            // 
            // label_RG_Confirm
            // 
            label_RG_Confirm.AutoSize = true;
            label_RG_Confirm.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_RG_Confirm.Location = new Point(14, 36);
            label_RG_Confirm.Name = "label_RG_Confirm";
            label_RG_Confirm.Size = new Size(91, 26);
            label_RG_Confirm.TabIndex = 8;
            label_RG_Confirm.Text = "Confirm";
            // 
            // textBox_RG_Password
            // 
            textBox_RG_Password.Location = new Point(145, 10);
            textBox_RG_Password.Name = "textBox_RG_Password";
            textBox_RG_Password.Size = new Size(184, 23);
            textBox_RG_Password.TabIndex = 7;
            // 
            // label_RG_Password
            // 
            label_RG_Password.AutoSize = true;
            label_RG_Password.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_RG_Password.Location = new Point(14, 10);
            label_RG_Password.Name = "label_RG_Password";
            label_RG_Password.Size = new Size(107, 26);
            label_RG_Password.TabIndex = 6;
            label_RG_Password.Text = "Password";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(textBox_RG_Email);
            panel7.Controls.Add(label_RG_Email);
            panel7.Location = new Point(436, 241);
            panel7.Name = "panel7";
            panel7.Size = new Size(352, 57);
            panel7.TabIndex = 11;
            // 
            // textBox_RG_Email
            // 
            textBox_RG_Email.Location = new Point(145, 18);
            textBox_RG_Email.Name = "textBox_RG_Email";
            textBox_RG_Email.Size = new Size(184, 23);
            textBox_RG_Email.TabIndex = 7;
            // 
            // label_RG_Email
            // 
            label_RG_Email.AutoSize = true;
            label_RG_Email.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_RG_Email.Location = new Point(14, 15);
            label_RG_Email.Name = "label_RG_Email";
            label_RG_Email.Size = new Size(64, 26);
            label_RG_Email.TabIndex = 6;
            label_RG_Email.Text = "Email";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(31, 242);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 40);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(436, 398);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 40);
            buttonRegister.TabIndex = 13;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "Login_Form";
            Load += login_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Panel panel3;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Panel panel4;
        private TextBox textBox_RG_Fullname;
        private Label label_RG_Fullname;
        private Panel panel5;
        private TextBox textBox_RG_Username;
        private Label label_RG_Username;
        private Panel panel6;
        private TextBox textBox_RG_Password;
        private Label label_RG_Password;
        private Panel panel7;
        private TextBox textBox_RG_Email;
        private Label label_RG_Email;
        private Button buttonLogin;
        private Button buttonRegister;
        private TextBox textBox_RG_Confirm;
        private Label label_RG_Confirm;
    }
}