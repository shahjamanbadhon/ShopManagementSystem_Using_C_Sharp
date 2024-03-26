namespace ShopManagementSystem
{
    partial class MainForm
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
            panel2 = new Panel();
            customerButton2 = new CustomerButton();
            customerButton1 = new CustomerButton();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            customerButton3 = new CustomerButton();
            customerButton4 = new CustomerButton();
            customerButton5 = new CustomerButton();
            ((System.ComponentModel.ISupportInitialize)customerButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerButton1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerButton4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerButton5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 604);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 40);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 533);
            panel2.TabIndex = 2;
            // 
            // customerButton2
            // 
            customerButton2.ImageHover = null;
            customerButton2.ImageNormal = null;
            customerButton2.Location = new Point(364, 3);
            customerButton2.Name = "customerButton2";
            customerButton2.Size = new Size(78, 62);
            customerButton2.TabIndex = 2;
            customerButton2.TabStop = false;
            // 
            // customerButton1
            // 
            customerButton1.ImageHover = null;
            customerButton1.ImageNormal = null;
            customerButton1.Location = new Point(280, 3);
            customerButton1.Name = "customerButton1";
            customerButton1.Size = new Size(78, 62);
            customerButton1.TabIndex = 0;
            customerButton1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 23);
            label1.TabIndex = 1;
            label1.Text = "Shop Management System";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkBlue;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(customerButton1);
            flowLayoutPanel1.Controls.Add(customerButton2);
            flowLayoutPanel1.Controls.Add(customerButton3);
            flowLayoutPanel1.Controls.Add(customerButton4);
            flowLayoutPanel1.Controls.Add(customerButton5);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(978, 71);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // customerButton3
            // 
            customerButton3.ImageHover = null;
            customerButton3.ImageNormal = null;
            customerButton3.Location = new Point(448, 3);
            customerButton3.Name = "customerButton3";
            customerButton3.Size = new Size(78, 62);
            customerButton3.TabIndex = 3;
            customerButton3.TabStop = false;
            // 
            // customerButton4
            // 
            customerButton4.ImageHover = null;
            customerButton4.ImageNormal = null;
            customerButton4.Location = new Point(532, 3);
            customerButton4.Name = "customerButton4";
            customerButton4.Size = new Size(78, 62);
            customerButton4.TabIndex = 4;
            customerButton4.TabStop = false;
            // 
            // customerButton5
            // 
            customerButton5.ImageHover = null;
            customerButton5.ImageNormal = null;
            customerButton5.Location = new Point(616, 3);
            customerButton5.Name = "customerButton5";
            customerButton5.Size = new Size(78, 62);
            customerButton5.TabIndex = 4;
            customerButton5.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)customerButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerButton1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerButton4).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerButton5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private CustomerButton customerButton2;
        private CustomerButton customerButton1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomerButton customerButton3;
        private CustomerButton customerButton4;
        private CustomerButton customerButton5;
    }
}