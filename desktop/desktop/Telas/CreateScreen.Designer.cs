namespace desktop
{
    partial class CreateScreen
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
            buttonCreateTest = new MaterialSkin.Controls.MaterialButton();
            labelTestType = new Label();
            comboboxTestPeriod = new MaterialSkin.Controls.MaterialComboBox();
            labelTestSubject = new Label();
            comboboxTestSubject = new MaterialSkin.Controls.MaterialComboBox();
            labelTestPeriod = new Label();
            comboboxTestType = new MaterialSkin.Controls.MaterialComboBox();
            label1 = new Label();
            buttonSelectFile = new MaterialSkin.Controls.MaterialButton();
            toggleColumns = new MaterialSkin.Controls.MaterialSwitch();
            panelTestPreview = new Panel();
            buttonListScreen = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // buttonCreateTest
            // 
            buttonCreateTest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCreateTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonCreateTest.Depth = 0;
            buttonCreateTest.HighEmphasis = true;
            buttonCreateTest.Icon = null;
            buttonCreateTest.Location = new Point(1017, 638);
            buttonCreateTest.Margin = new Padding(5, 8, 5, 8);
            buttonCreateTest.MouseState = MaterialSkin.MouseState.HOVER;
            buttonCreateTest.Name = "buttonCreateTest";
            buttonCreateTest.NoAccentTextColor = Color.Empty;
            buttonCreateTest.Size = new Size(94, 36);
            buttonCreateTest.TabIndex = 4;
            buttonCreateTest.Text = "FINALIZAR";
            buttonCreateTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonCreateTest.UseAccentColor = false;
            buttonCreateTest.UseVisualStyleBackColor = true;
            // 
            // labelTestType
            // 
            labelTestType.AutoSize = true;
            labelTestType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTestType.Location = new Point(31, 200);
            labelTestType.Name = "labelTestType";
            labelTestType.Size = new Size(149, 28);
            labelTestType.TabIndex = 14;
            labelTestType.Text = "TIPO DE PROVA";
            // 
            // comboboxTestPeriod
            // 
            comboboxTestPeriod.AutoResize = false;
            comboboxTestPeriod.BackColor = Color.FromArgb(255, 255, 255);
            comboboxTestPeriod.Depth = 0;
            comboboxTestPeriod.DrawMode = DrawMode.OwnerDrawVariable;
            comboboxTestPeriod.DropDownHeight = 174;
            comboboxTestPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxTestPeriod.DropDownWidth = 121;
            comboboxTestPeriod.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboboxTestPeriod.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboboxTestPeriod.FormattingEnabled = true;
            comboboxTestPeriod.IntegralHeight = false;
            comboboxTestPeriod.ItemHeight = 43;
            comboboxTestPeriod.Location = new Point(35, 514);
            comboboxTestPeriod.Margin = new Padding(3, 4, 3, 4);
            comboboxTestPeriod.MaxDropDownItems = 4;
            comboboxTestPeriod.MouseState = MaterialSkin.MouseState.OUT;
            comboboxTestPeriod.Name = "comboboxTestPeriod";
            comboboxTestPeriod.Size = new Size(380, 49);
            comboboxTestPeriod.StartIndex = 0;
            comboboxTestPeriod.TabIndex = 13;
            // 
            // labelTestSubject
            // 
            labelTestSubject.AutoSize = true;
            labelTestSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTestSubject.Location = new Point(31, 342);
            labelTestSubject.Name = "labelTestSubject";
            labelTestSubject.Size = new Size(112, 28);
            labelTestSubject.TabIndex = 15;
            labelTestSubject.Text = "DISCIPLINA";
            // 
            // comboboxTestSubject
            // 
            comboboxTestSubject.AutoResize = false;
            comboboxTestSubject.BackColor = Color.FromArgb(255, 255, 255);
            comboboxTestSubject.Depth = 0;
            comboboxTestSubject.DrawMode = DrawMode.OwnerDrawVariable;
            comboboxTestSubject.DropDownHeight = 174;
            comboboxTestSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxTestSubject.DropDownWidth = 121;
            comboboxTestSubject.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboboxTestSubject.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboboxTestSubject.FormattingEnabled = true;
            comboboxTestSubject.IntegralHeight = false;
            comboboxTestSubject.ItemHeight = 43;
            comboboxTestSubject.Location = new Point(35, 374);
            comboboxTestSubject.Margin = new Padding(3, 4, 3, 4);
            comboboxTestSubject.MaxDropDownItems = 4;
            comboboxTestSubject.MouseState = MaterialSkin.MouseState.OUT;
            comboboxTestSubject.Name = "comboboxTestSubject";
            comboboxTestSubject.Size = new Size(380, 49);
            comboboxTestSubject.StartIndex = 0;
            comboboxTestSubject.TabIndex = 12;
            // 
            // labelTestPeriod
            // 
            labelTestPeriod.AutoSize = true;
            labelTestPeriod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTestPeriod.Location = new Point(31, 482);
            labelTestPeriod.Name = "labelTestPeriod";
            labelTestPeriod.Size = new Size(99, 28);
            labelTestPeriod.TabIndex = 16;
            labelTestPeriod.Text = "BIMESTRE";
            // 
            // comboboxTestType
            // 
            comboboxTestType.AutoResize = false;
            comboboxTestType.BackColor = Color.White;
            comboboxTestType.Depth = 0;
            comboboxTestType.DrawMode = DrawMode.OwnerDrawVariable;
            comboboxTestType.DropDownHeight = 174;
            comboboxTestType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxTestType.DropDownWidth = 121;
            comboboxTestType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboboxTestType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboboxTestType.FormattingEnabled = true;
            comboboxTestType.IntegralHeight = false;
            comboboxTestType.ItemHeight = 43;
            comboboxTestType.Location = new Point(35, 234);
            comboboxTestType.Margin = new Padding(3, 4, 3, 4);
            comboboxTestType.MaxDropDownItems = 4;
            comboboxTestType.MouseState = MaterialSkin.MouseState.OUT;
            comboboxTestType.Name = "comboboxTestType";
            comboboxTestType.Size = new Size(380, 49);
            comboboxTestType.StartIndex = 0;
            comboboxTestType.TabIndex = 11;
            comboboxTestType.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 88);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 10;
            label1.Text = "CRIAR PROVA";
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.AutoSize = false;
            buttonSelectFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSelectFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonSelectFile.Depth = 0;
            buttonSelectFile.HighEmphasis = true;
            buttonSelectFile.Icon = null;
            buttonSelectFile.Location = new Point(31, 591);
            buttonSelectFile.Margin = new Padding(5, 8, 5, 8);
            buttonSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.NoAccentTextColor = Color.Empty;
            buttonSelectFile.Size = new Size(380, 48);
            buttonSelectFile.TabIndex = 7;
            buttonSelectFile.Text = "SELECIONAR ARQUIVO";
            buttonSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonSelectFile.UseAccentColor = false;
            buttonSelectFile.UseVisualStyleBackColor = true;
            // 
            // toggleColumns
            // 
            toggleColumns.AutoSize = true;
            toggleColumns.Depth = 0;
            toggleColumns.Location = new Point(461, 159);
            toggleColumns.Margin = new Padding(0);
            toggleColumns.MouseLocation = new Point(-1, -1);
            toggleColumns.MouseState = MaterialSkin.MouseState.HOVER;
            toggleColumns.Name = "toggleColumns";
            toggleColumns.Ripple = true;
            toggleColumns.Size = new Size(116, 37);
            toggleColumns.TabIndex = 6;
            toggleColumns.Text = "Colunas";
            toggleColumns.UseVisualStyleBackColor = true;
            // 
            // panelTestPreview
            // 
            panelTestPreview.Location = new Point(461, 200);
            panelTestPreview.Margin = new Padding(3, 4, 3, 4);
            panelTestPreview.Name = "panelTestPreview";
            panelTestPreview.Size = new Size(650, 363);
            panelTestPreview.TabIndex = 1;
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
            buttonListScreen.TabIndex = 17;
            buttonListScreen.Text = "VOLTAR";
            buttonListScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonListScreen.UseAccentColor = false;
            buttonListScreen.UseVisualStyleBackColor = true;
            // 
            // CreateScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(buttonListScreen);
            Controls.Add(label1);
            Controls.Add(labelTestType);
            Controls.Add(comboboxTestType);
            Controls.Add(labelTestSubject);
            Controls.Add(comboboxTestPeriod);
            Controls.Add(comboboxTestSubject);
            Controls.Add(buttonCreateTest);
            Controls.Add(labelTestPeriod);
            Controls.Add(buttonSelectFile);
            Controls.Add(panelTestPreview);
            Controls.Add(toggleColumns);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateScreen";
            Size = new Size(1155, 740);
            Load += criarProva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton buttonCreateTest;
        private MaterialSkin.Controls.MaterialSwitch toggleColumns;
        private Panel panelTestPreview;
        private MaterialSkin.Controls.MaterialButton buttonSelectFile;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox comboboxTestPeriod;
        private MaterialSkin.Controls.MaterialComboBox comboboxTestSubject;
        private MaterialSkin.Controls.MaterialComboBox comboboxTestType;
        private Label labelTestSubject;
        private Label labelTestPeriod;
        private Label labelTestType;
        private MaterialSkin.Controls.MaterialButton buttonListScreen;
    }
}
