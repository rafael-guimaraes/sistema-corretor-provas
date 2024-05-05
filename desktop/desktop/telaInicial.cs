using MaterialSkin.Controls;
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
using Newtonsoft.Json.Linq;
using Microsoft.Win32;

namespace desktop
{
    public partial class telaInicial : UserControl
    {
        MaterialButton adicionar_prova = new MaterialButton();
        SocketAPI api;
        WebSocket socket;
        public telaInicial(WebSocket socket)
        {
            InitializeComponent();
            this.socket = socket;
        }
        public event EventHandler criarLista

        {
            add
            {
                adicionar_prova.Click += value;
            }

            remove
            {
                adicionar_prova.Click -= value;
            }
        }
        private void telaInicial_Load(object sender, EventArgs e)
        {
            adicionar_prova.Text = "+";
            adicionar_prova.Size = new Size(flowpanelLista_Criadas.Width - 10, 40);
            adicionar_prova.AutoSize = false;
            flowpanelLista_Criadas.Controls.Add(adicionar_prova);
            Form1.Socket.OnMessage += OnResponse;
            adicionar_prova.Click += (s, e) =>
            {
                Form1.Socket.OnMessage -= OnResponse;
            };
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            MessageBox.Show("AQUI ESTA NA TELA INICAL" + e.Data);
        }

    }
}
