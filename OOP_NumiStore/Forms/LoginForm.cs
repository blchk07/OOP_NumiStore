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
                MessageBox.Show("���� ����� �� ������ ����� ���� ���������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User? currentUser = usersManager.Login(login, password, out string errorMessage);

            if (currentUser != null)
            {
                UserSession.Login(currentUser);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(errorMessage, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
