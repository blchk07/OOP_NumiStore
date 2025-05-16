using System.ComponentModel;

namespace OOP_NumiStore.Forms
{
    partial class MainForm
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
            coinTypeLabel = new Label();
            coinTypesCheckedListBox = new CheckedListBox();
            applySearchButton = new Button();
            label12 = new Label();
            coinDiameterToTextBox = new TextBox();
            label13 = new Label();
            coinDiameterLabel = new Label();
            coinDiameterFromTextBox = new TextBox();
            coinSeriesLabel = new Label();
            coinSeriesComboBox = new ComboBox();
            coinMaterialLabel = new Label();
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
            coinMaterialsCheckedListBox = new CheckedListBox();
            headerPanel = new Panel();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            userLoginLinkLabel = new LinkLabel();
            logoutButton = new Button();
            headName = new Label();
            button1 = new Button();
            coinListBlockPanel.SuspendLayout();
            mainHeaderPanel.SuspendLayout();
            searchBlockPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            coinListBlockPanel.Location = new Point(246, 45);
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
            searchBlockPanel.Controls.Add(coinTypeLabel);
            searchBlockPanel.Controls.Add(coinTypesCheckedListBox);
            searchBlockPanel.Controls.Add(applySearchButton);
            searchBlockPanel.Controls.Add(label12);
            searchBlockPanel.Controls.Add(coinDiameterToTextBox);
            searchBlockPanel.Controls.Add(label13);
            searchBlockPanel.Controls.Add(coinDiameterLabel);
            searchBlockPanel.Controls.Add(coinDiameterFromTextBox);
            searchBlockPanel.Controls.Add(coinSeriesLabel);
            searchBlockPanel.Controls.Add(coinSeriesComboBox);
            searchBlockPanel.Controls.Add(coinMaterialLabel);
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
            searchBlockPanel.Controls.Add(coinMaterialsCheckedListBox);
            searchBlockPanel.Location = new Point(2, 45);
            searchBlockPanel.Name = "searchBlockPanel";
            searchBlockPanel.Size = new Size(241, 515);
            searchBlockPanel.TabIndex = 2;
            // 
            // coinTypeLabel
            // 
            coinTypeLabel.AutoSize = true;
            coinTypeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinTypeLabel.Location = new Point(33, 282);
            coinTypeLabel.Name = "coinTypeLabel";
            coinTypeLabel.Size = new Size(71, 15);
            coinTypeLabel.TabIndex = 30;
            coinTypeLabel.Text = "Тип монети";
            // 
            // coinTypesCheckedListBox
            // 
            coinTypesCheckedListBox.FormattingEnabled = true;
            coinTypesCheckedListBox.Location = new Point(33, 301);
            coinTypesCheckedListBox.Name = "coinTypesCheckedListBox";
            coinTypesCheckedListBox.Size = new Size(175, 40);
            coinTypesCheckedListBox.Sorted = true;
            coinTypesCheckedListBox.TabIndex = 31;
            // 
            // applySearchButton
            // 
            applySearchButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            applySearchButton.Location = new Point(33, 443);
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
            label12.Location = new Point(125, 411);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 26;
            label12.Text = "до";
            // 
            // coinDiameterToTextBox
            // 
            coinDiameterToTextBox.Location = new Point(153, 408);
            coinDiameterToTextBox.Name = "coinDiameterToTextBox";
            coinDiameterToTextBox.Size = new Size(55, 23);
            coinDiameterToTextBox.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 411);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 24;
            label13.Text = "від";
            // 
            // coinDiameterLabel
            // 
            coinDiameterLabel.AutoSize = true;
            coinDiameterLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinDiameterLabel.Location = new Point(33, 390);
            coinDiameterLabel.Name = "coinDiameterLabel";
            coinDiameterLabel.Size = new Size(52, 15);
            coinDiameterLabel.TabIndex = 23;
            coinDiameterLabel.Text = "Діаметр";
            // 
            // coinDiameterFromTextBox
            // 
            coinDiameterFromTextBox.Location = new Point(61, 408);
            coinDiameterFromTextBox.Name = "coinDiameterFromTextBox";
            coinDiameterFromTextBox.Size = new Size(55, 23);
            coinDiameterFromTextBox.TabIndex = 22;
            // 
            // coinSeriesLabel
            // 
            coinSeriesLabel.AutoSize = true;
            coinSeriesLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinSeriesLabel.Location = new Point(33, 346);
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
            coinSeriesComboBox.Location = new Point(33, 364);
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
            coinMaterialLabel.Location = new Point(33, 184);
            coinMaterialLabel.Name = "coinMaterialLabel";
            coinMaterialLabel.Size = new Size(58, 15);
            coinMaterialLabel.TabIndex = 18;
            coinMaterialLabel.Text = "Матеріал";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 161);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 14;
            label6.Text = "до";
            // 
            // coinYearToTextBox
            // 
            coinYearToTextBox.Location = new Point(153, 158);
            coinYearToTextBox.Name = "coinYearToTextBox";
            coinYearToTextBox.Size = new Size(55, 23);
            coinYearToTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 161);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 12;
            label7.Text = "від";
            // 
            // coinYearLabel
            // 
            coinYearLabel.AutoSize = true;
            coinYearLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinYearLabel.Location = new Point(33, 140);
            coinYearLabel.Name = "coinYearLabel";
            coinYearLabel.Size = new Size(71, 15);
            coinYearLabel.TabIndex = 11;
            coinYearLabel.Text = "Рік випуску";
            // 
            // coinYearFromTextBox
            // 
            coinYearFromTextBox.Location = new Point(61, 158);
            coinYearFromTextBox.Name = "coinYearFromTextBox";
            coinYearFromTextBox.Size = new Size(55, 23);
            coinYearFromTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 117);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 9;
            label5.Text = "до";
            // 
            // coinPriceToTextBox
            // 
            coinPriceToTextBox.Location = new Point(153, 114);
            coinPriceToTextBox.Name = "coinPriceToTextBox";
            coinPriceToTextBox.Size = new Size(55, 23);
            coinPriceToTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 117);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 7;
            label4.Text = "від";
            // 
            // coinPriceLabel
            // 
            coinPriceLabel.AutoSize = true;
            coinPriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinPriceLabel.Location = new Point(33, 96);
            coinPriceLabel.Name = "coinPriceLabel";
            coinPriceLabel.Size = new Size(32, 15);
            coinPriceLabel.TabIndex = 6;
            coinPriceLabel.Text = "Ціна";
            // 
            // coinPriceFromTextBox
            // 
            coinPriceFromTextBox.Location = new Point(61, 114);
            coinPriceFromTextBox.Name = "coinPriceFromTextBox";
            coinPriceFromTextBox.Size = new Size(55, 23);
            coinPriceFromTextBox.TabIndex = 5;
            // 
            // coinNameLabel
            // 
            coinNameLabel.AutoSize = true;
            coinNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coinNameLabel.Location = new Point(33, 52);
            coinNameLabel.Name = "coinNameLabel";
            coinNameLabel.Size = new Size(85, 15);
            coinNameLabel.TabIndex = 4;
            coinNameLabel.Text = "Назва монети";
            // 
            // coinNameTextBox
            // 
            coinNameTextBox.Location = new Point(33, 70);
            coinNameTextBox.Name = "coinNameTextBox";
            coinNameTextBox.Size = new Size(175, 23);
            coinNameTextBox.TabIndex = 3;
            coinNameTextBox.TextChanged += applySearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(33, 13);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 2;
            label1.Text = "Пошук та фільтри";
            // 
            // coinMaterialsCheckedListBox
            // 
            coinMaterialsCheckedListBox.FormattingEnabled = true;
            coinMaterialsCheckedListBox.Location = new Point(33, 203);
            coinMaterialsCheckedListBox.Name = "coinMaterialsCheckedListBox";
            coinMaterialsCheckedListBox.Size = new Size(175, 76);
            coinMaterialsCheckedListBox.Sorted = true;
            coinMaterialsCheckedListBox.TabIndex = 29;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(button2);
            headerPanel.Controls.Add(tableLayoutPanel1);
            headerPanel.Controls.Add(headName);
            headerPanel.Controls.Add(button1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(804, 46);
            headerPanel.TabIndex = 3;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(341, 11);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.1451645F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.85484F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Controls.Add(userLoginLinkLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(logoutButton, 1, 0);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(548, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(248, 29);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // userLoginLinkLabel
            // 
            userLoginLinkLabel.Anchor = AnchorStyles.Right;
            userLoginLinkLabel.AutoSize = true;
            userLoginLinkLabel.LinkColor = Color.Black;
            userLoginLinkLabel.Location = new Point(107, 7);
            userLoginLinkLabel.Name = "userLoginLinkLabel";
            userLoginLinkLabel.Size = new Size(59, 15);
            userLoginLinkLabel.TabIndex = 5;
            userLoginLinkLabel.TabStop = true;
            userLoginLinkLabel.Text = "userLogin";
            userLoginLinkLabel.LinkClicked += userLoginLinkLabel_LinkClicked;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Right;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.Location = new Point(181, 3);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(64, 23);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Вийти";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // headName
            // 
            headName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            headName.AutoSize = true;
            headName.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headName.Location = new Point(31, 3);
            headName.Name = "headName";
            headName.Size = new Size(196, 38);
            headName.TabIndex = 1;
            headName.Text = "NumiStore";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(245, 11);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 562);
            Controls.Add(headerPanel);
            Controls.Add(searchBlockPanel);
            Controls.Add(coinListBlockPanel);
            Name = "MainForm";
            Text = "Головна - Адміністративна панель";
            FormClosed += MainForm_FormClosed;
            coinListBlockPanel.ResumeLayout(false);
            mainHeaderPanel.ResumeLayout(false);
            mainHeaderPanel.PerformLayout();
            searchBlockPanel.ResumeLayout(false);
            searchBlockPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private ComboBox comboBox1;
        private Label coinSeriesLabel;
        private ComboBox coinSeriesComboBox;
        private Label label12;
        protected TextBox coinDiameterToTextBox;
        private Label label13;
        private Label coinDiameterLabel;
        protected TextBox coinDiameterFromTextBox;
        private Button applySearchButton;
        private CheckedListBox coinMaterialsCheckedListBox;
        private Button createNewCoinButton;
        private Panel mainHeaderPanel;
        private Panel headerPanel;
        private Label headName;
        private Button logoutButton;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel userLoginLinkLabel;
        private Label coinTypeLabel;
        private CheckedListBox coinTypesCheckedListBox;
        private Button button1;
        private Button button2;
    }
}