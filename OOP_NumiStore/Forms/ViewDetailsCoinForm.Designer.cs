namespace OOP_NumiStore.Forms
{
    partial class ViewDetailsCoinForm
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
            typeCoinLabel = new Label();
            coinDescriptionTextBox = new RichTextBox();
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
            label1 = new Label();
            coinIdTextBox = new TextBox();
            coinAvaiableCountTextBox = new TextBox();
            coinPriceTextBox = new TextBox();
            coinYearTextBox = new TextBox();
            coinNameTextBox = new TextBox();
            coinMaterialTextBox = new TextBox();
            coinSeriesTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).BeginInit();
            SuspendLayout();
            // 
            // typeCoinLabel
            // 
            typeCoinLabel.AutoSize = true;
            typeCoinLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            typeCoinLabel.Location = new Point(85, 14);
            typeCoinLabel.Name = "typeCoinLabel";
            typeCoinLabel.Size = new Size(80, 15);
            typeCoinLabel.TabIndex = 60;
            typeCoinLabel.Text = "Тип монети:  ";
            // 
            // coinDescriptionTextBox
            // 
            coinDescriptionTextBox.Location = new Point(162, 394);
            coinDescriptionTextBox.Name = "coinDescriptionTextBox";
            coinDescriptionTextBox.ReadOnly = true;
            coinDescriptionTextBox.Size = new Size(464, 63);
            coinDescriptionTextBox.TabIndex = 57;
            coinDescriptionTextBox.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(coinPictureBox);
            panel1.Location = new Point(415, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 248);
            panel1.TabIndex = 55;
            // 
            // coinPictureBox
            // 
            coinPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinPictureBox.BackColor = SystemColors.Control;
            coinPictureBox.Location = new Point(2, 0);
            coinPictureBox.Name = "coinPictureBox";
            coinPictureBox.Size = new Size(209, 209);
            coinPictureBox.TabIndex = 29;
            coinPictureBox.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(120, 413);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 54;
            label11.Text = "Опис";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(119, 359);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 53;
            label9.Text = "Серія";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(81, 321);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 52;
            label10.Text = "Діаметр, мм";
            // 
            // coinDiametrTextBox
            // 
            coinDiametrTextBox.Location = new Point(162, 318);
            coinDiametrTextBox.Name = "coinDiametrTextBox";
            coinDiametrTextBox.ReadOnly = true;
            coinDiametrTextBox.Size = new Size(168, 23);
            coinDiametrTextBox.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 283);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 50;
            label8.Text = "Номінал";
            // 
            // coinDenominationTextBox
            // 
            coinDenominationTextBox.Location = new Point(162, 280);
            coinDenominationTextBox.Name = "coinDenominationTextBox";
            coinDenominationTextBox.ReadOnly = true;
            coinDenominationTextBox.Size = new Size(168, 23);
            coinDenominationTextBox.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 242);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 48;
            label6.Text = "Доступна кількість, шт";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 204);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 47;
            label5.Text = "Ціна, грн";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 166);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 46;
            label4.Text = "Матеріал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 127);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 45;
            label3.Text = "Рік випуску";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 89);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 44;
            label2.Text = "Назва";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 51);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 43;
            label1.Text = "Ідентифікатор";
            // 
            // coinIdTextBox
            // 
            coinIdTextBox.HideSelection = false;
            coinIdTextBox.Location = new Point(162, 48);
            coinIdTextBox.Name = "coinIdTextBox";
            coinIdTextBox.ReadOnly = true;
            coinIdTextBox.Size = new Size(47, 23);
            coinIdTextBox.TabIndex = 42;
            // 
            // coinAvaiableCountTextBox
            // 
            coinAvaiableCountTextBox.Location = new Point(162, 239);
            coinAvaiableCountTextBox.Name = "coinAvaiableCountTextBox";
            coinAvaiableCountTextBox.ReadOnly = true;
            coinAvaiableCountTextBox.Size = new Size(168, 23);
            coinAvaiableCountTextBox.TabIndex = 41;
            // 
            // coinPriceTextBox
            // 
            coinPriceTextBox.Location = new Point(162, 201);
            coinPriceTextBox.Name = "coinPriceTextBox";
            coinPriceTextBox.ReadOnly = true;
            coinPriceTextBox.Size = new Size(168, 23);
            coinPriceTextBox.TabIndex = 40;
            // 
            // coinYearTextBox
            // 
            coinYearTextBox.Location = new Point(162, 124);
            coinYearTextBox.Name = "coinYearTextBox";
            coinYearTextBox.ReadOnly = true;
            coinYearTextBox.Size = new Size(168, 23);
            coinYearTextBox.TabIndex = 39;
            // 
            // coinNameTextBox
            // 
            coinNameTextBox.Location = new Point(162, 86);
            coinNameTextBox.Name = "coinNameTextBox";
            coinNameTextBox.ReadOnly = true;
            coinNameTextBox.Size = new Size(168, 23);
            coinNameTextBox.TabIndex = 38;
            // 
            // coinMaterialTextBox
            // 
            coinMaterialTextBox.Location = new Point(162, 163);
            coinMaterialTextBox.Name = "coinMaterialTextBox";
            coinMaterialTextBox.ReadOnly = true;
            coinMaterialTextBox.Size = new Size(168, 23);
            coinMaterialTextBox.TabIndex = 61;
            // 
            // coinSeriesTextBox
            // 
            coinSeriesTextBox.Location = new Point(162, 356);
            coinSeriesTextBox.Name = "coinSeriesTextBox";
            coinSeriesTextBox.ReadOnly = true;
            coinSeriesTextBox.Size = new Size(168, 23);
            coinSeriesTextBox.TabIndex = 62;
            // 
            // ViewDetailsCoinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 491);
            Controls.Add(coinSeriesTextBox);
            Controls.Add(coinMaterialTextBox);
            Controls.Add(typeCoinLabel);
            Controls.Add(coinDescriptionTextBox);
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
            Controls.Add(label1);
            Controls.Add(coinIdTextBox);
            Controls.Add(coinAvaiableCountTextBox);
            Controls.Add(coinPriceTextBox);
            Controls.Add(coinYearTextBox);
            Controls.Add(coinNameTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewDetailsCoinForm";
            Text = "Детальна інформація про монету";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label typeCoinLabel;
        private RichTextBox coinDescriptionTextBox;
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
        private Label label1;
        private TextBox coinIdTextBox;
        private TextBox coinAvaiableCountTextBox;
        private TextBox coinPriceTextBox;
        private TextBox coinYearTextBox;
        private TextBox coinNameTextBox;
        private TextBox coinMaterialTextBox;
        private TextBox coinSeriesTextBox;
    }
}