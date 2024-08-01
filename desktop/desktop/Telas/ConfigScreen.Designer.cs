namespace desktop.Telas
{
    partial class ConfigScreen
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
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            panelConfigOption = new Panel();
            buttonImportStudents = new MaterialSkin.Controls.MaterialButton();
            buttonImportClasses = new MaterialSkin.Controls.MaterialButton();
            buttonTranslateOutput = new MaterialSkin.Controls.MaterialButton();
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
            buttonStarterScreen.TabIndex = 30;
            buttonStarterScreen.Text = "VOLTAR";
            buttonStarterScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonStarterScreen.UseAccentColor = false;
            buttonStarterScreen.UseVisualStyleBackColor = true;
            buttonStarterScreen.Click += buttonStarterScreen_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(1013, 669);
            materialButton3.Margin = new Padding(5, 8, 5, 8);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(94, 36);
            materialButton3.TabIndex = 20;
            materialButton3.Text = "FINALIZAR";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // panelConfigOption
            // 
            panelConfigOption.BackColor = SystemColors.ControlLightLight;
            panelConfigOption.Location = new Point(279, 131);
            panelConfigOption.Name = "panelConfigOption";
            panelConfigOption.Size = new Size(828, 504);
            panelConfigOption.TabIndex = 31;
            // 
            // buttonImportStudents
            // 
            buttonImportStudents.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonImportStudents.BackColor = SystemColors.Control;
            buttonImportStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonImportStudents.Depth = 0;
            buttonImportStudents.HighEmphasis = true;
            buttonImportStudents.Icon = null;
            buttonImportStudents.Location = new Point(35, 131);
            buttonImportStudents.Margin = new Padding(4, 6, 4, 6);
            buttonImportStudents.MouseState = MaterialSkin.MouseState.HOVER;
            buttonImportStudents.Name = "buttonImportStudents";
            buttonImportStudents.NoAccentTextColor = Color.Empty;
            buttonImportStudents.Size = new Size(155, 36);
            buttonImportStudents.TabIndex = 32;
            buttonImportStudents.Text = "IMPORTAR ALUNOS";
            buttonImportStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonImportStudents.UseAccentColor = false;
            buttonImportStudents.UseVisualStyleBackColor = false;
            // 
            // buttonImportClasses
            // 
            buttonImportClasses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonImportClasses.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonImportClasses.Depth = 0;
            buttonImportClasses.HighEmphasis = true;
            buttonImportClasses.Icon = null;
            buttonImportClasses.Location = new Point(35, 229);
            buttonImportClasses.Margin = new Padding(4, 6, 4, 6);
            buttonImportClasses.MouseState = MaterialSkin.MouseState.HOVER;
            buttonImportClasses.Name = "buttonImportClasses";
            buttonImportClasses.NoAccentTextColor = Color.Empty;
            buttonImportClasses.Size = new Size(144, 36);
            buttonImportClasses.TabIndex = 33;
            buttonImportClasses.Text = "IMPORTAR AULAS";
            buttonImportClasses.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonImportClasses.UseAccentColor = false;
            buttonImportClasses.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateOutput
            // 
            buttonTranslateOutput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonTranslateOutput.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonTranslateOutput.Depth = 0;
            buttonTranslateOutput.HighEmphasis = true;
            buttonTranslateOutput.Icon = null;
            buttonTranslateOutput.Location = new Point(35, 326);
            buttonTranslateOutput.Margin = new Padding(4, 6, 4, 6);
            buttonTranslateOutput.MouseState = MaterialSkin.MouseState.HOVER;
            buttonTranslateOutput.Name = "buttonTranslateOutput";
            buttonTranslateOutput.NoAccentTextColor = Color.Empty;
            buttonTranslateOutput.Size = new Size(136, 36);
            buttonTranslateOutput.TabIndex = 34;
            buttonTranslateOutput.Text = "TRADUZIR SAÍDA";
            buttonTranslateOutput.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonTranslateOutput.UseAccentColor = false;
            buttonTranslateOutput.UseVisualStyleBackColor = true;
            // 
            // ConfigScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonTranslateOutput);
            Controls.Add(buttonImportClasses);
            Controls.Add(buttonImportStudents);
            Controls.Add(panelConfigOption);
            Controls.Add(buttonStarterScreen);
            Controls.Add(materialButton3);
            Name = "ConfigScreen";
            Size = new Size(1155, 740);
            Load += ConfigScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonStarterScreen;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private Panel panelConfigOption;
        private MaterialSkin.Controls.MaterialButton buttonImportStudents;
        private MaterialSkin.Controls.MaterialButton buttonImportClasses;
        private MaterialSkin.Controls.MaterialButton buttonTranslateOutput;
    }
}
