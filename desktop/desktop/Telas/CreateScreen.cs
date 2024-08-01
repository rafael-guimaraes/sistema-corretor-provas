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
using desktop.Componentes;
using System.Collections;

namespace desktop
{
    public partial class CreateScreen : UserControl
    {

        SocketAPI socket = new SocketAPI("Provas");

        String[] categoriaIndex = { "REGULAR", "SUBSTITUTIVA", "RECUPERAÇÃO", "EXAME" };
        String[] disciplinaIndex = { "Matemática FGB 1", "Matemática FGB 2", "Matemática AP" };
        String[] periodoIndex = { "1", "2", "3", "4", "GERAL" };
        String lista;
        String rota;
        public CreateScreen()
        {
            InitializeComponent();
        }

        public event EventHandler gotoListScreen
        {
            add { buttonListScreen.Click += value; }
            remove { buttonListScreen.Click -= value; }
        }

        public event EventHandler gotoStarterScreen;



        private void criarProva_Load(object sender, EventArgs e)
        {
            if (main.LOCAL.TryGetValue("lista", out String objeto))
            {
                lista = objeto;
                main.LOCAL.Clear();
            }
            buttonCreateTest.Enabled = false;
            comboboxTestType.Items.AddRange(categoriaIndex);
            comboboxTestSubject.Items.AddRange(disciplinaIndex);
            comboboxTestPeriod.Items.AddRange(periodoIndex);
            comboboxTestType.SelectedIndex = 0;
            comboboxTestSubject.SelectedIndex = 0;
            comboboxTestPeriod.SelectedIndex = 0;
            main.Socket.OnMessage += OnResponse;

        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject response = JObject.Parse(e.Data);
            string task = response["task"].ToString();
            JObject data;

            switch (task)
            {
                case "updateProgress.createProva": 
                    data = JObject.Parse(response["data"].ToString());
                    int total = int.Parse(data["total"].ToString());
                    int progress = int.Parse(data["progress"].ToString());

                    Componentes.ProgressBar progressBar = new Componentes.ProgressBar((int) panelTestPreview.Size.Width, (int) panelTestPreview.Size.Height);
                    if (panelTestPreview.InvokeRequired)
                    {
                        panelTestPreview.Invoke((MethodInvoker)delegate
                        {
                            panelTestPreview.Controls.Clear();
                            panelTestPreview.Controls.Add(progressBar);
                            progressBar.updateValue(total, progress);
                        });
                    }
                    else
                    {
                        progressBar.updateValue(total, progress);
                        MessageBox.Show("Não");
                    }
                    break;
                case "createExemplo":
                    data = JObject.Parse(response["data"].ToString());
                   
                    String base64 = data["documento"].ToString();
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
                            buttonCreateTest.Enabled = true;
                        });
                    }
                    else
                    {
                        panelTestPreview.Controls.Clear();
                        panelTestPreview.Controls.Add(pdf);
                        buttonCreateTest.Enabled = true;
                    }
                    
                    
                    break;
                case "createProva":
                    main.Socket.OnMessage -= OnResponse;
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            gotoStarterScreen?.Invoke(this, EventArgs.Empty);
                        });
                    }
                    else
                    {
                        gotoStarterScreen?.Invoke(this, EventArgs.Empty);
                    }
                    break;
            }
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rota = openFileDialog1.FileName;
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
                    lista = lista,
                    colunas = colunas,
                    dados = dados
                };

                string json = JsonConvert.SerializeObject(info, Formatting.Indented);
                main.Request(socket.Context("Provas").Task("createExemplo").Body(json));

                
            }

        }

        private void buttonCreateTest_Click(object sender, EventArgs e)
        {
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
                lista = lista,
                colunas = colunas,
                dados = dados
            };

            string json = JsonConvert.SerializeObject(info, Formatting.Indented);
            main.Request(socket.Context("Provas").Task("createProva").Body(json));
        }

        private void panelTestPreview_Paint(object sender, PaintEventArgs e)
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
