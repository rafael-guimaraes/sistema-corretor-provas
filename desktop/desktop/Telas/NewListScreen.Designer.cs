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
            panelListAlunos = new FlowLayoutPanel();
            textBoxListName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            buttonImportFile = new MaterialSkin.Controls.MaterialButton();
            textBoxInsertMatricula = new MaterialSkin.Controls.MaterialMaskedTextBox();
            buttonSelectFile = new MaterialSkin.Controls.MaterialButton();
            labelInsertMatricula = new Label();
            label1 = new Label();
            openFileDialog = new OpenFileDialog();
            labelSelectedFile = new Label();
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
            buttonListScreen.Click += buttonListScreen_Click;
            // 
            // panelListAlunos
            // 
            panelListAlunos.BackColor = SystemColors.ControlLightLight;
            panelListAlunos.Location = new Point(35, 204);
            panelListAlunos.Name = "panelListAlunos";
            panelListAlunos.Size = new Size(732, 499);
            panelListAlunos.TabIndex = 19;
            // 
            // textBoxListName
            // 
            textBoxListName.AllowPromptAsInput = true;
            textBoxListName.AnimateReadOnly = false;
            textBoxListName.AsciiOnly = false;
            textBoxListName.BackgroundImageLayout = ImageLayout.None;
            textBoxListName.BeepOnError = false;
            textBoxListName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxListName.Depth = 0;
            textBoxListName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxListName.HidePromptOnLeave = false;
            textBoxListName.HideSelection = true;
            textBoxListName.InsertKeyMode = InsertKeyMode.Default;
            textBoxListName.LeadingIcon = null;
            textBoxListName.Location = new Point(35, 150);
            textBoxListName.Mask = "";
            textBoxListName.MaxLength = 32767;
            textBoxListName.MouseState = MaterialSkin.MouseState.OUT;
            textBoxListName.Name = "textBoxListName";
            textBoxListName.PasswordChar = '\0';
            textBoxListName.PrefixSuffixText = null;
            textBoxListName.PromptChar = '_';
            textBoxListName.ReadOnly = false;
            textBoxListName.RejectInputOnFirstFailure = false;
            textBoxListName.ResetOnPrompt = true;
            textBoxListName.ResetOnSpace = true;
            textBoxListName.RightToLeft = RightToLeft.No;
            textBoxListName.SelectedText = "";
            textBoxListName.SelectionLength = 0;
            textBoxListName.SelectionStart = 0;
            textBoxListName.ShortcutsEnabled = true;
            textBoxListName.Size = new Size(732, 48);
            textBoxListName.SkipLiterals = true;
            textBoxListName.TabIndex = 20;
            textBoxListName.TabStop = false;
            textBoxListName.TextAlign = HorizontalAlignment.Left;
            textBoxListName.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxListName.TrailingIcon = null;
            textBoxListName.UseSystemPasswordChar = false;
            textBoxListName.ValidatingType = null;
            // 
            // buttonImportFile
            // 
            buttonImportFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonImportFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonImportFile.Depth = 0;
            buttonImportFile.HighEmphasis = true;
            buttonImportFile.Icon = null;
            buttonImportFile.Location = new Point(797, 475);
            buttonImportFile.Margin = new Padding(4, 6, 4, 6);
            buttonImportFile.MouseState = MaterialSkin.MouseState.HOVER;
            buttonImportFile.Name = "buttonImportFile";
            buttonImportFile.NoAccentTextColor = Color.Empty;
            buttonImportFile.Size = new Size(148, 36);
            buttonImportFile.TabIndex = 21;
            buttonImportFile.Text = "CARREGAR DADOS";
            buttonImportFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonImportFile.UseAccentColor = false;
            buttonImportFile.UseVisualStyleBackColor = true;
            buttonImportFile.Click += buttonImportFile_Click;
            // 
            // textBoxInsertMatricula
            // 
            textBoxInsertMatricula.AllowPromptAsInput = true;
            textBoxInsertMatricula.AnimateReadOnly = false;
            textBoxInsertMatricula.AsciiOnly = false;
            textBoxInsertMatricula.BackgroundImageLayout = ImageLayout.None;
            textBoxInsertMatricula.BeepOnError = false;
            textBoxInsertMatricula.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxInsertMatricula.Depth = 0;
            textBoxInsertMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxInsertMatricula.HidePromptOnLeave = false;
            textBoxInsertMatricula.HideSelection = true;
            textBoxInsertMatricula.InsertKeyMode = InsertKeyMode.Default;
            textBoxInsertMatricula.LeadingIcon = null;
            textBoxInsertMatricula.Location = new Point(797, 285);
            textBoxInsertMatricula.Mask = "";
            textBoxInsertMatricula.MaxLength = 32767;
            textBoxInsertMatricula.MouseState = MaterialSkin.MouseState.OUT;
            textBoxInsertMatricula.Name = "textBoxInsertMatricula";
            textBoxInsertMatricula.PasswordChar = '\0';
            textBoxInsertMatricula.PrefixSuffixText = null;
            textBoxInsertMatricula.PromptChar = '_';
            textBoxInsertMatricula.ReadOnly = false;
            textBoxInsertMatricula.RejectInputOnFirstFailure = false;
            textBoxInsertMatricula.ResetOnPrompt = true;
            textBoxInsertMatricula.ResetOnSpace = true;
            textBoxInsertMatricula.RightToLeft = RightToLeft.No;
            textBoxInsertMatricula.SelectedText = "";
            textBoxInsertMatricula.SelectionLength = 0;
            textBoxInsertMatricula.SelectionStart = 0;
            textBoxInsertMatricula.ShortcutsEnabled = true;
            textBoxInsertMatricula.Size = new Size(324, 48);
            textBoxInsertMatricula.SkipLiterals = true;
            textBoxInsertMatricula.TabIndex = 22;
            textBoxInsertMatricula.TabStop = false;
            textBoxInsertMatricula.TextAlign = HorizontalAlignment.Left;
            textBoxInsertMatricula.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxInsertMatricula.TrailingIcon = null;
            textBoxInsertMatricula.UseSystemPasswordChar = false;
            textBoxInsertMatricula.ValidatingType = null;
            textBoxInsertMatricula.KeyDown += textBoxInsertMatricula_KeyDown;
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSelectFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonSelectFile.Depth = 0;
            buttonSelectFile.HighEmphasis = true;
            buttonSelectFile.Icon = null;
            buttonSelectFile.Location = new Point(797, 403);
            buttonSelectFile.Margin = new Padding(4, 6, 4, 6);
            buttonSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.NoAccentTextColor = Color.Empty;
            buttonSelectFile.Size = new Size(175, 36);
            buttonSelectFile.TabIndex = 23;
            buttonSelectFile.Text = "SELECIONAR ARQUIVO";
            buttonSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonSelectFile.UseAccentColor = false;
            buttonSelectFile.UseVisualStyleBackColor = true;
            buttonSelectFile.Click += buttonSelectFile_Click;
            // 
            // labelInsertMatricula
            // 
            labelInsertMatricula.AutoSize = true;
            labelInsertMatricula.Font = new Font("Segoe UI", 12F);
            labelInsertMatricula.Location = new Point(797, 254);
            labelInsertMatricula.Name = "labelInsertMatricula";
            labelInsertMatricula.Size = new Size(238, 28);
            labelInsertMatricula.TabIndex = 24;
            labelInsertMatricula.Text = "INSIRA UMA MATRÍCULA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 119);
            label1.Name = "label1";
            label1.Size = new Size(435, 28);
            label1.TabIndex = 25;
            label1.Text = "INSIRA UM TÍTULO PARA A LISTA DE CHAMADA:";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "csv";
            // 
            // labelSelectedFile
            // 
            labelSelectedFile.AutoSize = true;
            labelSelectedFile.Location = new Point(797, 534);
            labelSelectedFile.Name = "labelSelectedFile";
            labelSelectedFile.Size = new Size(206, 20);
            labelSelectedFile.TabIndex = 26;
            labelSelectedFile.Text = "Nenhum arquivo selecionado.";
            // 
            // NewListScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelSelectedFile);
            Controls.Add(label1);
            Controls.Add(labelInsertMatricula);
            Controls.Add(buttonSelectFile);
            Controls.Add(textBoxInsertMatricula);
            Controls.Add(buttonImportFile);
            Controls.Add(textBoxListName);
            Controls.Add(panelListAlunos);
            Controls.Add(buttonListScreen);
            Name = "NewListScreen";
            Size = new Size(1155, 740);
            Load += NewListScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonListScreen;
        private FlowLayoutPanel panelListAlunos;
        private MaterialSkin.Controls.MaterialMaskedTextBox textBoxListName;
        private MaterialSkin.Controls.MaterialButton buttonImportFile;
        private MaterialSkin.Controls.MaterialMaskedTextBox textBoxInsertMatricula;
        private MaterialSkin.Controls.MaterialButton buttonSelectFile;
        private Label labelInsertMatricula;
        private Label label1;
        private OpenFileDialog openFileDialog;
        private Label labelSelectedFile;
    }
}
