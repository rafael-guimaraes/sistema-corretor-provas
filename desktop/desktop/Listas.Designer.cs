namespace desktop
{
    partial class Listas
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
            panelTela_Lista_Chamada = new Panel();
            botaoFiltrar_Listas = new MaterialSkin.Controls.MaterialButton();
            textBoxFiltro_Listas = new TextBox();
            labelTitulo_Listas_Chamada = new Label();
            botaoCriar_Prova = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            panelTabela_Listas = new FlowLayoutPanel();
            botaoNova_Lista = new MaterialSkin.Controls.MaterialButton();
            panelTela_Lista_Chamada.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTela_Lista_Chamada
            // 
            panelTela_Lista_Chamada.Controls.Add(botaoFiltrar_Listas);
            panelTela_Lista_Chamada.Controls.Add(textBoxFiltro_Listas);
            panelTela_Lista_Chamada.Controls.Add(labelTitulo_Listas_Chamada);
            panelTela_Lista_Chamada.Controls.Add(botaoCriar_Prova);
            panelTela_Lista_Chamada.Controls.Add(panel2);
            panelTela_Lista_Chamada.Location = new Point(0, 0);
            panelTela_Lista_Chamada.Margin = new Padding(3, 4, 3, 4);
            panelTela_Lista_Chamada.Name = "panelTela_Lista_Chamada";
            panelTela_Lista_Chamada.Size = new Size(1157, 716);
            panelTela_Lista_Chamada.TabIndex = 0;
            // 
            // botaoFiltrar_Listas
            // 
            botaoFiltrar_Listas.AutoSize = false;
            botaoFiltrar_Listas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoFiltrar_Listas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoFiltrar_Listas.Depth = 0;
            botaoFiltrar_Listas.HighEmphasis = true;
            botaoFiltrar_Listas.Icon = null;
            botaoFiltrar_Listas.Location = new Point(983, 113);
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
            textBoxFiltro_Listas.Location = new Point(26, 113);
            textBoxFiltro_Listas.Margin = new Padding(3, 4, 3, 4);
            textBoxFiltro_Listas.Name = "textBoxFiltro_Listas";
            textBoxFiltro_Listas.Size = new Size(949, 35);
            textBoxFiltro_Listas.TabIndex = 12;
            // 
            // labelTitulo_Listas_Chamada
            // 
            labelTitulo_Listas_Chamada.AutoSize = true;
            labelTitulo_Listas_Chamada.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo_Listas_Chamada.Location = new Point(26, 41);
            labelTitulo_Listas_Chamada.Name = "labelTitulo_Listas_Chamada";
            labelTitulo_Listas_Chamada.Size = new Size(277, 37);
            labelTitulo_Listas_Chamada.TabIndex = 11;
            labelTitulo_Listas_Chamada.Text = "LISTA DE CHAMADA";
            // 
            // botaoCriar_Prova
            // 
            botaoCriar_Prova.AutoSize = false;
            botaoCriar_Prova.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoCriar_Prova.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoCriar_Prova.Depth = 0;
            botaoCriar_Prova.HighEmphasis = true;
            botaoCriar_Prova.Icon = null;
            botaoCriar_Prova.Location = new Point(881, 649);
            botaoCriar_Prova.Margin = new Padding(5, 8, 5, 8);
            botaoCriar_Prova.MouseState = MaterialSkin.MouseState.HOVER;
            botaoCriar_Prova.Name = "botaoCriar_Prova";
            botaoCriar_Prova.NoAccentTextColor = Color.Empty;
            botaoCriar_Prova.Size = new Size(225, 59);
            botaoCriar_Prova.TabIndex = 5;
            botaoCriar_Prova.Text = "CRIAR PROVA";
            botaoCriar_Prova.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoCriar_Prova.UseAccentColor = false;
            botaoCriar_Prova.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(panelTabela_Listas);
            panel2.Controls.Add(botaoNova_Lista);
            panel2.Location = new Point(26, 160);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 463);
            panel2.TabIndex = 1;
            // 
            // panelTabela_Listas
            // 
            panelTabela_Listas.AutoScroll = true;
            panelTabela_Listas.FlowDirection = FlowDirection.TopDown;
            panelTabela_Listas.Location = new Point(0, 79);
            panelTabela_Listas.Margin = new Padding(3, 4, 3, 4);
            panelTabela_Listas.Name = "panelTabela_Listas";
            panelTabela_Listas.Size = new Size(1080, 415);
            panelTabela_Listas.TabIndex = 1;
            panelTabela_Listas.WrapContents = false;
            // 
            // botaoNova_Lista
            // 
            botaoNova_Lista.AutoSize = false;
            botaoNova_Lista.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoNova_Lista.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoNova_Lista.Depth = 0;
            botaoNova_Lista.HighEmphasis = true;
            botaoNova_Lista.Icon = null;
            botaoNova_Lista.Location = new Point(17, 19);
            botaoNova_Lista.Margin = new Padding(5, 8, 5, 8);
            botaoNova_Lista.MouseState = MaterialSkin.MouseState.HOVER;
            botaoNova_Lista.Name = "botaoNova_Lista";
            botaoNova_Lista.NoAccentTextColor = Color.Empty;
            botaoNova_Lista.Size = new Size(1048, 48);
            botaoNova_Lista.TabIndex = 0;
            botaoNova_Lista.Text = "+ NOVA LISTA DE ALUNOS";
            botaoNova_Lista.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoNova_Lista.UseAccentColor = false;
            botaoNova_Lista.UseVisualStyleBackColor = true;
            botaoNova_Lista.Click += botaoNova_Lista_Click;
            // 
            // Listas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTela_Lista_Chamada);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Listas";
            Size = new Size(1155, 716);
            Load += Listas_Load;
            panelTela_Lista_Chamada.ResumeLayout(false);
            panelTela_Lista_Chamada.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTela_Lista_Chamada;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton botaoNova_Lista;
        private FlowLayoutPanel panelTabela_Listas;
        private MaterialSkin.Controls.MaterialButton botaoCriar_Prova;
        private Label labelTitulo_Listas_Chamada;
        private MaterialSkin.Controls.MaterialButton botaoFiltrar_Listas;
        private TextBox textBoxFiltro_Listas;
    }
}
