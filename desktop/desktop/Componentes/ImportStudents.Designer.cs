namespace desktop.Componentes
{
    partial class ImportStudents
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
            buttonSave = new MaterialSkin.Controls.MaterialButton();
            buttonSelectFile = new MaterialSkin.Controls.MaterialButton();
            openFileDialog = new OpenFileDialog();
            labelSelectedFile = new Label();
            buttonImportFile = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonSave.Depth = 0;
            buttonSave.HighEmphasis = true;
            buttonSave.Icon = null;
            buttonSave.Location = new Point(628, 441);
            buttonSave.Margin = new Padding(4, 6, 4, 6);
            buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            buttonSave.Name = "buttonSave";
            buttonSave.NoAccentTextColor = Color.Empty;
            buttonSave.Size = new Size(171, 36);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "SALVAR ALTERAÇÕES";
            buttonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonSave.UseAccentColor = false;
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSelectFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonSelectFile.Depth = 0;
            buttonSelectFile.HighEmphasis = true;
            buttonSelectFile.Icon = null;
            buttonSelectFile.Location = new Point(502, 20);
            buttonSelectFile.Margin = new Padding(4, 6, 4, 6);
            buttonSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.NoAccentTextColor = Color.Empty;
            buttonSelectFile.Size = new Size(109, 36);
            buttonSelectFile.TabIndex = 1;
            buttonSelectFile.Text = "SELECIONAR";
            buttonSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonSelectFile.UseAccentColor = false;
            buttonSelectFile.UseVisualStyleBackColor = true;
            buttonSelectFile.Click += buttonSelectFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "csv";
            // 
            // labelSelectedFile
            // 
            labelSelectedFile.AutoSize = true;
            labelSelectedFile.Location = new Point(36, 28);
            labelSelectedFile.Name = "labelSelectedFile";
            labelSelectedFile.Size = new Size(206, 20);
            labelSelectedFile.TabIndex = 2;
            labelSelectedFile.Text = "Nenhum arquivo selecionado.";
            // 
            // buttonImportFile
            // 
            buttonImportFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonImportFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonImportFile.Depth = 0;
            buttonImportFile.HighEmphasis = true;
            buttonImportFile.Icon = null;
            buttonImportFile.Location = new Point(658, 20);
            buttonImportFile.Margin = new Padding(4, 6, 4, 6);
            buttonImportFile.MouseState = MaterialSkin.MouseState.HOVER;
            buttonImportFile.Name = "buttonImportFile";
            buttonImportFile.NoAccentTextColor = Color.Empty;
            buttonImportFile.Size = new Size(148, 36);
            buttonImportFile.TabIndex = 3;
            buttonImportFile.Text = "CARREGAR DADOS";
            buttonImportFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonImportFile.UseAccentColor = false;
            buttonImportFile.UseVisualStyleBackColor = true;
            buttonImportFile.Click += buttonImportFile_Click;
            // 
            // ImportStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(buttonImportFile);
            Controls.Add(labelSelectedFile);
            Controls.Add(buttonSelectFile);
            Controls.Add(buttonSave);
            Name = "ImportStudents";
            Size = new Size(828, 504);
            Load += ImportStudents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonSave;
        private MaterialSkin.Controls.MaterialButton buttonSelectFile;
        private OpenFileDialog openFileDialog;
        private Label labelSelectedFile;
        private MaterialSkin.Controls.MaterialButton buttonImportFile;
    }
}
