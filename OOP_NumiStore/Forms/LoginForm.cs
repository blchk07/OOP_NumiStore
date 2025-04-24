using OOP_NumiStore.Forms;

namespace OOP_NumiStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (login == "1" && password == "1")
            //if (true)
            {
                // Open the main form or perform any other action
                MainAdminForm mainForm = new MainAdminForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login or password.", "Warning");
            }
        }
    }
}
