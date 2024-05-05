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
        private string id_lista;

        MaterialSkinManager materialSkinManager;
        SocketAPI socket;
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
            id_lista = lista["ID"].ToString();
            socket = new SocketAPI();
        }

        private void btnDeletarLista_Click(object sender, EventArgs e)
        {
            Form1.Request(socket.delete().Listas(id_lista));
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

        private void btnEditarLista_Click(object sender, EventArgs e)
        {

        }
    }
}
