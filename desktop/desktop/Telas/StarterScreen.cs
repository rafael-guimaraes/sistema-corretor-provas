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
    public partial class StarterScreen : UserControl
    {
        SocketAPI api;
        WebSocket socket;

        MaterialButton buttonListScreen;

        private void loadButtonListScreen()
        {
            buttonListScreen = new MaterialButton();
            buttonListScreen.Text = "+";
            buttonListScreen.Size = new Size(flowpanelLista_Criadas.Width - 10, 40);
            buttonListScreen.AutoSize = false;

            flowpanelLista_Criadas.Controls.Add(buttonListScreen);
            buttonListScreen.Click += (s, e) => { main.Socket.OnMessage -= OnResponse; };
        }
        public StarterScreen()
        {
            InitializeComponent();
        }
        public event EventHandler gotoListScreen
        {
            add { buttonListScreen.Click += value; } remove { buttonListScreen.Click -= value; }
        }
        public event EventHandler gotoConfig
        {
            add { buttonConfigScreen.Click += value; } remove {  buttonConfigScreen.Click -= value; }
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {
            loadButtonListScreen();
            main.Socket.OnMessage += OnResponse;
            buttonConfigScreen.Click += (s, e) => { main.Socket.OnMessage -= OnResponse; };

        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            MessageBox.Show("AQUI ESTA NA TELA INICAL" + e.Data);
        }

    }
}
