namespace OOP_NumiStore
{
    partial class OrderItemBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderIdText = new Label();
            label5 = new Label();
            datetimeLabel = new Label();
            label2 = new Label();
            orderStatusLabel = new Label();
            totalAmountLabel = new Label();
            label4 = new Label();
            detailsButton = new Button();
            changeStatusButton = new Button();
            SuspendLayout();
            // 
            // orderIdText
            // 
            orderIdText.AutoSize = true;
            orderIdText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderIdText.Location = new Point(15, 0);
            orderIdText.Name = "orderIdText";
            orderIdText.Size = new Size(35, 25);
            orderIdText.TabIndex = 31;
            orderIdText.Text = "№";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(15, 35);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 32;
            label5.Text = "Дата та час:";
            // 
            // datetimeLabel
            // 
            datetimeLabel.AutoSize = true;
            datetimeLabel.Location = new Point(90, 35);
            datetimeLabel.Name = "datetimeLabel";
            datetimeLabel.Size = new Size(30, 15);
            datetimeLabel.TabIndex = 35;
            datetimeLabel.Text = "дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 36;
            label2.Text = "Статус замовлення:";
            // 
            // orderStatusLabel
            // 
            orderStatusLabel.AutoSize = true;
            orderStatusLabel.Location = new Point(134, 74);
            orderStatusLabel.Name = "orderStatusLabel";
            orderStatusLabel.Size = new Size(41, 15);
            orderStatusLabel.TabIndex = 37;
            orderStatusLabel.Text = "статус";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new Point(109, 50);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(34, 15);
            totalAmountLabel.TabIndex = 39;
            totalAmountLabel.Text = "сума";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(15, 50);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 38;
            label4.Text = "Загальна сума:";
            // 
            // detailsButton
            // 
            detailsButton.Cursor = Cursors.Hand;
            detailsButton.Location = new Point(493, 18);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(81, 23);
            detailsButton.TabIndex = 40;
            detailsButton.Text = "Детальніше";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // changeStatusButton
            // 
            changeStatusButton.Cursor = Cursors.Hand;
            changeStatusButton.Location = new Point(493, 57);
            changeStatusButton.Name = "changeStatusButton";
            changeStatusButton.Size = new Size(81, 23);
            changeStatusButton.TabIndex = 41;
            changeStatusButton.Text = "button2";
            changeStatusButton.UseVisualStyleBackColor = true;
            changeStatusButton.Click += changeStatusButton_Click;
            // 
            // OrderItemBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(changeStatusButton);
            Controls.Add(detailsButton);
            Controls.Add(totalAmountLabel);
            Controls.Add(label4);
            Controls.Add(orderStatusLabel);
            Controls.Add(label2);
            Controls.Add(datetimeLabel);
            Controls.Add(label5);
            Controls.Add(orderIdText);
            Margin = new Padding(0, 10, 0, 0);
            Name = "OrderItemBox";
            Size = new Size(592, 99);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderIdText;
        private Label label5;
        private Label datetimeLabel;
        private Label label2;
        private Label orderStatusLabel;
        private Label totalAmountLabel;
        private Label label4;
        private Button detailsButton;
        private Button changeStatusButton;
    }
}
