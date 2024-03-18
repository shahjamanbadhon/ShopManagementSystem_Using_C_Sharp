namespace ShopManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == false)
            {
                passWord.UseSystemPasswordChar = true;
            }
            else passWord.UseSystemPasswordChar = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            userName.Clear();
            passWord.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
