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
            label1 = new Label();
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
            flowLayoutPanel1.Size = new Size(597, 456);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // coinListBlockPanel
            // 
            coinListBlockPanel.BackColor = Color.FromArgb(224, 224, 224);
            coinListBlockPanel.Controls.Add(headerListCoinLabel);
            coinListBlockPanel.Controls.Add(flowLayoutPanel1);
            coinListBlockPanel.Location = new Point(206, 0);
            coinListBlockPanel.Name = "coinListBlockPanel";
            coinListBlockPanel.Size = new Size(597, 515);
            coinListBlockPanel.TabIndex = 1;
            // 
            // headerListCoinLabel
            // 
            headerListCoinLabel.AutoSize = true;
            headerListCoinLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            headerListCoinLabel.Location = new Point(213, 12);
            headerListCoinLabel.Name = "headerListCoinLabel";
            headerListCoinLabel.Size = new Size(171, 32);
            headerListCoinLabel.TabIndex = 1;
            headerListCoinLabel.Text = "Список монет";
            // 
            // searchBlockPanel
            // 
            searchBlockPanel.Controls.Add(label1);
            searchBlockPanel.Location = new Point(0, 0);
            searchBlockPanel.Name = "searchBlockPanel";
            searchBlockPanel.Size = new Size(203, 515);
            searchBlockPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 2;
            label1.Text = "Пошук та фільтри";
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
    }
}