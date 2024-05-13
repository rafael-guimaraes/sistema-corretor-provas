namespace desktop
{
    partial class ListScreen
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
            buttonStarterScreen = new MaterialSkin.Controls.MaterialButton();
            botaoFiltrar_Listas = new MaterialSkin.Controls.MaterialButton();
            textBoxFiltro_Listas = new TextBox();
            buttonCreateScreen = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            panelTabela_Listas = new FlowLayoutPanel();
            buttonNewListScreen = new MaterialSkin.Controls.MaterialButton();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 87);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 32;
            label1.Text = "LISTAS DE CHAMADA";
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
            // botaoFiltrar_Listas
            // 
            botaoFiltrar_Listas.AutoSize = false;
            botaoFiltrar_Listas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoFiltrar_Listas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoFiltrar_Listas.Depth = 0;
            botaoFiltrar_Listas.HighEmphasis = true;
            botaoFiltrar_Listas.Icon = null;
            botaoFiltrar_Listas.Location = new Point(992, 140);
            botaoFiltrar_Listas.Margin = new Padding(5, 8, 5, 8);
            botaoFiltrar_Listas.MouseState = MaterialSkin.MouseState.HOVER;
            botaoFiltrar_Listas.Name = "botaoFiltrar_Listas";
            botaoFiltrar_Listas.NoAccentTextColor = Color.Empty;
            botaoFiltrar_Listas.Size = new Size(123, 37);
            botaoFiltrar_Listas.TabIndex = 13;
            botaoFiltrar_Listas.Text = "FILTRAR";
            botaoFiltrar_Listas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoFiltrar_Listas.UseAccentColor = false;
            botaoFiltrar_Listas.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltro_Listas
            // 
            textBoxFiltro_Listas.BorderStyle = BorderStyle.None;
            textBoxFiltro_Listas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFiltro_Listas.Location = new Point(35, 142);
            textBoxFiltro_Listas.Margin = new Padding(3, 4, 3, 4);
            textBoxFiltro_Listas.Name = "textBoxFiltro_Listas";
            textBoxFiltro_Listas.Size = new Size(949, 35);
            textBoxFiltro_Listas.TabIndex = 12;
            textBoxFiltro_Listas.TextChanged += textBoxFiltro_Listas_TextChanged;
            // 
            // buttonCreateScreen
            // 
            buttonCreateScreen.AutoSize = false;
            buttonCreateScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCreateScreen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonCreateScreen.Depth = 0;
            buttonCreateScreen.HighEmphasis = true;
            buttonCreateScreen.Icon = null;
            buttonCreateScreen.Location = new Point(892, 627);
            buttonCreateScreen.Margin = new Padding(5, 8, 5, 8);
            buttonCreateScreen.MouseState = MaterialSkin.MouseState.HOVER;
            buttonCreateScreen.Name = "buttonCreateScreen";
            buttonCreateScreen.NoAccentTextColor = Color.Empty;
            buttonCreateScreen.Size = new Size(225, 48);
            buttonCreateScreen.TabIndex = 5;
            buttonCreateScreen.Text = "CRIAR PROVA";
            buttonCreateScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonCreateScreen.UseAccentColor = false;
            buttonCreateScreen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(panelTabela_Listas);
            panel2.Controls.Add(buttonNewListScreen);
            panel2.Location = new Point(35, 191);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 415);
            panel2.TabIndex = 1;
            // 
            // panelTabela_Listas
            // 
            panelTabela_Listas.AutoScroll = true;
            panelTabela_Listas.FlowDirection = FlowDirection.TopDown;
            panelTabela_Listas.Location = new Point(0, 68);
            panelTabela_Listas.Margin = new Padding(3, 4, 3, 4);
            panelTabela_Listas.Name = "panelTabela_Listas";
            panelTabela_Listas.Size = new Size(1080, 347);
            panelTabela_Listas.TabIndex = 1;
            panelTabela_Listas.WrapContents = false;
            // 
            // buttonNewListScreen
            // 
            buttonNewListScreen.AutoSize = false;
            buttonNewListScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNewListScreen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonNewListScreen.Depth = 0;
            buttonNewListScreen.HighEmphasis = true;
            buttonNewListScreen.Icon = null;
            buttonNewListScreen.Location = new Point(0, 8);
            buttonNewListScreen.Margin = new Padding(5, 8, 5, 8);
            buttonNewListScreen.MouseState = MaterialSkin.MouseState.HOVER;
            buttonNewListScreen.Name = "buttonNewListScreen";
            buttonNewListScreen.NoAccentTextColor = Color.Empty;
            buttonNewListScreen.Size = new Size(1082, 48);
            buttonNewListScreen.TabIndex = 0;
            buttonNewListScreen.Text = "+ NOVA LISTA DE ALUNOS";
            buttonNewListScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonNewListScreen.UseAccentColor = false;
            buttonNewListScreen.UseVisualStyleBackColor = true;
            // 
            // ListScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(botaoFiltrar_Listas);
            Controls.Add(textBoxFiltro_Listas);
            Controls.Add(buttonStarterScreen);
            Controls.Add(buttonCreateScreen);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListScreen";
            Size = new Size(1155, 716);
            Load += ListScreen_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton buttonNewListScreen;
        private FlowLayoutPanel panelTabela_Listas;
        private MaterialSkin.Controls.MaterialButton buttonCreateScreen;
        private MaterialSkin.Controls.MaterialButton botaoFiltrar_Listas;
        private TextBox textBoxFiltro_Listas;
        private MaterialSkin.Controls.MaterialButton buttonStarterScreen;
        private Label label1;
    }
}
