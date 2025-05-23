namespace OOP_NumiStore.Forms
{
    partial class BasketForm
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
            basketItemsPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            clearAllButton = new Button();
            createOrderButton = new Button();
            totalAmountLabel = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // basketItemsPanel
            // 
            basketItemsPanel.AutoScroll = true;
            basketItemsPanel.BackColor = SystemColors.ControlLight;
            basketItemsPanel.Location = new Point(0, 43);
            basketItemsPanel.Name = "basketItemsPanel";
            basketItemsPanel.Size = new Size(543, 348);
            basketItemsPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(clearAllButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 43);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 3;
            label1.Text = "Кошик";
            // 
            // clearAllButton
            // 
            clearAllButton.Cursor = Cursors.Hand;
            clearAllButton.Location = new Point(433, 12);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(97, 23);
            clearAllButton.TabIndex = 2;
            clearAllButton.Text = "Очистити все";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // createOrderButton
            // 
            createOrderButton.Cursor = Cursors.Hand;
            createOrderButton.Location = new Point(191, 13);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(151, 33);
            createOrderButton.TabIndex = 3;
            createOrderButton.Text = "Створити замовлення";
            createOrderButton.UseVisualStyleBackColor = true;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalAmountLabel.Location = new Point(408, 19);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(56, 21);
            totalAmountLabel.TabIndex = 4;
            totalAmountLabel.Text = "Сума: ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(createOrderButton);
            panel2.Controls.Add(totalAmountLabel);
            panel2.Location = new Point(0, 391);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 59);
            panel2.TabIndex = 5;
            // 
            // BasketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(542, 448);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(basketItemsPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BasketForm";
            Text = "Кошик";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel basketItemsPanel;
        private Panel panel1;
        private Button clearAllButton;
        private Label label1;
        private Button createOrderButton;
        private Label totalAmountLabel;
        private Panel panel2;
    }
}