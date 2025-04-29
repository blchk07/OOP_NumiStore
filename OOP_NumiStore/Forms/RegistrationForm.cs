using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OOP_NumiStore.Models;

namespace OOP_NumiStore.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();

            if (login == "" || password == "" || email == "" || name == "" || surname == "")
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsersManager usersManager = new UsersManager();

            if (adminRadioButton.Checked)
            {
                Admin? createdAdmin = usersManager.RegisterAdmin(login, password, email, name, surname, out string errorMessage);
                if (createdAdmin != null)
                {
                    MessageBox.Show("Адміністратор успішно зареєстрований!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (customerRadioButton.Checked)
            {
                Customer? createdCustomer = usersManager.RegisterCustomer(login, password, email, name, surname, out string errorMessage);
                if (createdCustomer != null)
                {
                    MessageBox.Show("Покупець успішно зареєстрований!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginTextLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
