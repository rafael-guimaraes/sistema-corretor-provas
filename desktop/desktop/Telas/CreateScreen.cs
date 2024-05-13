using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace desktop
{
    public partial class CreateScreen : UserControl
    {

        String[] categoriaIndex = { "REGULAR", "SUBSTITUTIVA", "RECUPERAÇÃO", "EXAME" };
        String[] disciplinaIndex = { "Matemática FGB 1", "Matemática FGB 2", "Matemática AP" };
        String[] periodoIndex = { "1", "2", "3", "4", "GERAL" };
        public CreateScreen()
        {
            InitializeComponent();
        }

        public event EventHandler gotoListScreen
        {
            add { buttonListScreen.Click += value; } remove { buttonListScreen.Click -= value; }
        }


        private void criarProva_Load(object sender, EventArgs e)
        {
            comboboxTestType.Items.AddRange(categoriaIndex);
            comboboxTestSubject.Items.AddRange(disciplinaIndex);
            comboboxTestPeriod.Items.AddRange(periodoIndex);
            main.Socket.OnMessage += OnResponse;
            buttonCreateTest.Click += (s, e) =>
            {
                main.Socket.OnMessage -= OnResponse;
            };
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            MessageBox.Show("AQUI ESTA NA TELA CRIAR PROVA" + e.Data);
        }

        

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler voltarInicio
        {
            add
            {
                buttonCreateTest.Click += value;
            }

            remove
            {
                buttonCreateTest.Click -= value;
            }
        }
    }
}
