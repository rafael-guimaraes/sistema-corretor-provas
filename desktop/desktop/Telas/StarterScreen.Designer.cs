namespace desktop
{
    partial class StarterScreen
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
            panelHeaderCreated = new Panel();
            labelTitulo_Criadas = new Label();
            panelTestOnFocus = new Panel();
            buttonFiltro = new MaterialSkin.Controls.MaterialButton();
            panelHeaderPrinted = new Panel();
            labelTitulo_Impressas = new Label();
            panelHeaderCorrected = new Panel();
            labelTitulo_Corrigidas = new Label();
            buttonOrdem = new MaterialSkin.Controls.MaterialButton();
            panelHeaderOverlay = new Panel();
            labelTitulo_Sobrescritas = new Label();
            labelTitulo_Devolvidas = new Label();
            flowpanelLista_Sobrescritas = new FlowLayoutPanel();
            flowpanelLista_Corrigidas = new FlowLayoutPanel();
            flowpanelLista_Impressas = new FlowLayoutPanel();
            flowpanelLista_Criadas = new FlowLayoutPanel();
            panelHeaderResponded = new Panel();
            flowpanelLista_Devolvidas = new FlowLayoutPanel();
            buttonConfigScreen = new MaterialSkin.Controls.MaterialButton();
            panelHeaderCreated.SuspendLayout();
            panelHeaderPrinted.SuspendLayout();
            panelHeaderCorrected.SuspendLayout();
            panelHeaderOverlay.SuspendLayout();
            panelHeaderResponded.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeaderCreated
            // 
            panelHeaderCreated.BackColor = SystemColors.ControlLight;
            panelHeaderCreated.Controls.Add(labelTitulo_Criadas);
            panelHeaderCreated.Location = new Point(47, 180);
            panelHeaderCreated.Margin = new Padding(3, 4, 3, 4);
            panelHeaderCreated.Name = "panelHeaderCreated";
            panelHeaderCreated.Size = new Size(207, 75);
            panelHeaderCreated.TabIndex = 25;
            // 
            // labelTitulo_Criadas
            // 
            labelTitulo_Criadas.AutoSize = true;
            labelTitulo_Criadas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo_Criadas.Location = new Point(46, 21);
            labelTitulo_Criadas.Name = "labelTitulo_Criadas";
            labelTitulo_Criadas.Size = new Size(118, 32);
            labelTitulo_Criadas.TabIndex = 2;
            labelTitulo_Criadas.Text = "CRIADAS";
            // 
            // panelTestOnFocus
            // 
            panelTestOnFocus.BackColor = SystemColors.ControlLight;
            panelTestOnFocus.Location = new Point(47, 115);
            panelTestOnFocus.Margin = new Padding(3, 4, 3, 4);
            panelTestOnFocus.Name = "panelTestOnFocus";
            panelTestOnFocus.Size = new Size(1062, 57);
            panelTestOnFocus.TabIndex = 24;
            // 
            // buttonFiltro
            // 
            buttonFiltro.AutoSize = false;
            buttonFiltro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonFiltro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonFiltro.Depth = 0;
            buttonFiltro.HighEmphasis = true;
            buttonFiltro.Icon = null;
            buttonFiltro.Location = new Point(866, 45);
            buttonFiltro.Margin = new Padding(5, 8, 5, 8);
            buttonFiltro.MouseState = MaterialSkin.MouseState.HOVER;
            buttonFiltro.Name = "buttonFiltro";
            buttonFiltro.NoAccentTextColor = Color.Empty;
            buttonFiltro.Size = new Size(86, 48);
            buttonFiltro.TabIndex = 23;
            buttonFiltro.Text = "filtrar";
            buttonFiltro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonFiltro.UseAccentColor = false;
            buttonFiltro.UseVisualStyleBackColor = true;
            // 
            // panelHeaderPrinted
            // 
            panelHeaderPrinted.BackColor = SystemColors.ControlLight;
            panelHeaderPrinted.Controls.Add(labelTitulo_Impressas);
            panelHeaderPrinted.Location = new Point(261, 180);
            panelHeaderPrinted.Margin = new Padding(3, 4, 3, 4);
            panelHeaderPrinted.Name = "panelHeaderPrinted";
            panelHeaderPrinted.Size = new Size(207, 75);
            panelHeaderPrinted.TabIndex = 26;
            // 
            // labelTitulo_Impressas
            // 
            labelTitulo_Impressas.AutoSize = true;
            labelTitulo_Impressas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo_Impressas.Location = new Point(38, 21);
            labelTitulo_Impressas.Name = "labelTitulo_Impressas";
            labelTitulo_Impressas.Size = new Size(145, 32);
            labelTitulo_Impressas.TabIndex = 2;
            labelTitulo_Impressas.Text = "IMPRESSAS";
            // 
            // panelHeaderCorrected
            // 
            panelHeaderCorrected.BackColor = SystemColors.ControlLight;
            panelHeaderCorrected.Controls.Add(labelTitulo_Corrigidas);
            panelHeaderCorrected.Location = new Point(474, 180);
            panelHeaderCorrected.Margin = new Padding(3, 4, 3, 4);
            panelHeaderCorrected.Name = "panelHeaderCorrected";
            panelHeaderCorrected.Size = new Size(207, 75);
            panelHeaderCorrected.TabIndex = 27;
            // 
            // labelTitulo_Corrigidas
            // 
            labelTitulo_Corrigidas.AutoSize = true;
            labelTitulo_Corrigidas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo_Corrigidas.Location = new Point(27, 21);
            labelTitulo_Corrigidas.Name = "labelTitulo_Corrigidas";
            labelTitulo_Corrigidas.Size = new Size(160, 32);
            labelTitulo_Corrigidas.TabIndex = 2;
            labelTitulo_Corrigidas.Text = "CORRIGIDAS";
            // 
            // buttonOrdem
            // 
            buttonOrdem.AutoSize = false;
            buttonOrdem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOrdem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonOrdem.Depth = 0;
            buttonOrdem.HighEmphasis = true;
            buttonOrdem.Icon = null;
            buttonOrdem.Location = new Point(961, 45);
            buttonOrdem.Margin = new Padding(5, 8, 5, 8);
            buttonOrdem.MouseState = MaterialSkin.MouseState.HOVER;
            buttonOrdem.Name = "buttonOrdem";
            buttonOrdem.NoAccentTextColor = Color.Empty;
            buttonOrdem.Size = new Size(146, 48);
            buttonOrdem.TabIndex = 22;
            buttonOrdem.Text = "ordenar por:     ";
            buttonOrdem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonOrdem.UseAccentColor = false;
            buttonOrdem.UseVisualStyleBackColor = true;
            // 
            // panelHeaderOverlay
            // 
            panelHeaderOverlay.BackColor = SystemColors.ControlLight;
            panelHeaderOverlay.Controls.Add(labelTitulo_Sobrescritas);
            panelHeaderOverlay.Location = new Point(688, 180);
            panelHeaderOverlay.Margin = new Padding(3, 4, 3, 4);
            panelHeaderOverlay.Name = "panelHeaderOverlay";
            panelHeaderOverlay.Size = new Size(207, 75);
            panelHeaderOverlay.TabIndex = 28;
            // 
            // labelTitulo_Sobrescritas
            // 
            labelTitulo_Sobrescritas.AutoSize = true;
            labelTitulo_Sobrescritas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo_Sobrescritas.Location = new Point(12, 21);
            labelTitulo_Sobrescritas.Name = "labelTitulo_Sobrescritas";
            labelTitulo_Sobrescritas.Size = new Size(183, 32);
            labelTitulo_Sobrescritas.TabIndex = 2;
            labelTitulo_Sobrescritas.Text = "SOBRESCRITAS";
            labelTitulo_Sobrescritas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitulo_Devolvidas
            // 
            labelTitulo_Devolvidas.AutoSize = true;
            labelTitulo_Devolvidas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo_Devolvidas.Location = new Point(29, 21);
            labelTitulo_Devolvidas.Name = "labelTitulo_Devolvidas";
            labelTitulo_Devolvidas.Size = new Size(162, 32);
            labelTitulo_Devolvidas.TabIndex = 2;
            labelTitulo_Devolvidas.Text = "DEVOLVIDAS";
            // 
            // flowpanelLista_Sobrescritas
            // 
            flowpanelLista_Sobrescritas.AutoScroll = true;
            flowpanelLista_Sobrescritas.BackColor = SystemColors.ControlLightLight;
            flowpanelLista_Sobrescritas.FlowDirection = FlowDirection.TopDown;
            flowpanelLista_Sobrescritas.Location = new Point(688, 252);
            flowpanelLista_Sobrescritas.Margin = new Padding(3, 4, 3, 4);
            flowpanelLista_Sobrescritas.Name = "flowpanelLista_Sobrescritas";
            flowpanelLista_Sobrescritas.Size = new Size(207, 421);
            flowpanelLista_Sobrescritas.TabIndex = 33;
            // 
            // flowpanelLista_Corrigidas
            // 
            flowpanelLista_Corrigidas.AutoScroll = true;
            flowpanelLista_Corrigidas.BackColor = SystemColors.ControlLightLight;
            flowpanelLista_Corrigidas.FlowDirection = FlowDirection.TopDown;
            flowpanelLista_Corrigidas.Location = new Point(474, 252);
            flowpanelLista_Corrigidas.Margin = new Padding(3, 4, 3, 4);
            flowpanelLista_Corrigidas.Name = "flowpanelLista_Corrigidas";
            flowpanelLista_Corrigidas.Size = new Size(207, 421);
            flowpanelLista_Corrigidas.TabIndex = 32;
            // 
            // flowpanelLista_Impressas
            // 
            flowpanelLista_Impressas.AutoScroll = true;
            flowpanelLista_Impressas.BackColor = SystemColors.ControlLightLight;
            flowpanelLista_Impressas.FlowDirection = FlowDirection.TopDown;
            flowpanelLista_Impressas.Location = new Point(261, 252);
            flowpanelLista_Impressas.Margin = new Padding(3, 4, 3, 4);
            flowpanelLista_Impressas.Name = "flowpanelLista_Impressas";
            flowpanelLista_Impressas.Size = new Size(207, 421);
            flowpanelLista_Impressas.TabIndex = 31;
            // 
            // flowpanelLista_Criadas
            // 
            flowpanelLista_Criadas.AutoScroll = true;
            flowpanelLista_Criadas.BackColor = SystemColors.ControlLightLight;
            flowpanelLista_Criadas.FlowDirection = FlowDirection.TopDown;
            flowpanelLista_Criadas.Location = new Point(47, 252);
            flowpanelLista_Criadas.Margin = new Padding(3, 4, 3, 4);
            flowpanelLista_Criadas.Name = "flowpanelLista_Criadas";
            flowpanelLista_Criadas.Size = new Size(207, 421);
            flowpanelLista_Criadas.TabIndex = 30;
            // 
            // panelHeaderResponded
            // 
            panelHeaderResponded.BackColor = SystemColors.ControlLight;
            panelHeaderResponded.Controls.Add(labelTitulo_Devolvidas);
            panelHeaderResponded.Location = new Point(902, 180);
            panelHeaderResponded.Margin = new Padding(3, 4, 3, 4);
            panelHeaderResponded.Name = "panelHeaderResponded";
            panelHeaderResponded.Size = new Size(207, 75);
            panelHeaderResponded.TabIndex = 29;
            // 
            // flowpanelLista_Devolvidas
            // 
            flowpanelLista_Devolvidas.AutoScroll = true;
            flowpanelLista_Devolvidas.BackColor = SystemColors.ControlLightLight;
            flowpanelLista_Devolvidas.FlowDirection = FlowDirection.TopDown;
            flowpanelLista_Devolvidas.Location = new Point(902, 252);
            flowpanelLista_Devolvidas.Margin = new Padding(3, 4, 3, 4);
            flowpanelLista_Devolvidas.Name = "flowpanelLista_Devolvidas";
            flowpanelLista_Devolvidas.Size = new Size(207, 421);
            flowpanelLista_Devolvidas.TabIndex = 34;
            // 
            // buttonConfigScreen
            // 
            buttonConfigScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonConfigScreen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonConfigScreen.Depth = 0;
            buttonConfigScreen.HighEmphasis = true;
            buttonConfigScreen.Icon = null;
            buttonConfigScreen.Location = new Point(35, 35);
            buttonConfigScreen.Margin = new Padding(4, 6, 4, 6);
            buttonConfigScreen.MouseState = MaterialSkin.MouseState.HOVER;
            buttonConfigScreen.Name = "buttonConfigScreen";
            buttonConfigScreen.NoAccentTextColor = Color.Empty;
            buttonConfigScreen.Size = new Size(140, 36);
            buttonConfigScreen.TabIndex = 37;
            buttonConfigScreen.Text = "CONFIGURAÇÕES";
            buttonConfigScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonConfigScreen.UseAccentColor = false;
            buttonConfigScreen.UseVisualStyleBackColor = true;
            // 
            // StarterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonConfigScreen);
            Controls.Add(buttonOrdem);
            Controls.Add(buttonFiltro);
            Controls.Add(panelTestOnFocus);
            Controls.Add(panelHeaderCreated);
            Controls.Add(panelHeaderPrinted);
            Controls.Add(panelHeaderCorrected);
            Controls.Add(panelHeaderOverlay);
            Controls.Add(panelHeaderResponded);
            Controls.Add(flowpanelLista_Criadas);
            Controls.Add(flowpanelLista_Impressas);
            Controls.Add(flowpanelLista_Corrigidas);
            Controls.Add(flowpanelLista_Sobrescritas);
            Controls.Add(flowpanelLista_Devolvidas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StarterScreen";
            Size = new Size(1155, 740);
            Load += telaInicial_Load;
            panelHeaderCreated.ResumeLayout(false);
            panelHeaderCreated.PerformLayout();
            panelHeaderPrinted.ResumeLayout(false);
            panelHeaderPrinted.PerformLayout();
            panelHeaderCorrected.ResumeLayout(false);
            panelHeaderCorrected.PerformLayout();
            panelHeaderOverlay.ResumeLayout(false);
            panelHeaderOverlay.PerformLayout();
            panelHeaderResponded.ResumeLayout(false);
            panelHeaderResponded.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTestOnFocus;
        private Label labelTitulo_Criadas;
        private Label labelTitulo_Impressas;
        private Label labelTitulo_Corrigidas;
        private Label labelTitulo_Sobrescritas;
        private Label labelTitulo_Devolvidas;
        private MaterialSkin.Controls.MaterialButton buttonFiltro;
        private Panel panelHeaderCreated;
        private Panel panelHeaderPrinted;
        private Panel panelHeaderCorrected;
        private Panel panelHeaderOverlay;
        private Panel panelHeaderResponded;
        private MaterialSkin.Controls.MaterialButton buttonOrdem;
        private FlowLayoutPanel flowpanelLista_Criadas;
        private FlowLayoutPanel flowpanelLista_Impressas;
        private FlowLayoutPanel flowpanelLista_Corrigidas;
        private FlowLayoutPanel flowpanelLista_Sobrescritas;
        private FlowLayoutPanel flowpanelLista_Devolvidas;
        private MaterialSkin.Controls.MaterialButton buttonConfigScreen;
    }
}
