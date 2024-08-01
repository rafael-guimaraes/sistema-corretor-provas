namespace desktop.Telas
{
    partial class CorrectScreen
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
            buttonStarterScreen = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // buttonStarterScreen
            // 
            buttonStarterScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonStarterScreen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonStarterScreen.Depth = 0;
            buttonStarterScreen.HighEmphasis = true;
            buttonStarterScreen.Icon = null;
            buttonStarterScreen.Location = new Point(35, 35);
            buttonStarterScreen.Margin = new Padding(4, 6, 4, 6);
            buttonStarterScreen.MouseState = MaterialSkin.MouseState.HOVER;
            buttonStarterScreen.Name = "buttonStarterScreen";
            buttonStarterScreen.NoAccentTextColor = Color.Empty;
            buttonStarterScreen.Size = new Size(77, 36);
            buttonStarterScreen.TabIndex = 31;
            buttonStarterScreen.Text = "VOLTAR";
            buttonStarterScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonStarterScreen.UseAccentColor = false;
            buttonStarterScreen.UseVisualStyleBackColor = true;
            // 
            // CorrectScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonStarterScreen);
            Name = "CorrectScreen";
            Size = new Size(1155, 740);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonStarterScreen;
    }
}
