namespace OOP_NumiStore.Forms
{
    partial class CreateCoinForm
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
            coinDescriptionTextBox = new RichTextBox();
            createCoinButton = new Button();
            panel1 = new Panel();
            coinPictureBox = new PictureBox();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            coinDiametrTextBox = new TextBox();
            label8 = new Label();
            coinDenominationTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            coinAvaiableCountTextBox = new TextBox();
            coinPriceTextBox = new TextBox();
            coinYearTextBox = new TextBox();
            coinNameTextBox = new TextBox();
            coinMaterialComboBox = new ComboBox();
            coinSeriesComboBox = new ComboBox();
            collectibleCoinRadioButton = new RadioButton();
            regularCoinRadioButton = new RadioButton();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).BeginInit();
            SuspendLayout();
            // 
            // coinDescriptionTextBox
            // 
            coinDescriptionTextBox.Location = new Point(149, 369);
            coinDescriptionTextBox.Name = "coinDescriptionTextBox";
            coinDescriptionTextBox.Size = new Size(464, 63);
            coinDescriptionTextBox.TabIndex = 57;
            coinDescriptionTextBox.Text = "";
            // 
            // createCoinButton
            // 
            createCoinButton.Cursor = Cursors.Hand;
            createCoinButton.Location = new Point(258, 449);
            createCoinButton.Name = "createCoinButton";
            createCoinButton.Size = new Size(169, 30);
            createCoinButton.TabIndex = 56;
            createCoinButton.Text = "Створити";
            createCoinButton.UseVisualStyleBackColor = true;
            createCoinButton.Click += createCoinButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(coinPictureBox);
            panel1.Location = new Point(401, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 267);
            panel1.TabIndex = 55;
            // 
            // coinPictureBox
            // 
            coinPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinPictureBox.BackColor = SystemColors.ButtonHighlight;
            coinPictureBox.BorderStyle = BorderStyle.FixedSingle;
            coinPictureBox.Location = new Point(2, 0);
            coinPictureBox.Name = "coinPictureBox";
            coinPictureBox.Size = new Size(209, 209);
            coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            coinPictureBox.TabIndex = 29;
            coinPictureBox.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(107, 388);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 54;
            label11.Text = "Опис";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(106, 334);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 53;
            label9.Text = "Серія";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(68, 296);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 52;
            label10.Text = "Діаметр, мм";
            // 
            // coinDiametrTextBox
            // 
            coinDiametrTextBox.Location = new Point(149, 293);
            coinDiametrTextBox.Name = "coinDiametrTextBox";
            coinDiametrTextBox.Size = new Size(168, 23);
            coinDiametrTextBox.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(88, 258);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 50;
            label8.Text = "Номінал";
            // 
            // coinDenominationTextBox
            // 
            coinDenominationTextBox.Location = new Point(149, 255);
            coinDenominationTextBox.Name = "coinDenominationTextBox";
            coinDenominationTextBox.Size = new Size(168, 23);
            coinDenominationTextBox.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 219);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 47;
            label6.Text = "Доступна кількість, шт";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 181);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 46;
            label5.Text = "Ціна, грн";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 143);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 45;
            label4.Text = "Матеріал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 104);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 44;
            label3.Text = "Рік випуску";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 43;
            label2.Text = "Назва";
            // 
            // coinAvaiableCountTextBox
            // 
            coinAvaiableCountTextBox.Location = new Point(149, 216);
            coinAvaiableCountTextBox.Name = "coinAvaiableCountTextBox";
            coinAvaiableCountTextBox.Size = new Size(168, 23);
            coinAvaiableCountTextBox.TabIndex = 40;
            // 
            // coinPriceTextBox
            // 
            coinPriceTextBox.Location = new Point(149, 178);
            coinPriceTextBox.Name = "coinPriceTextBox";
            coinPriceTextBox.Size = new Size(168, 23);
            coinPriceTextBox.TabIndex = 39;
            // 
            // coinYearTextBox
            // 
            coinYearTextBox.Location = new Point(149, 101);
            coinYearTextBox.Name = "coinYearTextBox";
            coinYearTextBox.Size = new Size(168, 23);
            coinYearTextBox.TabIndex = 38;
            // 
            // coinNameTextBox
            // 
            coinNameTextBox.Location = new Point(149, 63);
            coinNameTextBox.Name = "coinNameTextBox";
            coinNameTextBox.Size = new Size(168, 23);
            coinNameTextBox.TabIndex = 37;
            // 
            // coinMaterialComboBox
            // 
            coinMaterialComboBox.DropDownHeight = 150;
            coinMaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            coinMaterialComboBox.FormattingEnabled = true;
            coinMaterialComboBox.IntegralHeight = false;
            coinMaterialComboBox.Location = new Point(149, 140);
            coinMaterialComboBox.MaxDropDownItems = 10;
            coinMaterialComboBox.Name = "coinMaterialComboBox";
            coinMaterialComboBox.Size = new Size(168, 23);
            coinMaterialComboBox.Sorted = true;
            coinMaterialComboBox.TabIndex = 58;
            // 
            // coinSeriesComboBox
            // 
            coinSeriesComboBox.FormattingEnabled = true;
            coinSeriesComboBox.Location = new Point(149, 331);
            coinSeriesComboBox.Name = "coinSeriesComboBox";
            coinSeriesComboBox.Size = new Size(168, 23);
            coinSeriesComboBox.Sorted = true;
            coinSeriesComboBox.TabIndex = 60;
            // 
            // collectibleCoinRadioButton
            // 
            collectibleCoinRadioButton.AutoSize = true;
            collectibleCoinRadioButton.Location = new Point(244, 26);
            collectibleCoinRadioButton.Name = "collectibleCoinRadioButton";
            collectibleCoinRadioButton.Size = new Size(88, 19);
            collectibleCoinRadioButton.TabIndex = 61;
            collectibleCoinRadioButton.TabStop = true;
            collectibleCoinRadioButton.Text = "Сувернірна";
            collectibleCoinRadioButton.UseVisualStyleBackColor = true;
            // 
            // regularCoinRadioButton
            // 
            regularCoinRadioButton.AutoSize = true;
            regularCoinRadioButton.Checked = true;
            regularCoinRadioButton.Location = new Point(149, 26);
            regularCoinRadioButton.Name = "regularCoinRadioButton";
            regularCoinRadioButton.Size = new Size(80, 19);
            regularCoinRadioButton.TabIndex = 62;
            regularCoinRadioButton.TabStop = true;
            regularCoinRadioButton.Text = "Оборотна";
            regularCoinRadioButton.UseVisualStyleBackColor = true;
            regularCoinRadioButton.CheckedChanged += regularCoinRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 63;
            label1.Text = "Тип монети";
            // 
            // CreateCoinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 504);
            Controls.Add(label1);
            Controls.Add(regularCoinRadioButton);
            Controls.Add(collectibleCoinRadioButton);
            Controls.Add(coinDescriptionTextBox);
            Controls.Add(createCoinButton);
            Controls.Add(panel1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(coinDiametrTextBox);
            Controls.Add(label8);
            Controls.Add(coinDenominationTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(coinAvaiableCountTextBox);
            Controls.Add(coinPriceTextBox);
            Controls.Add(coinYearTextBox);
            Controls.Add(coinNameTextBox);
            Controls.Add(coinMaterialComboBox);
            Controls.Add(coinSeriesComboBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateCoinForm";
            Text = "Створити нову монету";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox coinDescriptionTextBox;
        private Button createCoinButton;
        private Panel panel1;
        private PictureBox coinPictureBox;
        private Label label11;
        private Label label9;
        private Label label10;
        private TextBox coinDiametrTextBox;
        private Label label8;
        private TextBox coinDenominationTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox coinAvaiableCountTextBox;
        private TextBox coinPriceTextBox;
        private TextBox coinYearTextBox;
        private TextBox coinNameTextBox;
        private ComboBox coinMaterialComboBox;
        private ComboBox coinSeriesComboBox;
        private RadioButton collectibleCoinRadioButton;
        private RadioButton regularCoinRadioButton;
        private Label label1;
    }
}