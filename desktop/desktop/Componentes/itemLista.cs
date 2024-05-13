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
    public partial class itemLista : UserControl
    {

        String fundo = "50, 65, 72";
        private string id_lista;

        MaterialSkinManager materialSkinManager;
        SocketAPI socket;
        public itemLista(JObject lista)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey900,
                                                              Accent.Cyan700,
                                                              TextShade.WHITE);
            checkListItem.Text = lista["titulo"].ToString();
            id_lista = lista["ID"].ToString();
            socket = new SocketAPI("listas");
        }

        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            main.Request(socket.Task("deleteListByID").Body(id_lista));
        }

        private void buttonEditList_Click(object sender, EventArgs e)
        {

        }
    }
}
