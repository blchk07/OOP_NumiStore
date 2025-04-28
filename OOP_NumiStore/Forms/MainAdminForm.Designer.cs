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
            headerListCoinLabel = new Label();
            searchBlockPanel = new Panel();
            button1 = new Button();
            label12 = new Label();
            textBox7 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            coinListBlockPanel.SuspendLayout();
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
            coinListBlockPanel.Controls.Add(headerListCoinLabel);
            coinListBlockPanel.Controls.Add(flowLayoutPanel1);
            coinListBlockPanel.Location = new Point(244, 0);
            coinListBlockPanel.Name = "coinListBlockPanel";
            coinListBlockPanel.Size = new Size(559, 515);
            coinListBlockPanel.TabIndex = 1;
            // 
            // headerListCoinLabel
            // 
            headerListCoinLabel.AutoSize = true;
            headerListCoinLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            headerListCoinLabel.Location = new Point(194, 12);
            headerListCoinLabel.Name = "headerListCoinLabel";
            headerListCoinLabel.Size = new Size(171, 32);
            headerListCoinLabel.TabIndex = 1;
            headerListCoinLabel.Text = "Список монет";
            // 
            // searchBlockPanel
            // 
            searchBlockPanel.Controls.Add(button1);
            searchBlockPanel.Controls.Add(label12);
            searchBlockPanel.Controls.Add(textBox7);
            searchBlockPanel.Controls.Add(label13);
            searchBlockPanel.Controls.Add(label14);
            searchBlockPanel.Controls.Add(textBox8);
            searchBlockPanel.Controls.Add(label11);
            searchBlockPanel.Controls.Add(comboBox2);
            searchBlockPanel.Controls.Add(label10);
            searchBlockPanel.Controls.Add(label9);
            searchBlockPanel.Controls.Add(label6);
            searchBlockPanel.Controls.Add(textBox4);
            searchBlockPanel.Controls.Add(label7);
            searchBlockPanel.Controls.Add(label8);
            searchBlockPanel.Controls.Add(textBox5);
            searchBlockPanel.Controls.Add(label5);
            searchBlockPanel.Controls.Add(textBox3);
            searchBlockPanel.Controls.Add(label4);
            searchBlockPanel.Controls.Add(label3);
            searchBlockPanel.Controls.Add(textBox2);
            searchBlockPanel.Controls.Add(label2);
            searchBlockPanel.Controls.Add(textBox1);
            searchBlockPanel.Controls.Add(label1);
            searchBlockPanel.Controls.Add(comboBox1);
            searchBlockPanel.Controls.Add(comboBox3);
            searchBlockPanel.Location = new Point(0, 0);
            searchBlockPanel.Name = "searchBlockPanel";
            searchBlockPanel.Size = new Size(241, 515);
            searchBlockPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(33, 451);
            button1.Name = "button1";
            button1.Size = new Size(175, 41);
            button1.TabIndex = 27;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(125, 394);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 26;
            label12.Text = "до";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(153, 391);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(55, 23);
            textBox7.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 394);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 24;
            label13.Text = "від";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(33, 373);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 23;
            label14.Text = "Діаметр";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(61, 391);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(55, 23);
            textBox8.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(33, 320);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 20;
            label11.Text = "Серія";
            // 
            // comboBox2
            // 
            comboBox2.DropDownHeight = 90;
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.Location = new Point(33, 338);
            comboBox2.MaxDropDownItems = 6;
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(175, 23);
            comboBox2.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(33, 265);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 18;
            label10.Text = "Матеріал";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(33, 212);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 16;
            label9.Text = "Країна";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 179);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 14;
            label6.Text = "до";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(55, 23);
            textBox4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 179);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 12;
            label7.Text = "від";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(33, 158);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 11;
            label8.Text = "Рік випуску";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(61, 176);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(55, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 126);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 9;
            label5.Text = "до";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 23);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 126);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 7;
            label4.Text = "від";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(33, 105);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Ціна";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(33, 52);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "Назва монети";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 2;
            label1.Text = "Пошук та фільтри";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DropDownHeight = 150;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(33, 283);
            comboBox1.MaxDropDownItems = 10;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.DropDownHeight = 150;
            comboBox3.FormattingEnabled = true;
            comboBox3.IntegralHeight = false;
            comboBox3.Location = new Point(33, 230);
            comboBox3.MaxDropDownItems = 10;
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(175, 23);
            comboBox3.TabIndex = 28;
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
            coinListBlockPanel.PerformLayout();
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
        protected TextBox textBox1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        protected TextBox textBox2;
        protected TextBox textBox3;
        private Label label6;
        protected TextBox textBox4;
        private Label label7;
        private Label label8;
        protected TextBox textBox5;
        private Label label10;
        private Label label9;
        private ComboBox comboBox1;
        private Label label11;
        private ComboBox comboBox2;
        private Label label12;
        protected TextBox textBox7;
        private Label label13;
        private Label label14;
        protected TextBox textBox8;
        private Button button1;
        private ComboBox comboBox3;
    }
}