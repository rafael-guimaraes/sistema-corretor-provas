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
    public partial class Listas : UserControl
    {

        public JObject Response;
        private SocketAPI socket;
        public Listas()
        {
            InitializeComponent();
            socket = new SocketAPI();
        }
        private void botaoNova_Lista_Click(object sender, EventArgs e)
        {
            modalCriarLista modal = new modalCriarLista();
            modal.Show();
        }

        private void Listas_Load(object sender, EventArgs e)
        {
            Form1.Request(socket.get().Listas());
            Form1.Socket.OnMessage += OnResponse;
            botaoCriar_Prova.Click += (s, e) =>
            {
                Form1.Socket.OnMessage -= OnResponse;
            };
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject payload = JObject.Parse(e.Data);
            JArray listas = JArray.Parse(payload["body"].ToString());

            foreach (JObject item in listas)
            { 
                if (panelTabela_Listas.InvokeRequired)
                {
                    panelTabela_Listas.Invoke((MethodInvoker)delegate {
                        listaBarra lista = new listaBarra(item);
                        panelTabela_Listas.Controls.Add(lista);
                    });
                }
                else
                {
                    listaBarra lista = new listaBarra(item);
                    panelTabela_Listas.Controls.Add(lista);
                }
            }
        }

        public event EventHandler criarProva
        {
            add
            {
                botaoCriar_Prova.Click += value;
            }

            remove
            {
                botaoCriar_Prova.Click -= value;
            }
        }


    }
}
