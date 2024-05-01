using MaterialSkin.Controls;
using Newtonsoft.Json;
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
    public partial class telaInicial : UserControl
    {
        MaterialButton adicionar_prova = new MaterialButton();
        
        public telaInicial()
        {
            InitializeComponent();
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
            adicionar_prova.Size = new Size(criadas.Width - 10, 40);
            adicionar_prova.AutoSize = false;
            criadas.Controls.Add(adicionar_prova);
            Form1.websocket.OnMessage += Respostas;
            adicionar_prova.Click += (sender, e) => { Form1.websocket.OnMessage -= Respostas; };
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form1.websocket.Send("a");
        }
        private void Respostas(object sender, MessageEventArgs e)
        {
           MessageBox.Show(e.Data);
        }
    }
}
