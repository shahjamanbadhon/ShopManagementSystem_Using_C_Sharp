namespace ShopManagementSystem
{
    partial class UserModuleForm
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textUser = new TextBox();
            textPass = new TextBox();
            label3 = new Label();
            textFullName = new TextBox();
            label4 = new Label();
            textPhone = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 29);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 106);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            // 
            // textUser
            // 
            textUser.Location = new Point(174, 103);
            textUser.Name = "textUser";
            textUser.Size = new Size(338, 30);
            textUser.TabIndex = 2;
            // 
            // textPass
            // 
            textPass.Location = new Point(174, 195);
            textPass.Name = "textPass";
            textPass.Size = new Size(338, 30);
            textPass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 198);
            label3.Name = "label3";
            label3.Size = new Size(97, 22);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textFullName
            // 
            textFullName.Location = new Point(174, 149);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(338, 30);
            textFullName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 152);
            label4.Name = "label4";
            label4.Size = new Size(102, 22);
            label4.TabIndex = 5;
            label4.Text = "Full Name:";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(174, 245);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(338, 30);
            textPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 248);
            label5.Name = "label5";
            label5.Size = new Size(71, 22);
            label5.TabIndex = 7;
            label5.Text = "Phone:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(164, 302);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(282, 302);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(400, 302);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 11;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // UserModuleForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 377);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textPhone);
            Controls.Add(label5);
            Controls.Add(textFullName);
            Controls.Add(label4);
            Controls.Add(textPass);
            Controls.Add(label3);
            Controls.Add(textUser);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserModuleForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textUser;
        private TextBox textPass;
        private Label label3;
        private TextBox textFullName;
        private Label label4;
        private TextBox textPhone;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}