namespace OOP_NumiStore
{
    partial class BasketCoinBox
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
            coinTypeLabel = new Label();
            resultLabel = new Label();
            selectedCountNumeric = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            coinNameText = new Label();
            coinPictureBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)selectedCountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // coinTypeLabel
            // 
            coinTypeLabel.AutoSize = true;
            coinTypeLabel.Location = new Point(193, 42);
            coinTypeLabel.Name = "coinTypeLabel";
            coinTypeLabel.Size = new Size(77, 15);
            coinTypeLabel.TabIndex = 27;
            coinTypeLabel.Text = "Тип монети: ";
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
            // selectedCountNumeric
            // 
            selectedCountNumeric.Location = new Point(193, 69);
            selectedCountNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            selectedCountNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            selectedCountNumeric.Name = "selectedCountNumeric";
            selectedCountNumeric.Size = new Size(81, 23);
            selectedCountNumeric.TabIndex = 25;
            selectedCountNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(116, 69);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 24;
            label4.Text = "Обрано:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(118, 42);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 23;
            label5.Text = "Тип монети: ";
            // 
            // coinNameText
            // 
            coinNameText.AutoSize = true;
            coinNameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinNameText.Location = new Point(118, 0);
            coinNameText.Name = "coinNameText";
            coinNameText.Size = new Size(155, 30);
            coinNameText.TabIndex = 22;
            coinNameText.Text = "Назва монети";
            // 
            // coinPictureBox
            // 
            coinPictureBox.BackColor = SystemColors.ButtonHighlight;
            coinPictureBox.Location = new Point(0, 0);
            coinPictureBox.Name = "coinPictureBox";
            coinPictureBox.Size = new Size(100, 100);
            coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            coinPictureBox.TabIndex = 21;
            coinPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(resultLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(420, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(125, 27);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Location = new Point(519, 7);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(25, 23);
            deleteButton.TabIndex = 29;
            deleteButton.Text = "X";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // BasketCoinBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(deleteButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(coinTypeLabel);
            Controls.Add(selectedCountNumeric);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(coinNameText);
            Controls.Add(coinPictureBox);
            Name = "BasketCoinBox";
            Size = new Size(556, 100);
            ((System.ComponentModel.ISupportInitialize)selectedCountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label coinTypeLabel;
        private Label resultLabel;
        private NumericUpDown selectedCountNumeric;
        private Label label4;
        private Label label5;
        private Label coinNameText;
        private PictureBox coinPictureBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button deleteButton;
    }
}
