using Microsoft.VisualBasic;
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
using WebSocketSharp;

namespace desktop
{
    public partial class ListScreen : UserControl
    {

        SocketAPI socket = new SocketAPI("Listas");
        public ListScreen()
        {
            InitializeComponent();
        }
        public event EventHandler gotoStarterScreen
        { add { buttonStarterScreen.Click += value; } remove { buttonStarterScreen.Click -= value; } }

        public event EventHandler gotoCreateScreen
        { add { buttonCreateScreen.Click += value; } remove { buttonCreateScreen.Click -= value; } }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Data);
            JObject response = JObject.Parse(e.Data);
            MessageBox.Show(response["task"].ToString());
            MessageBox.Show(response["data"].ToString());
            JArray listas = JArray.Parse(response["data"].ToString());
            foreach (JObject item in listas)
            { 
                if (panelTabela_Listas.InvokeRequired)
                {
                    panelTabela_Listas.Invoke((MethodInvoker)delegate {
                        itemLista lista = new itemLista(item);
                        panelTabela_Listas.Controls.Add(lista);
                    });
                }
                else
                {
                    itemLista lista = new itemLista(item);
                    panelTabela_Listas.Controls.Add(lista);
                }
            }
        }

        private void panelTela_Lista_Chamada_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListScreen_Load(object sender, EventArgs e)
        {
            main.Socket.OnMessage += OnResponse;
            main.Request(socket.Task("getListas").Body());
            buttonCreateScreen.Click += (s, e) => { main.Socket.OnMessage -= OnResponse; };
            buttonNewListScreen.Click += (s, e) => { main.Socket.OnMessage -= OnResponse; };
        }
    }
}
