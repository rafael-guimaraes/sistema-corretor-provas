namespace desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelInicial = new Panel();
            SuspendLayout();
            // 
            // panelInicial
            // 
            panelInicial.Location = new Point(-1, 84);
            panelInicial.Margin = new Padding(3, 4, 3, 4);
            panelInicial.Name = "panelInicial";
            panelInicial.Size = new Size(1155, 719);
            panelInicial.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 797);
            Controls.Add(panelInicial);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInicial;
    }
}
