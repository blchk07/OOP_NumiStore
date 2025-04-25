namespace OOP_NumiStore
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headName = new Label();
            loginLabel = new Label();
            passwordLabel = new Label();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // headName
            // 
            headName.Anchor = AnchorStyles.Top;
            headName.AutoSize = true;
            headName.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headName.Location = new Point(90, 25);
            headName.Name = "headName";
            headName.Size = new Size(391, 76);
            headName.TabIndex = 0;
            headName.Text = "NumiStore";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(147, 134);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(64, 30);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логін";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(147, 197);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(85, 30);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(241, 141);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(182, 23);
            loginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(241, 204);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(182, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.Location = new Point(216, 264);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(139, 42);
            loginButton.TabIndex = 5;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(headName);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(loginTextBox);
            panel1.Controls.Add(passwordTextBox);
            panel1.Location = new Point(116, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 331);
            panel1.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 515);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Вхід у застосунок";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label headName;
        private Label loginLabel;
        private Label passwordLabel;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Panel panel1;
    }
}
