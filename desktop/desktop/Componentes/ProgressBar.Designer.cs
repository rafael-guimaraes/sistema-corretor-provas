namespace desktop.Componentes
{
    partial class ProgressBar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent(int width, int height)
        {
            progressBarItem = new System.Windows.Forms.ProgressBar();
            progressText = new Label();
            SuspendLayout();
            // 
            // progressBarItem
            // 
            progressBarItem.BackColor = SystemColors.Control;
            progressBarItem.Location = new Point((int)(width*.1), (int)(height * .4));;
            progressBarItem.MarqueeAnimationSpeed = 1;
            progressBarItem.Name = "progressBarItem";
            progressBarItem.RightToLeft = RightToLeft.No;
            progressBarItem.Size = new Size((int)(width*.8), (int)(height*.2));
            progressBarItem.Step = 1;
            progressBarItem.Style = ProgressBarStyle.Continuous;
            progressBarItem.TabIndex = 0;
            progressBarItem.Value = 0;
            progressBarItem.Step = 0;
            // 
            // progressText
            // 
            progressText.AutoSize = true;
            progressText.Location = new Point((int) (width/2) - 25, (int)(height * .6));
            progressText.Name = "progressText";
            progressText.Size = new Size(50, 20);
            progressText.TextAlign = ContentAlignment.MiddleCenter;
            progressText.TabIndex = 1;
            progressText.Text = "0/0";
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(progressText);
            Controls.Add(progressBarItem);
            Name = "ProgressBar";
            Size = new Size(width, height);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label progressText;
        public System.Windows.Forms.ProgressBar progressBarItem;
    }
}
