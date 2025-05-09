namespace OOP_NumiStore.Forms
{
    partial class EditAccountForm
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
            mainPanel = new Panel();
            saveChangesButton = new Button();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            surnameLabel = new Label();
            nameLabel = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            passwordLabel = new Label();
            loginLabel = new Label();
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(saveChangesButton);
            mainPanel.Controls.Add(emailLabel);
            mainPanel.Controls.Add(emailTextBox);
            mainPanel.Controls.Add(surnameLabel);
            mainPanel.Controls.Add(nameLabel);
            mainPanel.Controls.Add(surnameTextBox);
            mainPanel.Controls.Add(nameTextBox);
            mainPanel.Controls.Add(passwordLabel);
            mainPanel.Controls.Add(loginLabel);
            mainPanel.Controls.Add(passwordTextBox);
            mainPanel.Controls.Add(loginTextBox);
            mainPanel.Location = new Point(104, 62);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(539, 334);
            mainPanel.TabIndex = 0;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Cursor = Cursors.Hand;
            saveChangesButton.Location = new Point(202, 253);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(134, 37);
            saveChangesButton.TabIndex = 32;
            saveChangesButton.Text = "Зберегти";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(126, 201);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(110, 15);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "Електронна пошта";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(244, 198);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(168, 23);
            emailTextBox.TabIndex = 30;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(175, 163);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(61, 15);
            surnameLabel.TabIndex = 29;
            surnameLabel.Text = "Прізвище";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(208, 125);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(28, 15);
            nameLabel.TabIndex = 28;
            nameLabel.Text = "Ім'я";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(244, 160);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(168, 23);
            surnameTextBox.TabIndex = 27;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(244, 122);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(168, 23);
            nameTextBox.TabIndex = 26;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(187, 86);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 25;
            passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(199, 48);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(37, 15);
            loginLabel.TabIndex = 24;
            loginLabel.Text = "Логін";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(244, 83);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(168, 23);
            passwordTextBox.TabIndex = 23;
            // 
            // loginTextBox
            // 
            loginTextBox.Cursor = Cursors.No;
            loginTextBox.Location = new Point(244, 45);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.ReadOnly = true;
            loginTextBox.Size = new Size(168, 23);
            loginTextBox.TabIndex = 22;
            // 
            // EditAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 474);
            Controls.Add(mainPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAccountForm";
            Text = "Редагування акаунту";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label surnameLabel;
        private Label nameLabel;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Label passwordLabel;
        private Label loginLabel;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Button saveChangesButton;
    }
}