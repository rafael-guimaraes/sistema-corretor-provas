using Microsoft.VisualBasic;
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
    public partial class Listas : UserControl
    {


        public Listas()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            modalCriarLista modal = new modalCriarLista();
            modal.Show();

        }

        public event EventHandler criarProva
        {
            add
            {
                materialButton2.Click += value;
            }

            remove
            {
                materialButton2.Click -= value;
            }
        }


    }
}
