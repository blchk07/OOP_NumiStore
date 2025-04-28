namespace OOP_NumiStore.Forms
{
    partial class RegistrationForm
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
            customerRadioButton = new RadioButton();
            adminRadioButton = new RadioButton();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            surnameLabel = new Label();
            nameLabel = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            passwordLabel = new Label();
            label1 = new Label();
            loginLabel = new Label();
            headName = new Label();
            passwordTextBox = new TextBox();
            registrationButton = new Button();
            loginTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(customerRadioButton);
            panel1.Controls.Add(adminRadioButton);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(surnameLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(surnameTextBox);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(headName);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(registrationButton);
            panel1.Controls.Add(loginTextBox);
            panel1.Location = new Point(78, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 431);
            panel1.TabIndex = 7;
            // 
            // customerRadioButton
            // 
            customerRadioButton.AutoSize = true;
            customerRadioButton.Location = new Point(351, 308);
            customerRadioButton.Name = "customerRadioButton";
            customerRadioButton.Size = new Size(79, 19);
            customerRadioButton.TabIndex = 23;
            customerRadioButton.Text = "Покупець";
            customerRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            adminRadioButton.AutoSize = true;
            adminRadioButton.Checked = true;
            adminRadioButton.Location = new Point(216, 308);
            adminRadioButton.Name = "adminRadioButton";
            adminRadioButton.Size = new Size(104, 19);
            adminRadioButton.TabIndex = 22;
            adminRadioButton.TabStop = true;
            adminRadioButton.Text = "Адміністратор";
            adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(130, 271);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(110, 15);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Електронна пошта";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(248, 268);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(168, 23);
            emailTextBox.TabIndex = 19;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(179, 233);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(61, 15);
            surnameLabel.TabIndex = 18;
            surnameLabel.Text = "Прізвище";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(212, 195);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(28, 15);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Ім'я";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(248, 230);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(168, 23);
            surnameTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(248, 192);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(168, 23);
            nameTextBox.TabIndex = 15;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(191, 156);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(280, 399);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 6;
            label1.Text = "Авторизуватися";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(203, 118);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(37, 15);
            loginLabel.TabIndex = 13;
            loginLabel.Text = "Логін";
            // 
            // headName
            // 
            headName.Anchor = AnchorStyles.Top;
            headName.AutoSize = true;
            headName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headName.Location = new Point(128, 24);
            headName.Name = "headName";
            headName.Size = new Size(391, 76);
            headName.TabIndex = 0;
            headName.Text = "NumiStore";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(248, 153);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.Size = new Size(168, 23);
            passwordTextBox.TabIndex = 12;
            // 
            // registrationButton
            // 
            registrationButton.Anchor = AnchorStyles.Top;
            registrationButton.Cursor = Cursors.Hand;
            registrationButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registrationButton.Location = new Point(248, 345);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(168, 42);
            registrationButton.TabIndex = 5;
            registrationButton.Text = "Зареєструватися";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(248, 115);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(168, 23);
            loginTextBox.TabIndex = 11;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 515);
            Controls.Add(panel1);
            Name = "RegistrationForm";
            Text = "Зареєструвати акаунт";
            FormClosed += RegistrationForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label headName;
        private Button registrationButton;
        private Label passwordLabel;
        private Label loginLabel;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label surnameLabel;
        private Label nameLabel;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private RadioButton customerRadioButton;
        private RadioButton adminRadioButton;
    }
}