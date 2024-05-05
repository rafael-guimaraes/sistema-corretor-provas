namespace desktop
{
    partial class listaBarra
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
            btnEditarLista = new Button();
            btnDeletarLista = new Button();
            radio_btnSelecionarLista = new MaterialSkin.Controls.MaterialRadioButton();
            tituloLista = new Label();
            SuspendLayout();
            // 
            // btnEditarLista
            // 
            btnEditarLista.Location = new Point(656, 4);
            btnEditarLista.Margin = new Padding(3, 4, 3, 4);
            btnEditarLista.Name = "btnEditarLista";
            btnEditarLista.Size = new Size(47, 49);
            btnEditarLista.TabIndex = 1;
            btnEditarLista.UseVisualStyleBackColor = true;
            btnEditarLista.Click += btnEditarLista_Click;
            // 
            // btnDeletarLista
            // 
            btnDeletarLista.Location = new Point(710, 4);
            btnDeletarLista.Margin = new Padding(3, 4, 3, 4);
            btnDeletarLista.Name = "btnDeletarLista";
            btnDeletarLista.Size = new Size(47, 49);
            btnDeletarLista.TabIndex = 2;
            btnDeletarLista.UseVisualStyleBackColor = true;
            btnDeletarLista.Click += btnDeletarLista_Click;
            // 
            // radio_btnSelecionarLista
            // 
            radio_btnSelecionarLista.AutoSize = true;
            radio_btnSelecionarLista.Depth = 0;
            radio_btnSelecionarLista.Location = new Point(0, 10);
            radio_btnSelecionarLista.Margin = new Padding(0);
            radio_btnSelecionarLista.MouseLocation = new Point(-1, -1);
            radio_btnSelecionarLista.MouseState = MaterialSkin.MouseState.HOVER;
            radio_btnSelecionarLista.Name = "radio_btnSelecionarLista";
            radio_btnSelecionarLista.Ripple = true;
            radio_btnSelecionarLista.Size = new Size(35, 37);
            radio_btnSelecionarLista.TabIndex = 3;
            radio_btnSelecionarLista.TabStop = true;
            radio_btnSelecionarLista.UseVisualStyleBackColor = true;
            radio_btnSelecionarLista.CheckedChanged += radio_btnSelecionarLista_CheckedChanged;
            // 
            // tituloLista
            // 
            tituloLista.AutoSize = true;
            tituloLista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLista.ForeColor = Color.White;
            tituloLista.Location = new Point(63, 9);
            tituloLista.Name = "tituloLista";
            tituloLista.Size = new Size(115, 32);
            tituloLista.TabIndex = 4;
            tituloLista.Text = "text here";
            // 
            // listaBarra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 109, 117);
            Controls.Add(tituloLista);
            Controls.Add(radio_btnSelecionarLista);
            Controls.Add(btnDeletarLista);
            Controls.Add(btnEditarLista);
            Margin = new Padding(3, 4, 3, 4);
            Name = "listaBarra";
            Size = new Size(761, 56);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditarLista;
        private Button btnDeletarLista;
        private MaterialSkin.Controls.MaterialRadioButton radio_btnSelecionarLista;
        private Label tituloLista;
    }
}
