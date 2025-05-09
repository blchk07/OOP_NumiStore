using OOP_NumiStore.Forms;
using OOP_NumiStore.Models;

namespace OOP_NumiStore
{
    public partial class LoginForm : Form
    {
        UsersManager usersManager;
        public LoginForm()
        {
            InitializeComponent();
            usersManager = new UsersManager();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (login == "" || password == "")
            {
                MessageBox.Show("Поля логіну та паролю мають бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User? currentUser = usersManager.Login(login, password, out string errorMessage);

            if (currentUser != null)
            {
                if (currentUser is Admin)
                {
                    UserSession.Login(currentUser);
                    MainAdminForm mainAdminForm = new MainAdminForm();
                    mainAdminForm.Show();
                    this.Hide();
                }
                else
                {
                    UserSession.Login(currentUser);
                    MainCustomerForm mainCustomerForm = new MainCustomerForm();
                    mainCustomerForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrationLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}
