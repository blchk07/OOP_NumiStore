﻿namespace OOP_NumiStore.Forms
{
    partial class EditCoinForm
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
            coinNameTextBox = new TextBox();
            coinYearTextBox = new TextBox();
            coinPriceTextBox = new TextBox();
            coinAvaiableCountTextBox = new TextBox();
            coinIdTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            coinDenominationTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            coinDiametrTextBox = new TextBox();
            label11 = new Label();
            coinPictureBox = new PictureBox();
            panel1 = new Panel();
            saveChangesButton = new Button();
            coinDescriptionTextBox = new RichTextBox();
            coinMaterialComboBox = new ComboBox();
            coinSeriesComboBox = new ComboBox();
            typeCoinLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // coinNameTextBox
            // 
            coinNameTextBox.Location = new Point(144, 88);
            coinNameTextBox.Name = "coinNameTextBox";
            coinNameTextBox.Size = new Size(168, 23);
            coinNameTextBox.TabIndex = 1;
            // 
            // coinYearTextBox
            // 
            coinYearTextBox.Location = new Point(144, 126);
            coinYearTextBox.Name = "coinYearTextBox";
            coinYearTextBox.Size = new Size(168, 23);
            coinYearTextBox.TabIndex = 2;
            // 
            // coinPriceTextBox
            // 
            coinPriceTextBox.Location = new Point(144, 203);
            coinPriceTextBox.Name = "coinPriceTextBox";
            coinPriceTextBox.Size = new Size(168, 23);
            coinPriceTextBox.TabIndex = 4;
            // 
            // coinAvaiableCountTextBox
            // 
            coinAvaiableCountTextBox.Location = new Point(144, 241);
            coinAvaiableCountTextBox.Name = "coinAvaiableCountTextBox";
            coinAvaiableCountTextBox.Size = new Size(168, 23);
            coinAvaiableCountTextBox.TabIndex = 5;
            // 
            // coinIdTextBox
            // 
            coinIdTextBox.Cursor = Cursors.No;
            coinIdTextBox.HideSelection = false;
            coinIdTextBox.Location = new Point(144, 50);
            coinIdTextBox.Name = "coinIdTextBox";
            coinIdTextBox.ReadOnly = true;
            coinIdTextBox.Size = new Size(47, 23);
            coinIdTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 53);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "Ідентифікатор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 91);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 129);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 10;
            label3.Text = "Рік випуску";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 168);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Матеріал";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 206);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Ціна, грн";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 244);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 13;
            label6.Text = "Доступна кількість, шт";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 286);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 18;
            label8.Text = "Номінал";
            // 
            // coinDenominationTextBox
            // 
            coinDenominationTextBox.Location = new Point(144, 283);
            coinDenominationTextBox.Name = "coinDenominationTextBox";
            coinDenominationTextBox.Size = new Size(168, 23);
            coinDenominationTextBox.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(101, 362);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 24;
            label9.Text = "Серія";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 324);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 22;
            label10.Text = "Діаметр, мм";
            // 
            // coinDiametrTextBox
            // 
            coinDiametrTextBox.Location = new Point(144, 321);
            coinDiametrTextBox.Name = "coinDiametrTextBox";
            coinDiametrTextBox.Size = new Size(168, 23);
            coinDiametrTextBox.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(102, 416);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 28;
            label11.Text = "Опис";
            // 
            // coinPictureBox
            // 
            coinPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinPictureBox.BackColor = SystemColors.Control;
            coinPictureBox.BorderStyle = BorderStyle.FixedSingle;
            coinPictureBox.Location = new Point(2, 0);
            coinPictureBox.Name = "coinPictureBox";
            coinPictureBox.Size = new Size(209, 209);
            coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            coinPictureBox.TabIndex = 29;
            coinPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(coinPictureBox);
            panel1.Location = new Point(397, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 265);
            panel1.TabIndex = 31;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Cursor = Cursors.Hand;
            saveChangesButton.Location = new Point(253, 477);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(169, 30);
            saveChangesButton.TabIndex = 32;
            saveChangesButton.Text = "Зберегти";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // coinDescriptionTextBox
            // 
            coinDescriptionTextBox.Location = new Point(144, 397);
            coinDescriptionTextBox.Name = "coinDescriptionTextBox";
            coinDescriptionTextBox.Size = new Size(464, 63);
            coinDescriptionTextBox.TabIndex = 33;
            coinDescriptionTextBox.Text = "";
            // 
            // coinMaterialComboBox
            // 
            coinMaterialComboBox.DropDownHeight = 150;
            coinMaterialComboBox.FormattingEnabled = true;
            coinMaterialComboBox.IntegralHeight = false;
            coinMaterialComboBox.Location = new Point(144, 165);
            coinMaterialComboBox.MaxDropDownItems = 10;
            coinMaterialComboBox.Name = "coinMaterialComboBox";
            coinMaterialComboBox.Size = new Size(168, 23);
            coinMaterialComboBox.Sorted = true;
            coinMaterialComboBox.TabIndex = 34;
            // 
            // coinSeriesComboBox
            // 
            coinSeriesComboBox.FormattingEnabled = true;
            coinSeriesComboBox.Location = new Point(144, 359);
            coinSeriesComboBox.Name = "coinSeriesComboBox";
            coinSeriesComboBox.Size = new Size(168, 23);
            coinSeriesComboBox.Sorted = true;
            coinSeriesComboBox.TabIndex = 36;
            // 
            // typeCoinLabel
            // 
            typeCoinLabel.AutoSize = true;
            typeCoinLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            typeCoinLabel.Location = new Point(67, 16);
            typeCoinLabel.Name = "typeCoinLabel";
            typeCoinLabel.Size = new Size(80, 15);
            typeCoinLabel.TabIndex = 37;
            typeCoinLabel.Text = "Тип монети:  ";
            // 
            // EditCoinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 519);
            Controls.Add(typeCoinLabel);
            Controls.Add(coinDescriptionTextBox);
            Controls.Add(saveChangesButton);
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
            Controls.Add(coinMaterialComboBox);
            Controls.Add(coinSeriesComboBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditCoinForm";
            Text = "Редагування монети";
            ((System.ComponentModel.ISupportInitialize)coinPictureBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox coinNameTextBox;
        private TextBox coinYearTextBox;
        private TextBox coinPriceTextBox;
        private TextBox coinAvaiableCountTextBox;
        private TextBox coinIdTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox coinDenominationTextBox;
        private Label label9;
        private Label label10;
        private TextBox coinDiametrTextBox;
        private Label label11;
        private PictureBox coinPictureBox;
        private Panel panel1;
        private Button saveChangesButton;
        private RichTextBox coinDescriptionTextBox;
        private ComboBox coinMaterialComboBox;
        private ComboBox coinSeriesComboBox;
        private Label typeCoinLabel;
    }
}