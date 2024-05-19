namespace desktop.Componentes
{
    partial class itemStudent
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
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(486, 30);
            label1.TabIndex = 0;
            label1.Text = "50220326 - Gabriel Costa Fileno - EConInf-3PMA";
            label1.Click += itemStudent_Click;
            // 
            // itemStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(label1);
            Name = "itemStudent";
            Size = new Size(753, 40);
            Click += itemStudent_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
