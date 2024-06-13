namespace desktop.Telas
{
    partial class PrintScreen
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
            panel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // buttonStarterScreen
            // 
            buttonStarterScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonStarterScreen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonStarterScreen.Depth = 0;
            buttonStarterScreen.HighEmphasis = true;
            buttonStarterScreen.Icon = null;
            buttonStarterScreen.Location = new Point(31, 26);
            buttonStarterScreen.Margin = new Padding(4);
            buttonStarterScreen.MouseState = MaterialSkin.MouseState.HOVER;
            buttonStarterScreen.Name = "buttonStarterScreen";
            buttonStarterScreen.NoAccentTextColor = Color.Empty;
            buttonStarterScreen.Size = new Size(77, 36);
            buttonStarterScreen.TabIndex = 32;
            buttonStarterScreen.Text = "VOLTAR";
            buttonStarterScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonStarterScreen.UseAccentColor = false;
            buttonStarterScreen.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ControlDark;
            panel.Location = new Point(31, 87);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(945, 430);
            panel.TabIndex = 33;
            // 
            // PrintScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Controls.Add(buttonStarterScreen);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PrintScreen";
            Size = new Size(1011, 555);
            Load += PrintScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonStarterScreen;
        private FlowLayoutPanel panel;
    }
}
