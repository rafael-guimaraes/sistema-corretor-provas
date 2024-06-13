using Newtonsoft.Json.Linq;
using PdfiumViewer;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace desktop.Telas
{
    public partial class PrintScreen : UserControl
    {
        String prova, arquivo;
        public PrintScreen()
        {
            InitializeComponent();
        }

        public event EventHandler gotoStarterScreen
        {
            add { buttonStarterScreen.Click += value; }
            remove { buttonStarterScreen.Click -= value; }
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject response = JObject.Parse(e.Data);
            string task = response["task"].ToString();
            switch (task)
            {
                case "getListas":
                    
                    break;
                case "deleteListByID":
                    break;
            }
        }
        private void PrintScreen_Load(object sender, EventArgs e)
        {
            if (main.LOCAL.TryGetValue("prova", out string p) && main.LOCAL.TryGetValue("arquivo", out string a))
            {
                prova = p;
                arquivo = a;
                main.LOCAL.Clear();
            }
            byte[] pdfBytes = Convert.FromBase64String(arquivo);
            MemoryStream pdfStream = new MemoryStream(pdfBytes);

            PdfDocument pdfDocument = PdfDocument.Load(pdfStream);
            PdfViewer pdf = new PdfViewer();
            pdf.Size = panel.Size;
            pdf.Document = pdfDocument;
            panel.Controls.Clear();
            panel.Controls.Add(pdf);

        }
    }
}
