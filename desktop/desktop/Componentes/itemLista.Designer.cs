namespace desktop
{
    partial class itemLista
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
            buttonEditList = new Button();
            buttonDeleteList = new Button();
            checkListItem = new CheckBox();
            SuspendLayout();
            // 
            // buttonEditList
            // 
            buttonEditList.Location = new Point(656, 4);
            buttonEditList.Margin = new Padding(3, 4, 3, 4);
            buttonEditList.Name = "buttonEditList";
            buttonEditList.Size = new Size(47, 49);
            buttonEditList.TabIndex = 1;
            buttonEditList.UseVisualStyleBackColor = true;
            buttonEditList.Click += buttonEditList_Click;
            // 
            // buttonDeleteList
            // 
            buttonDeleteList.Location = new Point(710, 4);
            buttonDeleteList.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteList.Name = "buttonDeleteList";
            buttonDeleteList.Size = new Size(47, 49);
            buttonDeleteList.TabIndex = 2;
            buttonDeleteList.UseVisualStyleBackColor = true;
            buttonDeleteList.Click += buttonDeleteList_Click;
            // 
            // checkListItem
            // 
            checkListItem.AutoSize = true;
            checkListItem.Font = new Font("Segoe UI", 18F);
            checkListItem.ForeColor = SystemColors.Control;
            checkListItem.Location = new Point(16, 8);
            checkListItem.Name = "checkListItem";
            checkListItem.Size = new Size(133, 45);
            checkListItem.TabIndex = 5;
            checkListItem.Text = "listTitle";
            checkListItem.UseVisualStyleBackColor = true;
            // 
            // itemLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 109, 117);
            Controls.Add(checkListItem);
            Controls.Add(buttonDeleteList);
            Controls.Add(buttonEditList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "itemLista";
            Size = new Size(761, 56);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEditList;
        private Button buttonDeleteList;
        private CheckBox checkListItem;
    }
}
