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
    public partial class EditAccountForm : Form
    {
        public bool isEdited { get; private set; } = false;
        public User currentUser { get; private set; }
        public EditAccountForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            InitializeTextBoxes();
        }

        private void InitializeTextBoxes()
        {
            loginTextBox.Text = currentUser.Login;
            passwordTextBox.Text = currentUser.Password;
            nameTextBox.Text = currentUser.Name;
            surnameTextBox.Text = currentUser.Surname;
            emailTextBox.Text = currentUser.Email;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            UsersManager usersManager = new UsersManager();
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text.Trim()))
            {
                MessageBox.Show("Пароль не може бути порожнім!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(nameTextBox.Text.Trim()))
            {
                MessageBox.Show("Ім'я не може бути порожнім!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(surnameTextBox.Text.Trim()))
            {
                MessageBox.Show("Прізвище не може бути порожнім!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(emailTextBox.Text.Trim()))
            {
                MessageBox.Show("Email не може бути порожнім!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = passwordTextBox.Text.Trim();
            string newEmail = emailTextBox.Text.Trim();
            string newName = nameTextBox.Text.Trim();
            string newSurname = surnameTextBox.Text.Trim();

            if (newPassword == currentUser.Password && newEmail == currentUser.Email && newName == currentUser.Name && newSurname == currentUser.Surname)
            {
                MessageBox.Show("Ви не внесли жодних змін!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isSuccessEdit = usersManager.EditUser(
                user: currentUser,
                newPassword: newPassword,
                newEmail: newEmail,
                newName: newName,
                newSurname: newSurname
            );

            if (isSuccessEdit)
            {
                MessageBox.Show("Дані успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserSession.Login(currentUser);
                isEdited = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не вдалося зберегти зміни. Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
