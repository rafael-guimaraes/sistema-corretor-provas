using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop
{
    public partial class criarProva : UserControl
    {

        Color cinza = Color.Gray;
        String[] categoriaIndex = { "SUB", "REC", "EXAME" };
        String[] disciplinaIndex = { "Matemática FGB 1", "Matemática FGB 2", "Matemática AP" };
        String[] periodoIndex = { "1", "2", "3", "4", "GERAL" };
        public criarProva()
        {
            InitializeComponent();
            materialComboBox1.Items.AddRange(categoriaIndex);
            materialComboBox2.Items.AddRange(disciplinaIndex);
            materialComboBox3.Items.AddRange(periodoIndex);
            setColor();
        }

        private void setColor()
        {
            panel3.BackColor = cinza;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // importar modelo docx da prova

        }

        public event EventHandler voltarInicio
        {
            add
            {
                materialButton3.Click += value;
            }

            remove
            {
                materialButton3.Click -= value;
            }
        }
    }
}
