namespace OOP_NumiStore.Forms
{
    partial class BasketForm
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
            basketItemsPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // basketItemsPanel
            // 
            basketItemsPanel.AutoScroll = true;
            basketItemsPanel.Location = new Point(1, 0);
            basketItemsPanel.Name = "basketItemsPanel";
            basketItemsPanel.Size = new Size(543, 353);
            basketItemsPanel.TabIndex = 1;
            // 
            // BasketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 450);
            Controls.Add(basketItemsPanel);
            Name = "BasketForm";
            Text = "BasketForm";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel basketItemsPanel;
    }
}