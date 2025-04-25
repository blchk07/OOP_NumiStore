using OOP_NumiStore.Forms;
using OOP_NumiStore.Models;

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

            UsersManager usersManager = new UsersManager();
            usersManager.AddCustomer(new Customer() { Login = "2", Password = "2", Address = "2", Email = "2", Name = "2", Surname = "2" });
            User? currentUser = usersManager.Login(login, password, out string errorMessage);

            if (currentUser != null)
            {
                MessageBox.Show($"{currentUser.Login} - {currentUser.Password}", "!!!");
                MainAdminForm mainForm = new MainAdminForm(currentUser);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(errorMessage, "Помилка");
            }
        }
    }
}
