namespace OOP_NumiStore.Forms
{
    partial class AddCoinToBasket
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
            coinPictureBox = new PictureBox();
            coinNameText = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            selectedCountNumeric = new NumericUpDown();
            resultLabel = new Label();
            addButton = new Button();
            coinTypeLabel = new Label();
            avaiableCountLabel = new Label();
            oneCoinPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedCountNumeric).BeginInit();
            SuspendLayout();
            // 
            // coinPictureBox
            // 
            coinPictureBox.BackColor = SystemColors.ActiveCaption;
            coinPictureBox.Location = new Point(23, 25);
            coinPictureBox.Name = "coinPictureBox";
            coinPictureBox.Size = new Size(148, 148);
            coinPictureBox.TabIndex = 0;
            coinPictureBox.TabStop = false;
            // 
            // coinNameText
            // 
            coinNameText.AutoSize = true;
            coinNameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinNameText.Location = new Point(197, 25);
            coinNameText.Name = "coinNameText";
            coinNameText.Size = new Size(155, 30);
            coinNameText.TabIndex = 1;
            coinNameText.Text = "Назва монети";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(200, 66);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Тип монети: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(200, 90);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Доступна кількість: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(200, 115);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Ціна за одиницю: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(200, 152);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 5;
            label4.Text = "Обрано:";
            // 
            // selectedCountNumeric
            // 
            selectedCountNumeric.Location = new Point(278, 152);
            selectedCountNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            selectedCountNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            selectedCountNumeric.Name = "selectedCountNumeric";
            selectedCountNumeric.Size = new Size(81, 23);
            selectedCountNumeric.TabIndex = 6;
            selectedCountNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(382, 152);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(226, 21);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "Загалом: 4 х 125.00 = 600 грн";
            // 
            // addButton
            // 
            addButton.Cursor = Cursors.Hand;
            addButton.Location = new Point(245, 202);
            addButton.Name = "addButton";
            addButton.Size = new Size(167, 42);
            addButton.TabIndex = 8;
            addButton.Text = "Додати у кошик";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // coinTypeLabel
            // 
            coinTypeLabel.AutoSize = true;
            coinTypeLabel.Location = new Point(275, 66);
            coinTypeLabel.Name = "coinTypeLabel";
            coinTypeLabel.Size = new Size(77, 15);
            coinTypeLabel.TabIndex = 9;
            coinTypeLabel.Text = "Тип монети: ";
            // 
            // avaiableCountLabel
            // 
            avaiableCountLabel.AutoSize = true;
            avaiableCountLabel.Location = new Point(313, 90);
            avaiableCountLabel.Name = "avaiableCountLabel";
            avaiableCountLabel.Size = new Size(56, 15);
            avaiableCountLabel.TabIndex = 10;
            avaiableCountLabel.Text = "Кількість";
            // 
            // oneCoinPriceLabel
            // 
            oneCoinPriceLabel.AutoSize = true;
            oneCoinPriceLabel.Location = new Point(303, 115);
            oneCoinPriceLabel.Name = "oneCoinPriceLabel";
            oneCoinPriceLabel.Size = new Size(32, 15);
            oneCoinPriceLabel.TabIndex = 11;
            oneCoinPriceLabel.Text = "Ціна";
            // 
            // AddCoinToBasket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 264);
            Controls.Add(oneCoinPriceLabel);
            Controls.Add(avaiableCountLabel);
            Controls.Add(coinTypeLabel);
            Controls.Add(addButton);
            Controls.Add(resultLabel);
            Controls.Add(selectedCountNumeric);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(coinNameText);
            Controls.Add(coinPictureBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCoinToBasket";
            Text = "Додавання у кошик";
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedCountNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox coinPictureBox;
        private Label coinNameText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown selectedCountNumeric;
        private Label resultLabel;
        private Button addButton;
        private Label coinTypeLabel;
        private Label avaiableCountLabel;
        private Label oneCoinPriceLabel;
    }
}