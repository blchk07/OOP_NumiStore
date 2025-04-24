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
            priceCoin = new Label();
            coinDetailButton = new Button();
            pictureCoin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureCoin).BeginInit();
            SuspendLayout();
            // 
            // coinTitle
            // 
            coinTitle.AutoSize = true;
            coinTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinTitle.Location = new Point(164, 24);
            coinTitle.Name = "coinTitle";
            coinTitle.Size = new Size(50, 25);
            coinTitle.TabIndex = 0;
            coinTitle.Text = "Title";
            // 
            // priceCoin
            // 
            priceCoin.AutoSize = true;
            priceCoin.Location = new Point(164, 65);
            priceCoin.Name = "priceCoin";
            priceCoin.Size = new Size(35, 15);
            priceCoin.TabIndex = 1;
            priceCoin.Text = "Ціна:";
            // 
            // coinDetailButton
            // 
            coinDetailButton.Location = new Point(164, 92);
            coinDetailButton.Name = "coinDetailButton";
            coinDetailButton.Size = new Size(77, 25);
            coinDetailButton.TabIndex = 2;
            coinDetailButton.Text = "Перейти";
            coinDetailButton.UseVisualStyleBackColor = true;
            coinDetailButton.Click += this.coinDetailButton_Click;
            // 
            // pictureCoin
            // 
            pictureCoin.Image = (Image)resources.GetObject("pictureCoin.Image");
            pictureCoin.Location = new Point(0, 0);
            pictureCoin.Name = "pictureCoin";
            pictureCoin.Size = new Size(142, 142);
            pictureCoin.TabIndex = 3;
            pictureCoin.TabStop = false;
            // 
            // BaseCoinBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(pictureCoin);
            Controls.Add(coinDetailButton);
            Controls.Add(priceCoin);
            Controls.Add(coinTitle);
            Margin = new Padding(0, 6, 0, 0);
            Name = "BaseCoinBox";
            Size = new Size(690, 143);
            ((System.ComponentModel.ISupportInitialize)pictureCoin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label coinTitle;
        private Label priceCoin;
        private Button coinDetailButton;
        private PictureBox pictureCoin;
    }
}
