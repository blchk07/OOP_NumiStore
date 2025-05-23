namespace OOP_NumiStore
{
    partial class BaseCoinBox
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
            coinTitle = new Label();
            priceCoinText = new Label();
            coinEditButton = new Button();
            pictureCoin = new PictureBox();
            yearCoinText = new Label();
            typeCoinText = new Label();
            coinDeleteButton = new Button();
            adminPanelButtons = new Panel();
            customerPanelButtons = new Panel();
            coinBasketButton = new Button();
            coinDetailsButton = new Button();
            availableCountText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureCoin).BeginInit();
            adminPanelButtons.SuspendLayout();
            customerPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // coinTitle
            // 
            coinTitle.AutoSize = true;
            coinTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinTitle.Location = new Point(136, 6);
            coinTitle.Margin = new Padding(0);
            coinTitle.Name = "coinTitle";
            coinTitle.Size = new Size(56, 30);
            coinTitle.TabIndex = 0;
            coinTitle.Text = "Title";
            // 
            // priceCoinText
            // 
            priceCoinText.AutoSize = true;
            priceCoinText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priceCoinText.Location = new Point(136, 98);
            priceCoinText.Name = "priceCoinText";
            priceCoinText.Size = new Size(36, 15);
            priceCoinText.TabIndex = 1;
            priceCoinText.Text = "Ціна:";
            // 
            // coinEditButton
            // 
            coinEditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinEditButton.BackColor = Color.WhiteSmoke;
            coinEditButton.Cursor = Cursors.Hand;
            coinEditButton.Location = new Point(31, 67);
            coinEditButton.Name = "coinEditButton";
            coinEditButton.Size = new Size(77, 25);
            coinEditButton.TabIndex = 2;
            coinEditButton.Text = "Редагувати";
            coinEditButton.UseVisualStyleBackColor = true;
            coinEditButton.Click += coinEditButton_Click;
            // 
            // pictureCoin
            // 
            pictureCoin.BackColor = Color.WhiteSmoke;
            pictureCoin.Location = new Point(0, 0);
            pictureCoin.Name = "pictureCoin";
            pictureCoin.Size = new Size(118, 118);
            pictureCoin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCoin.TabIndex = 3;
            pictureCoin.TabStop = false;
            // 
            // yearCoinText
            // 
            yearCoinText.AutoSize = true;
            yearCoinText.Location = new Point(136, 57);
            yearCoinText.Name = "yearCoinText";
            yearCoinText.Size = new Size(26, 15);
            yearCoinText.TabIndex = 4;
            yearCoinText.Text = "Рік:";
            // 
            // typeCoinText
            // 
            typeCoinText.AutoSize = true;
            typeCoinText.Location = new Point(136, 36);
            typeCoinText.Name = "typeCoinText";
            typeCoinText.Size = new Size(30, 15);
            typeCoinText.TabIndex = 5;
            typeCoinText.Text = "Тип:";
            // 
            // coinDeleteButton
            // 
            coinDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinDeleteButton.Cursor = Cursors.Hand;
            coinDeleteButton.Location = new Point(31, 26);
            coinDeleteButton.Name = "coinDeleteButton";
            coinDeleteButton.Size = new Size(77, 25);
            coinDeleteButton.TabIndex = 6;
            coinDeleteButton.Text = "Видалити";
            coinDeleteButton.UseVisualStyleBackColor = true;
            coinDeleteButton.Click += coinDeleteButton_Click;
            // 
            // adminPanelButtons
            // 
            adminPanelButtons.Anchor = AnchorStyles.Right;
            adminPanelButtons.Controls.Add(coinEditButton);
            adminPanelButtons.Controls.Add(coinDeleteButton);
            adminPanelButtons.Location = new Point(545, 0);
            adminPanelButtons.Name = "adminPanelButtons";
            adminPanelButtons.Size = new Size(139, 118);
            adminPanelButtons.TabIndex = 7;
            // 
            // customerPanelButtons
            // 
            customerPanelButtons.Anchor = AnchorStyles.Right;
            customerPanelButtons.Controls.Add(coinBasketButton);
            customerPanelButtons.Controls.Add(coinDetailsButton);
            customerPanelButtons.Location = new Point(574, 0);
            customerPanelButtons.Name = "customerPanelButtons";
            customerPanelButtons.Size = new Size(113, 118);
            customerPanelButtons.TabIndex = 8;
            // 
            // coinBasketButton
            // 
            coinBasketButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinBasketButton.BackColor = Color.WhiteSmoke;
            coinBasketButton.Cursor = Cursors.Hand;
            coinBasketButton.Location = new Point(5, 67);
            coinBasketButton.Name = "coinBasketButton";
            coinBasketButton.Size = new Size(84, 25);
            coinBasketButton.TabIndex = 7;
            coinBasketButton.Text = "В кошик";
            coinBasketButton.UseVisualStyleBackColor = true;
            coinBasketButton.Click += coinBasketButton_Click;
            // 
            // coinDetailsButton
            // 
            coinDetailsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinDetailsButton.Cursor = Cursors.Hand;
            coinDetailsButton.Location = new Point(5, 26);
            coinDetailsButton.Name = "coinDetailsButton";
            coinDetailsButton.Size = new Size(84, 25);
            coinDetailsButton.TabIndex = 8;
            coinDetailsButton.Text = "Детальніше";
            coinDetailsButton.UseVisualStyleBackColor = true;
            coinDetailsButton.Click += coinDetailsButton_Click;
            // 
            // availableCountText
            // 
            availableCountText.AutoSize = true;
            availableCountText.Location = new Point(136, 77);
            availableCountText.Name = "availableCountText";
            availableCountText.Size = new Size(59, 15);
            availableCountText.TabIndex = 9;
            availableCountText.Text = "Кількість:";
            // 
            // BaseCoinBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            Controls.Add(adminPanelButtons);
            Controls.Add(availableCountText);
            Controls.Add(typeCoinText);
            Controls.Add(yearCoinText);
            Controls.Add(pictureCoin);
            Controls.Add(priceCoinText);
            Controls.Add(coinTitle);
            Controls.Add(customerPanelButtons);
            Margin = new Padding(0, 8, 0, 0);
            Name = "BaseCoinBox";
            Size = new Size(690, 118);
            ((System.ComponentModel.ISupportInitialize)pictureCoin).EndInit();
            adminPanelButtons.ResumeLayout(false);
            customerPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label coinTitle;
        private Label priceCoinText;
        private Button coinEditButton;
        private PictureBox pictureCoin;
        private Label yearCoinText;
        private Label typeCoinText;
        private Button coinDeleteButton;
        private Button coinBasketButton;
        private Button coinDetailsButton;
        public Panel customerPanelButtons;
        public Panel adminPanelButtons;
        private Label availableCountText;
    }
}
