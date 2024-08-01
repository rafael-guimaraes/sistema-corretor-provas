namespace desktop
{
    partial class main
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
            activeScreen = new Panel();
            SuspendLayout();
            // 
            // activeScreen
            // 
            activeScreen.Location = new Point(-1, 63);
            activeScreen.Margin = new Padding(3, 4, 3, 4);
            activeScreen.Name = "activeScreen";
            activeScreen.Size = new Size(1155, 740);
            activeScreen.TabIndex = 0;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 797);
            Controls.Add(activeScreen);
            Margin = new Padding(3, 4, 3, 4);
            Name = "main";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Load += main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel activeScreen;
    }
}
