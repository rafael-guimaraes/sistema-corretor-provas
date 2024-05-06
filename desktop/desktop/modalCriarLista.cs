using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace desktop
{
    public partial class modalCriarLista : MaterialForm
    {
        MaterialSkinManager materialSkinManager;

        Color cinzaEscuro = Color.DarkGray;
        private SocketAPI socket;
        private JArray alunos = new JArray();


        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject payload = JObject.Parse(e.Data);
            JObject aluno = JObject.Parse(payload["body"].ToString()); // {"nome":"Kaio","matricula":50220384}
            alunos.Add(aluno);

            carregarAlunos();
            MessageBox.Show(aluno.ToString());
        }
        private void carregarAlunos()
        {
            // [{"nome":"Kaio","matricula":50220384}]
        }
        public modalCriarLista()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey900,
                                                              Accent.Cyan700,
                                                              TextShade.WHITE);
            socket = new SocketAPI();
        }

        public void setPosition(int eixoX, int eixoY)
        {
            Location = new Point(eixoX, eixoY);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Form1.Request(socket.post().Listas(/*Alunos*/,textBox1.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Request(socket.get().Alunos(textBox2.Text));
        }

        private void modalCriarLista_Load(object sender, EventArgs e)
        {
            Form1.Socket.OnMessage += OnResponse;
            MessageBox.Show("Carregou aqui");
            button2.Click += (s, e) =>
            {
                Form1.Socket.OnMessage -= OnResponse;
            };
        }

        public event EventHandler criarProva
        {
            add
            {
                button1.Click += value;
            }

            remove
            {
                button1.Click -= value;
            }
        }
    }
}
