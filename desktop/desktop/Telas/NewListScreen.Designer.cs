namespace desktop.Telas
{
    partial class NewListScreen
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
            buttonListScreen = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // buttonListScreen
            // 
            buttonListScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonListScreen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonListScreen.Depth = 0;
            buttonListScreen.HighEmphasis = true;
            buttonListScreen.Icon = null;
            buttonListScreen.Location = new Point(35, 35);
            buttonListScreen.Margin = new Padding(4, 6, 4, 6);
            buttonListScreen.MouseState = MaterialSkin.MouseState.HOVER;
            buttonListScreen.Name = "buttonListScreen";
            buttonListScreen.NoAccentTextColor = Color.Empty;
            buttonListScreen.Size = new Size(77, 36);
            buttonListScreen.TabIndex = 18;
            buttonListScreen.Text = "VOLTAR";
            buttonListScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonListScreen.UseAccentColor = false;
            buttonListScreen.UseVisualStyleBackColor = true;
            // 
            // NewListScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonListScreen);
            Name = "NewListScreen";
            Size = new Size(1155, 740);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonListScreen;
    }
}
