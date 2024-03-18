namespace ShopManagementSystem
{
    partial class Form1
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
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            userName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passWord = new TextBox();
            login = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            showPassword = new CheckBox();
            clear = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 60);
            panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Location = new Point(298, 5);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(19, 21);
            pictureBoxClose.TabIndex = 8;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(60, 19);
            label3.Name = "label3";
            label3.Size = new Size(239, 25);
            label3.TabIndex = 7;
            label3.Text = "Shop Management System";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(7, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // userName
            // 
            userName.Location = new Point(46, 258);
            userName.Name = "userName";
            userName.Size = new Size(237, 31);
            userName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 219);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 2;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 304);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // passWord
            // 
            passWord.Location = new Point(46, 343);
            passWord.Name = "passWord";
            passWord.Size = new Size(237, 31);
            passWord.TabIndex = 3;
            passWord.UseSystemPasswordChar = true;
            // 
            // login
            // 
            login.BackColor = Color.Red;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI Black", 9F);
            login.ForeColor = SystemColors.ButtonFace;
            login.Location = new Point(46, 400);
            login.Name = "login";
            login.Size = new Size(237, 34);
            login.TabIndex = 5;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(117, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 75);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(64, 181);
            label4.Name = "label4";
            label4.Size = new Size(200, 25);
            label4.TabIndex = 7;
            label4.Text = "PLEASE LOGIN FIRSTT";
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI", 7F);
            showPassword.Location = new Point(153, 450);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(130, 23);
            showPassword.TabIndex = 8;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // clear
            // 
            clear.AutoSize = true;
            clear.Font = new Font("Segoe UI", 7F);
            clear.Location = new Point(46, 454);
            clear.Name = "clear";
            clear.Size = new Size(40, 19);
            clear.TabIndex = 9;
            clear.Text = "Clear";
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 550);
            Controls.Add(clear);
            Controls.Add(showPassword);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(login);
            Controls.Add(label2);
            Controls.Add(passWord);
            Controls.Add(label1);
            Controls.Add(userName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox userName;
        private Label label1;
        private Label label2;
        private TextBox passWord;
        private Button login;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private CheckBox showPassword;
        private Label clear;
        private PictureBox pictureBoxClose;
    }
}
