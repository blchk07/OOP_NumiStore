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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseCoinBox));
            coinTitle = new Label();
            priceCoinText = new Label();
            coinEditButton = new Button();
            pictureCoin = new PictureBox();
            yearCoinText = new Label();
            countryCoinText = new Label();
            coinDeleteButton = new Button();
            adminPanelButtons = new Panel();
            customerPanelButtons = new Panel();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureCoin).BeginInit();
            adminPanelButtons.SuspendLayout();
            customerPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // coinTitle
            // 
            coinTitle.AutoSize = true;
            coinTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinTitle.Location = new Point(136, 11);
            coinTitle.Margin = new Padding(0);
            coinTitle.Name = "coinTitle";
            coinTitle.Size = new Size(56, 30);
            coinTitle.TabIndex = 0;
            coinTitle.Text = "Title";
            // 
            // priceCoinText
            // 
            priceCoinText.AutoSize = true;
            priceCoinText.Location = new Point(136, 87);
            priceCoinText.Name = "priceCoinText";
            priceCoinText.Size = new Size(35, 15);
            priceCoinText.TabIndex = 1;
            priceCoinText.Text = "Ціна:";
            // 
            // coinEditButton
            // 
            coinEditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinEditButton.BackColor = Color.WhiteSmoke;
            coinEditButton.Cursor = Cursors.Hand;
            coinEditButton.Location = new Point(32, 67);
            coinEditButton.Name = "coinEditButton";
            coinEditButton.Size = new Size(77, 25);
            coinEditButton.TabIndex = 2;
            coinEditButton.Text = "Редагувати";
            coinEditButton.UseVisualStyleBackColor = true;
            coinEditButton.Click += coinEditButton_Click;
            // 
            // pictureCoin
            // 
            pictureCoin.BackColor = Color.Gray;
            pictureCoin.Image = (Image)resources.GetObject("pictureCoin.Image");
            pictureCoin.Location = new Point(0, 0);
            pictureCoin.Name = "pictureCoin";
            pictureCoin.Size = new Size(118, 118);
            pictureCoin.TabIndex = 3;
            pictureCoin.TabStop = false;
            // 
            // yearCoinText
            // 
            yearCoinText.AutoSize = true;
            yearCoinText.Location = new Point(136, 45);
            yearCoinText.Name = "yearCoinText";
            yearCoinText.Size = new Size(26, 15);
            yearCoinText.TabIndex = 4;
            yearCoinText.Text = "Рік:";
            // 
            // countryCoinText
            // 
            countryCoinText.AutoSize = true;
            countryCoinText.Location = new Point(136, 66);
            countryCoinText.Name = "countryCoinText";
            countryCoinText.Size = new Size(46, 15);
            countryCoinText.TabIndex = 5;
            countryCoinText.Text = "Країна:";
            // 
            // coinDeleteButton
            // 
            coinDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinDeleteButton.Cursor = Cursors.Hand;
            coinDeleteButton.Location = new Point(32, 26);
            coinDeleteButton.Name = "coinDeleteButton";
            coinDeleteButton.Size = new Size(77, 25);
            coinDeleteButton.TabIndex = 6;
            coinDeleteButton.Text = "Видалити";
            coinDeleteButton.UseVisualStyleBackColor = true;
            // 
            // adminPanelButtons
            // 
            adminPanelButtons.Anchor = AnchorStyles.Right;
            adminPanelButtons.Controls.Add(coinEditButton);
            adminPanelButtons.Controls.Add(coinDeleteButton);
            adminPanelButtons.Location = new Point(550, 0);
            adminPanelButtons.Name = "adminPanelButtons";
            adminPanelButtons.Size = new Size(140, 118);
            adminPanelButtons.TabIndex = 7;
            // 
            // customerPanelButtons
            // 
            customerPanelButtons.Anchor = AnchorStyles.Right;
            customerPanelButtons.Controls.Add(button1);
            customerPanelButtons.Controls.Add(button2);
            customerPanelButtons.Location = new Point(547, 0);
            customerPanelButtons.Name = "customerPanelButtons";
            customerPanelButtons.Size = new Size(140, 118);
            customerPanelButtons.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.WhiteSmoke;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(32, 67);
            button1.Name = "button1";
            button1.Size = new Size(84, 25);
            button1.TabIndex = 7;
            button1.Text = "В кошик";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(32, 26);
            button2.Name = "button2";
            button2.Size = new Size(84, 25);
            button2.TabIndex = 8;
            button2.Text = "Детальніше";
            button2.UseVisualStyleBackColor = true;
            // 
            // BaseCoinBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            Controls.Add(countryCoinText);
            Controls.Add(yearCoinText);
            Controls.Add(pictureCoin);
            Controls.Add(priceCoinText);
            Controls.Add(coinTitle);
            Controls.Add(adminPanelButtons);
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
        private Label countryCoinText;
        private Button coinDeleteButton;
        private Button button1;
        private Button button2;
        public Panel customerPanelButtons;
        public Panel adminPanelButtons;
    }
}
