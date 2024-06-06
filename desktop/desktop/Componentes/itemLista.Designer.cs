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
            buttonEditList.Location = new Point(831, 3);
            buttonEditList.Name = "buttonEditList";
            buttonEditList.Size = new Size(41, 37);
            buttonEditList.TabIndex = 1;
            buttonEditList.Text = "Edit";
            buttonEditList.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteList
            // 
            buttonDeleteList.Location = new Point(878, 3);
            buttonDeleteList.Name = "buttonDeleteList";
            buttonDeleteList.Size = new Size(41, 37);
            buttonDeleteList.TabIndex = 2;
            buttonDeleteList.Text = "X";
            buttonDeleteList.UseVisualStyleBackColor = true;
            buttonDeleteList.Click += buttonDeleteList_Click;
            // 
            // checkListItem
            // 
            checkListItem.AutoSize = true;
            checkListItem.Font = new Font("Segoe UI", 18F);
            checkListItem.ForeColor = SystemColors.ActiveCaptionText;
            checkListItem.Location = new Point(14, 6);
            checkListItem.Margin = new Padding(3, 2, 3, 2);
            checkListItem.Name = "checkListItem";
            checkListItem.Size = new Size(109, 36);
            checkListItem.TabIndex = 5;
            checkListItem.Text = "listTitle";
            checkListItem.UseVisualStyleBackColor = true;
            checkListItem.CheckedChanged += checkListItem_CheckedChanged;
            // 
            // itemLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(checkListItem);
            Controls.Add(buttonDeleteList);
            Controls.Add(buttonEditList);
            Name = "itemLista";
            Size = new Size(921, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEditList;
        private Button buttonDeleteList;
        private CheckBox checkListItem;
    }
}
