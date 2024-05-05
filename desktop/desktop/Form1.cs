using MaterialSkin;
using MaterialSkin.Controls;
using Siticone;
using Siticone.Desktop.UI;
using Newtonsoft.Json.Linq;
using WebSocketSharp;
using System.ComponentModel;


namespace desktop

{
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;

        //WebSocket Config
        private static WebSocket socket;
        private const string URL = "127.0.0.1";
        private const int PORT = 5000;

        //API
        private JObject request;

        private string tela_atual;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnResponse(string response)
        {
                
        }
        public static WebSocket Socket { get { return socket; } }
        
        private void WebSocketConnection()
        {
            socket = new WebSocket("ws://" + URL + ":" + PORT);
            socket.Connect();
            socket.OnMessage += (s, e) => OnResponse(e.Data);
        }

        public static void Request(JObject request)
        {
            socket.Send(request.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                                Primary.BlueGrey900,
                                                                Primary.BlueGrey900,
                                                                Accent.Cyan700,
                                                                TextShade.WHITE);
            WebSocketConnection();
            trocarTela("telaInicial");
        }

        public void trocarTela(String tela)
        {
            panelInicial.Controls.Clear();
            tela_atual = tela;

            switch (tela){
                case "telaInicial":
                    telaInicial inicial = new telaInicial(socket);
                    inicial.criarLista += (s, args) => trocarTela("criarLista");
                    Text = "ACOMPANHAMENTO DAS AVALIAÇÕES";
                    panelInicial.Controls.Add(inicial);

                    break;
                case "criarLista":
                    Listas telaListas = new Listas();
                    telaListas.criarProva += (s, args) => trocarTela("criarProva");

                    Text = "SELECIONAR EXISTENTE";
                    panelInicial.Controls.Add(telaListas);
                    break;
                case "criarProva":
                    criarProva criarP = new criarProva();
                    criarP.voltarInicio += (s, args) => trocarTela("telaInicial");

                    Text = "CRIAR PROVA ";
                    panelInicial.Controls.Add(criarP);
                    break;
            }
        }

    }
}
