using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
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
    public partial class listaBarra : UserControl
    {

        String fundo = "50, 65, 72";
        private int id_lista;

        MaterialSkinManager materialSkinManager;

        public listaBarra(JObject lista)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey900,
                                                              Accent.Cyan700,
                                                              TextShade.WHITE);
            tituloLista.Text = lista["titulo"].ToString();
            id_lista = int.Parse(lista["ID"].ToString());
        }

        private void btnDeletarLista_Click(object sender, EventArgs e)
        {

        }

        private void radio_btnSelecionarLista_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btnSelecionarLista.Checked)
            {

            }
            else
            {

            }
        }
    }
}
