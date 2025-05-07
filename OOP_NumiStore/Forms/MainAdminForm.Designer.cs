using System.ComponentModel;

namespace OOP_NumiStore.Forms
{
    partial class MainAdminForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            coinListBlockPanel = new Panel();
            mainHeaderPanel = new Panel();
            createNewCoinButton = new Button();
            headerListCoinLabel = new Label();
            searchBlockPanel = new Panel();
            applySearchButton = new Button();
            label12 = new Label();
            coinDiameterToTextBox = new TextBox();
            label13 = new Label();
            coinDiameterLabel = new Label();
            coinDiameterFromTextBox = new TextBox();
            coinSeriesLabel = new Label();
            coinSeriesComboBox = new ComboBox();
            coinMaterialLabel = new Label();
            coinCountryLabel = new Label();
            label6 = new Label();
            coinYearToTextBox = new TextBox();
            label7 = new Label();
            coinYearLabel = new Label();
            coinYearFromTextBox = new TextBox();
            label5 = new Label();
            coinPriceToTextBox = new TextBox();
            label4 = new Label();
            coinPriceLabel = new Label();
            coinPriceFromTextBox = new TextBox();
            coinNameLabel = new Label();
            coinNameTextBox = new TextBox();
            label1 = new Label();
            coinCountryComboBox = new ComboBox();
            coinMaterialsCheckedListBox = new CheckedListBox();
            coinListBlockPanel.SuspendLayout();
            mainHeaderPanel.SuspendLayout();
            searchBlockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 59);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(559, 456);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // coinListBlockPanel
            // 
            coinListBlockPanel.BackColor = Color.FromArgb(226, 226, 226);
            coinListBlockPanel.Controls.Add(mainHeaderPanel);
            coinListBlockPanel.Controls.Add(flowLayoutPanel1);
            coinListBlockPanel.Location = new Point(244, 0);
            coinListBlockPanel.Name = "coinListBlockPanel";
            coinListBlockPanel.Size = new Size(559, 515);
            coinListBlockPanel.TabIndex = 1;
            // 
            // mainHeaderPanel
            // 
            mainHeaderPanel.BackColor = SystemColors.ControlLight;
            mainHeaderPanel.Controls.Add(createNewCoinButton);
            mainHeaderPanel.Controls.Add(headerListCoinLabel);
            mainHeaderPanel.Location = new Point(0, 0);
            mainHeaderPanel.Name = "mainHeaderPanel";
            mainHeaderPanel.Size = new Size(559, 58);
            mainHeaderPanel.TabIndex = 3;
            // 
            // createNewCoinButton
            // 
            createNewCoinButton.Cursor = Cursors.Hand;
            createNewCoinButton.FlatStyle = FlatStyle.Popup;
            createNewCoinButton.Location = new Point(446, 13);
            createNewCoinButton.Margin = new Padding(3, 0, 3, 0);
            createNewCoinButton.Name = "createNewCoinButton";
            createNewCoinButton.Size = new Size(92, 32);
            createNewCoinButton.TabIndex = 2;
            createNewCoinButton.Text = "Нова монета";
            createNewCoinButton.UseVisualStyleBackColor = true;
            createNewCoinButton.Click += createNewCoinButton_Click;
            // 
            // headerListCoinLabel
            // 
            headerListCoinLabel.AutoSize = true;
            headerListCoinLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            headerListCoinLabel.Location = new Point(194, 13);
            headerListCoinLabel.Name = "headerListCoinLabel";
            headerListCoinLabel.Size = new Size(171, 32);
            headerListCoinLabel.TabIndex = 1;
            headerListCoinLabel.Text = "Список монет";
            // 
            // searchBlockPanel
            // 
            searchBlockPanel.Controls.Add(applySearchButton);
            searchBlockPanel.Controls.Add(label12);
            searchBlockPanel.Controls.Add(coinDiameterToTextBox);
            searchBlockPanel.Controls.Add(label13);
            searchBlockPanel.Controls.Add(coinDiameterLabel);
            searchBlockPanel.Controls.Add(coinDiameterFromTextBox);
            searchBlockPanel.Controls.Add(coinSeriesLabel);
            searchBlockPanel.Controls.Add(coinSeriesComboBox);
            searchBlockPanel.Controls.Add(coinMaterialLabel);
            searchBlockPanel.Controls.Add(coinCountryLabel);
            searchBlockPanel.Controls.Add(label6);
            searchBlockPanel.Controls.Add(coinYearToTextBox);
            searchBlockPanel.Controls.Add(label7);
            searchBlockPanel.Controls.Add(coinYearLabel);
            searchBlockPanel.Controls.Add(coinYearFromTextBox);
            searchBlockPanel.Controls.Add(label5);
            searchBlockPanel.Controls.Add(coinPriceToTextBox);
            searchBlockPanel.Controls.Add(label4);
            searchBlockPanel.Controls.Add(coinPriceLabel);
            searchBlockPanel.Controls.Add(coinPriceFromTextBox);
            searchBlockPanel.Controls.Add(coinNameLabel);
            searchBlockPanel.Controls.Add(coinNameTextBox);
            searchBlockPanel.Controls.Add(label1);
            searchBlockPanel.Controls.Add(coinCountryComboBox);
            searchBlockPanel.Controls.Add(coinMaterialsCheckedListBox);
            searchBlockPanel.Location = new Point(0, 0);
            searchBlockPanel.Name = "searchBlockPanel";
            searchBlockPanel.Size = new Size(241, 515);
            searchBlockPanel.TabIndex = 2;
            // 
            // applySearchButton
            // 
            applySearchButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            applySearchButton.Location = new Point(31, 464);
            applySearchButton.Name = "applySearchButton";
            applySearchButton.Size = new Size(175, 41);
            applySearchButton.TabIndex = 27;
            applySearchButton.Text = "Пошук";
            applySearchButton.UseVisualStyleBackColor = true;
            applySearchButton.Click += applySearchButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(123, 432);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 26;
            label12.Text = "до";
            // 
            // coinDiameterToTextBox
            // 
            coinDiameterToTextBox.Location = new Point(151, 429);
            coinDiameterToTextBox.Name = "coinDiameterToTextBox";
            coinDiameterToTextBox.Size = new Size(55, 23);
            coinDiameterToTextBox.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 432);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 24;
            label13.Text = "від";
            // 
            // coinDiameterLabel
            // 
            coinDiameterLabel.AutoSize = true;
            coinDiameterLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinDiameterLabel.Location = new Point(31, 411);
            coinDiameterLabel.Name = "coinDiameterLabel";
            coinDiameterLabel.Size = new Size(52, 15);
            coinDiameterLabel.TabIndex = 23;
            coinDiameterLabel.Text = "Діаметр";
            // 
            // coinDiameterFromTextBox
            // 
            coinDiameterFromTextBox.Location = new Point(59, 429);
            coinDiameterFromTextBox.Name = "coinDiameterFromTextBox";
            coinDiameterFromTextBox.Size = new Size(55, 23);
            coinDiameterFromTextBox.TabIndex = 22;
            // 
            // coinSeriesLabel
            // 
            coinSeriesLabel.AutoSize = true;
            coinSeriesLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinSeriesLabel.Location = new Point(31, 358);
            coinSeriesLabel.Name = "coinSeriesLabel";
            coinSeriesLabel.Size = new Size(36, 15);
            coinSeriesLabel.TabIndex = 20;
            coinSeriesLabel.Text = "Серія";
            // 
            // coinSeriesComboBox
            // 
            coinSeriesComboBox.DropDownHeight = 90;
            coinSeriesComboBox.FormattingEnabled = true;
            coinSeriesComboBox.IntegralHeight = false;
            coinSeriesComboBox.Location = new Point(31, 376);
            coinSeriesComboBox.MaxDropDownItems = 6;
            coinSeriesComboBox.Name = "coinSeriesComboBox";
            coinSeriesComboBox.Size = new Size(175, 23);
            coinSeriesComboBox.Sorted = true;
            coinSeriesComboBox.TabIndex = 21;
            // 
            // coinMaterialLabel
            // 
            coinMaterialLabel.AutoSize = true;
            coinMaterialLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinMaterialLabel.Location = new Point(31, 256);
            coinMaterialLabel.Name = "coinMaterialLabel";
            coinMaterialLabel.Size = new Size(58, 15);
            coinMaterialLabel.TabIndex = 18;
            coinMaterialLabel.Text = "Матеріал";
            // 
            // coinCountryLabel
            // 
            coinCountryLabel.AutoSize = true;
            coinCountryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinCountryLabel.Location = new Point(31, 203);
            coinCountryLabel.Name = "coinCountryLabel";
            coinCountryLabel.Size = new Size(43, 15);
            coinCountryLabel.TabIndex = 16;
            coinCountryLabel.Text = "Країна";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 170);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 14;
            label6.Text = "до";
            // 
            // coinYearToTextBox
            // 
            coinYearToTextBox.Location = new Point(151, 167);
            coinYearToTextBox.Name = "coinYearToTextBox";
            coinYearToTextBox.Size = new Size(55, 23);
            coinYearToTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 170);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 12;
            label7.Text = "від";
            // 
            // coinYearLabel
            // 
            coinYearLabel.AutoSize = true;
            coinYearLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinYearLabel.Location = new Point(31, 149);
            coinYearLabel.Name = "coinYearLabel";
            coinYearLabel.Size = new Size(71, 15);
            coinYearLabel.TabIndex = 11;
            coinYearLabel.Text = "Рік випуску";
            // 
            // coinYearFromTextBox
            // 
            coinYearFromTextBox.Location = new Point(59, 167);
            coinYearFromTextBox.Name = "coinYearFromTextBox";
            coinYearFromTextBox.Size = new Size(55, 23);
            coinYearFromTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 117);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 9;
            label5.Text = "до";
            // 
            // coinPriceToTextBox
            // 
            coinPriceToTextBox.Location = new Point(151, 114);
            coinPriceToTextBox.Name = "coinPriceToTextBox";
            coinPriceToTextBox.Size = new Size(55, 23);
            coinPriceToTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 117);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 7;
            label4.Text = "від";
            // 
            // coinPriceLabel
            // 
            coinPriceLabel.AutoSize = true;
            coinPriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinPriceLabel.Location = new Point(31, 96);
            coinPriceLabel.Name = "coinPriceLabel";
            coinPriceLabel.Size = new Size(32, 15);
            coinPriceLabel.TabIndex = 6;
            coinPriceLabel.Text = "Ціна";
            // 
            // coinPriceFromTextBox
            // 
            coinPriceFromTextBox.Location = new Point(59, 114);
            coinPriceFromTextBox.Name = "coinPriceFromTextBox";
            coinPriceFromTextBox.Size = new Size(55, 23);
            coinPriceFromTextBox.TabIndex = 5;
            // 
            // coinNameLabel
            // 
            coinNameLabel.AutoSize = true;
            coinNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinNameLabel.Location = new Point(31, 43);
            coinNameLabel.Name = "coinNameLabel";
            coinNameLabel.Size = new Size(85, 15);
            coinNameLabel.TabIndex = 4;
            coinNameLabel.Text = "Назва монети";
            // 
            // coinNameTextBox
            // 
            coinNameTextBox.Location = new Point(31, 61);
            coinNameTextBox.Name = "coinNameTextBox";
            coinNameTextBox.Size = new Size(175, 23);
            coinNameTextBox.TabIndex = 3;
            coinNameTextBox.TextChanged += applySearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 2;
            label1.Text = "Пошук та фільтри";
            // 
            // coinCountryComboBox
            // 
            coinCountryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            coinCountryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            coinCountryComboBox.DropDownHeight = 150;
            coinCountryComboBox.FormattingEnabled = true;
            coinCountryComboBox.IntegralHeight = false;
            coinCountryComboBox.Location = new Point(31, 221);
            coinCountryComboBox.MaxDropDownItems = 10;
            coinCountryComboBox.Name = "coinCountryComboBox";
            coinCountryComboBox.Size = new Size(175, 23);
            coinCountryComboBox.Sorted = true;
            coinCountryComboBox.TabIndex = 28;
            // 
            // coinMaterialsCheckedListBox
            // 
            coinMaterialsCheckedListBox.FormattingEnabled = true;
            coinMaterialsCheckedListBox.Location = new Point(31, 275);
            coinMaterialsCheckedListBox.Name = "coinMaterialsCheckedListBox";
            coinMaterialsCheckedListBox.Size = new Size(175, 76);
            coinMaterialsCheckedListBox.Sorted = true;
            coinMaterialsCheckedListBox.TabIndex = 29;
            // 
            // MainAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 515);
            Controls.Add(searchBlockPanel);
            Controls.Add(coinListBlockPanel);
            Name = "MainAdminForm";
            Text = "Головна";
            FormClosed += MainForm_FormClosed;
            coinListBlockPanel.ResumeLayout(false);
            mainHeaderPanel.ResumeLayout(false);
            mainHeaderPanel.PerformLayout();
            searchBlockPanel.ResumeLayout(false);
            searchBlockPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel coinListBlockPanel;
        private Label headerListCoinLabel;
        private Panel searchBlockPanel;
        private Label label1;
        protected TextBox coinNameTextBox;
        private Label coinNameLabel;
        private Label label5;
        private Label label4;
        private Label coinPriceLabel;
        protected TextBox coinPriceFromTextBox;
        protected TextBox coinPriceToTextBox;
        private Label label6;
        protected TextBox coinYearToTextBox;
        private Label label7;
        private Label coinYearLabel;
        protected TextBox coinYearFromTextBox;
        private Label coinMaterialLabel;
        private Label coinCountryLabel;
        private ComboBox comboBox1;
        private Label coinSeriesLabel;
        private ComboBox coinSeriesComboBox;
        private Label label12;
        protected TextBox coinDiameterToTextBox;
        private Label label13;
        private Label coinDiameterLabel;
        protected TextBox coinDiameterFromTextBox;
        private Button applySearchButton;
        private ComboBox coinCountryComboBox;
        private CheckedListBox coinMaterialsCheckedListBox;
        private Button createNewCoinButton;
        private Panel mainHeaderPanel;
    }
}