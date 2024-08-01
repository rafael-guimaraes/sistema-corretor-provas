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
        private JArray staticList;
        SocketAPI socket = new SocketAPI("Provas");
        MaterialButton buttonListScreen;
        public event EventHandler gotoPrint;
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
            main.Request(socket.Task("getProvas").Body("{}"));
        }

        private void Button_Click(object sender, EventArgs e, string id_prova, string arquivo)
        {
            main.Socket.OnMessage -= OnResponse;
            main.LOCAL.Add("prova", id_prova);
            main.LOCAL.Add("arquivo", arquivo);
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    gotoPrint?.Invoke(this, EventArgs.Empty);
                });
            }
            else
            {
                gotoPrint?.Invoke(this, EventArgs.Empty);
            }
        }

        private void loadProvasItems()
        {
            if (flowpanelLista_Criadas.InvokeRequired)
                flowpanelLista_Criadas.Invoke((MethodInvoker)delegate
                {
                    flowpanelLista_Criadas.Controls.Clear();
                    flowpanelLista_Criadas.Controls.Add(buttonListScreen);
                });
            else
            {
                flowpanelLista_Criadas.Controls.Clear();
                flowpanelLista_Criadas.Controls.Add(buttonListScreen);
            }
                

            
            foreach (JObject item in staticList)
            {
                string title = item["nome"].ToString();
                string id = item["_id"].ToString();
                string arquivo = item["arquivo"].ToString();

                if (flowpanelLista_Criadas.InvokeRequired)
                {
                    flowpanelLista_Criadas.Invoke((MethodInvoker)delegate
                    {
                        MaterialButton button = new MaterialButton();
                        button.Text = title;
                        button.Font = new Font(button.Font.FontFamily, 4);
                        button.Size = new Size(flowpanelLista_Criadas.Width - 10, 60);
                        button.AutoSize = false;
                        button.Click += (sender, e) => Button_Click(sender, e, id, arquivo);
                        flowpanelLista_Criadas.Controls.Add(button);
                   
                    });
                }
                else
                {
                    MaterialButton button = new MaterialButton();
                    button.Text = title;
                    button.Font = new Font(button.Font.FontFamily, 4);
                    button.Size = new Size(flowpanelLista_Criadas.Width - 10, 60);
                    button.AutoSize = false;
                    button.Click += (sender, e) => Button_Click(sender, e, id, arquivo);
                    flowpanelLista_Criadas.Controls.Add(button);
                }
               
            }
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject response = JObject.Parse(e.Data);
            string task = response["task"].ToString();
            switch (task)
            {
                case "getProvas":
                    staticList = JArray.Parse(response["data"].ToString());
                    loadProvasItems();
                    MessageBox.Show(staticList.ToString());
                    break;
               
            }
        }

    }
}
