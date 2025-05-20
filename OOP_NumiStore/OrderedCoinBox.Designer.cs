namespace OOP_NumiStore
{
    partial class OrderedCoinBox
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
            tableLayoutPanel1 = new TableLayoutPanel();
            resultLabel = new Label();
            coinTypeLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            coinNameText = new Label();
            coinPictureBox = new PictureBox();
            selectedCountLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(resultLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(422, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(125, 27);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(56, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.RightToLeft = RightToLeft.No;
            resultLabel.Size = new Size(66, 21);
            resultLabel.TabIndex = 26;
            resultLabel.Text = "600 грн";
            // 
            // coinTypeLabel
            // 
            coinTypeLabel.AutoSize = true;
            coinTypeLabel.Location = new Point(193, 42);
            coinTypeLabel.Name = "coinTypeLabel";
            coinTypeLabel.Size = new Size(77, 15);
            coinTypeLabel.TabIndex = 35;
            coinTypeLabel.Text = "Тип монети: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(116, 69);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 33;
            label4.Text = "Обрано:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(118, 42);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 32;
            label5.Text = "Тип монети: ";
            // 
            // coinNameText
            // 
            coinNameText.AutoSize = true;
            coinNameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinNameText.Location = new Point(118, 0);
            coinNameText.Name = "coinNameText";
            coinNameText.Size = new Size(155, 30);
            coinNameText.TabIndex = 31;
            coinNameText.Text = "Назва монети";
            // 
            // coinPictureBox
            // 
            coinPictureBox.BackColor = SystemColors.ActiveCaption;
            coinPictureBox.Location = new Point(0, 0);
            coinPictureBox.Name = "coinPictureBox";
            coinPictureBox.Size = new Size(100, 100);
            coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            coinPictureBox.TabIndex = 30;
            coinPictureBox.TabStop = false;
            // 
            // selectedCountLabel
            // 
            selectedCountLabel.AutoSize = true;
            selectedCountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedCountLabel.Location = new Point(183, 69);
            selectedCountLabel.Name = "selectedCountLabel";
            selectedCountLabel.Size = new Size(40, 21);
            selectedCountLabel.TabIndex = 38;
            selectedCountLabel.Text = "1 шт";
            // 
            // OrderedCoinBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(selectedCountLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(coinTypeLabel);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(coinNameText);
            Controls.Add(coinPictureBox);
            Name = "OrderedCoinBox";
            Size = new Size(580, 100);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label resultLabel;
        private Label coinTypeLabel;
        private Label label4;
        private Label label5;
        private Label coinNameText;
        private PictureBox coinPictureBox;
        private Label selectedCountLabel;
    }
}
