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
    public partial class criarProva : UserControl
    {

        Color cinza = Color.Gray;
        String[] categoriaIndex = { "REGULAR", "SUBSTITUTIVA", "RECUPERAÇÃO", "EXAME" };
        String[] disciplinaIndex = { "Matemática FGB 1", "Matemática FGB 2", "Matemática AP" };
        String[] periodoIndex = { "1", "2", "3", "4", "GERAL" };
        public criarProva()
        {
            InitializeComponent();
            
            setColor();
        }

        private void setColor()
        {
            panel3.BackColor = cinza;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // importar modelo docx da prova

        }

        private void criarProva_Load(object sender, EventArgs e)
        {
            materialComboBox1.Items.AddRange(categoriaIndex);
            materialComboBox2.Items.AddRange(disciplinaIndex);
            materialComboBox3.Items.AddRange(periodoIndex);
            Form1.Socket.OnMessage += OnResponse;
            materialButton3.Click += (s, e) =>
            {
                Form1.Socket.OnMessage -= OnResponse;
            };
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            MessageBox.Show("AQUI ESTA NA TELA CRIAR PROVA" + e.Data);
        }
        public event EventHandler voltarInicio
        {
            add
            {
                materialButton3.Click += value;
            }

            remove
            {
                materialButton3.Click -= value;
            }
        }
    }
}
