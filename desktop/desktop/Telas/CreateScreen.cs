using Newtonsoft.Json;
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
using PdfiumViewer;

namespace desktop
{
    public partial class CreateScreen : UserControl
    {
        
        SocketAPI socket = new SocketAPI("Provas");

        String[] categoriaIndex = { "REGULAR", "SUBSTITUTIVA", "RECUPERAÇÃO", "EXAME" };
        String[] disciplinaIndex = { "Matemática FGB 1", "Matemática FGB 2", "Matemática AP" };
        String[] periodoIndex = { "1", "2", "3", "4", "GERAL" };
        public CreateScreen()
        {
            InitializeComponent();
        }

        public event EventHandler gotoListScreen
        {
            add { buttonListScreen.Click += value; }
            remove { buttonListScreen.Click -= value; }
        }


        private void criarProva_Load(object sender, EventArgs e)
        {
            comboboxTestType.Items.AddRange(categoriaIndex);
            comboboxTestSubject.Items.AddRange(disciplinaIndex);
            comboboxTestPeriod.Items.AddRange(periodoIndex);
            comboboxTestType.SelectedIndex = 0;
            comboboxTestSubject.SelectedIndex = 0;
            comboboxTestPeriod.SelectedIndex = 0;
            main.Socket.OnMessage += OnResponse;
            buttonCreateTest.Click += (s, e) =>
            {
                main.Socket.OnMessage -= OnResponse;
            };
            
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject response = JObject.Parse(e.Data);
            string task = response["task"].ToString();
            JObject data = JObject.Parse(response["data"].ToString());
            String base64 = data["documento"].ToString();
            base64 = base64.Substring(2, base64.Length - 3);
            byte[] pdfBytes = Convert.FromBase64String(base64);
            MemoryStream pdfStream = new MemoryStream(pdfBytes);
                
            PdfDocument pdfDocument = PdfDocument.Load(pdfStream);
            PdfiumViewer.PdfViewer pdf = new PdfViewer();
            pdf.Document = pdfDocument;
            if (panelTestPreview.InvokeRequired)
            {

                panelTestPreview.Invoke((MethodInvoker)delegate
                {
                     panelTestPreview.Controls.Clear();
                     panelTestPreview.Controls.Add(pdf);
                });
            }
            else {
                panelTestPreview.Controls.Clear();
                panelTestPreview.Controls.Add(pdf);
            }
                


        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rota = openFileDialog1.FileName;
                string tipo = comboboxTestType.Text;
                string disciplina = comboboxTestSubject.Text;
                string bimestre = comboboxTestPeriod.Text;
                int colunas = toggleColumns.CheckState == CheckState.Checked ? 2 : 1;
                var dados = new
                {
                    disciplina = disciplina,
                    tipo = tipo,
                    bimestre = bimestre
                };
                var info = new
                {
                    arquivo = rota,
                    lista = "665d4134b6c63184eb1a08cf",
                    colunas = colunas,
                    dados = dados
                };

                string json = JsonConvert.SerializeObject(info, Formatting.Indented);
                main.Request(socket.Context("Provas").Task("createExemplo").Body(json));
                
                MessageBox.Show(json);
            }
            
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
