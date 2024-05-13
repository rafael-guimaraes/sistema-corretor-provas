using MaterialSkin;
using MaterialSkin.Controls;
using Siticone;
using Siticone.Desktop.UI;
using Newtonsoft.Json.Linq;
using WebSocketSharp;
using System.ComponentModel;
using desktop.Telas;
using System.Windows.Forms;


namespace desktop

{
    public partial class main : MaterialForm
    {
        MaterialSkinManager materialSkinManager;

        //WebSocket Config
        private static WebSocket socket;
        public static WebSocket Socket { get { return socket; } }
        private const string URL = "127.0.0.1";
        private const int PORT = 5000;

        //API
        private JObject request;
        private string tela_atual;

        public main()
        {
            InitializeComponent();
        }

        private void OnResponse(string response)
        {

        }

        private void WebSocketConnection()
        {
            socket = new WebSocket("ws://" + URL + ":" + PORT);
            socket.Connect();
            socket.OnMessage += (s, e) => OnResponse(e.Data);
        }
        public static void Request(JObject request)
        {
            int strike = 0;
            while (!socket.IsAlive && strike < 2)
            {
                socket.Connect();
                strike++;
            }
            if (socket.IsAlive) socket.Send(request.ToString());
            else MessageBox.Show("Não foi possível conectar com o serviço", "ERRO");
        }

        public void switchScreen(string screen)
        {
            activeScreen.Controls.Clear();

            switch (screen)
            {
                case "menu":
                    loadStarterScreen();
                    break;
                case "config":
                    loadConfigScreen();
                    break;
                case "list":
                    loadListScreen();
                    break;
                case "new_list":
                    loadNewListScreen();
                    break;
                case "create":
                    loadCreateScreen();
                    break;
                case "print":
                    loadPrintScreen();
                    break;
                case "correct":
                    loadCorrectScreen();
                    break;
                case "overlay":
                    loadOverlayScreen();
                    break;
                case "export":
                    loadExportScreen();
                    break;

                default:
                    MessageBox.Show(screen, "This screen does NOT EXISTS!");
                    break;


            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                                Primary.BlueGrey900,
                                                                Primary.BlueGrey900,
                                                                Accent.Cyan700,
                                                                TextShade.WHITE);
            WebSocketConnection();
            switchScreen("menu");
        }


        private void loadStarterScreen()
        {
            StarterScreen screen = new StarterScreen();
            screen.gotoListScreen += (sender, args) => switchScreen("list");
            screen.gotoConfig += (sender, args) => switchScreen("config");
            /*
            screen.gotoPrint += (sender, args) => switchScreen("print");
            screen.gotoCorrect += (sender, args) => switchScreen("correct");
            screen.gotoOverlay += (sender, args) => switchScreen("overlay");
            screen.gotoExport += (sender, args) => switchScreen("export");
            */
            Text = "PAINEL DE MONITORAMENTO DE AVALIAÇÕES";

            activeScreen.Controls.Add(screen);
            return;
        }

        private void loadConfigScreen()
        {
            ConfigScreen screen = new ConfigScreen();

            screen.gotoStarterScreen += (sender, args) => switchScreen("menu");

            Text = "CONFIGURAÇÕES DO SISTEMA";

            activeScreen.Controls.Add(screen);
            return;
        }
        private void loadListScreen()
        {
            ListScreen screen = new ListScreen();
            screen.gotoStarterScreen += (sender, args) => switchScreen("menu");
            screen.gotoCreateScreen += (sender, args) => switchScreen("create");
            screen.gotoNewListScreen += (sender, args) => switchScreen("new_list");

            Text = "LISTAS DE CHAMADA";

            activeScreen.Controls.Add(screen);
            return;
        }

        private void loadNewListScreen()
        {
            NewListScreen screen = new NewListScreen();
            screen.gotoListScreen += (sender, args) => switchScreen("list");

            Text = "CRIAR LISTA DE CHAMADA";

            activeScreen.Controls.Add(screen);
            return;

        }
        private void loadCreateScreen()
        {
            CreateScreen screen = new CreateScreen();

            screen.gotoListScreen += (sender, args) => switchScreen("list");

            Text = "CRIAÇÃO DE AVALIAÇÃO";

            activeScreen.Controls.Add(screen);
            return;
        }
        private void loadPrintScreen()
        {
            PrintScreen screen = new PrintScreen();

            screen.gotoStarterScreen += (sender, args) => switchScreen("main");

            Text = "IMPRIMIR AVALIAÇÃO";

            activeScreen.Controls.Add(screen);
            return;
        }
        private void loadCorrectScreen()
        {
            CorrectScreen screen = new CorrectScreen();

            screen.gotoStarterScreen += (sender, args) => switchScreen("main");

            Text = "CORREÇÃO DE AVALIAÇÃO";

            activeScreen.Controls.Add(screen);
            return;
        }
        private void loadOverlayScreen()
        {
            OverlayScreen screen = new OverlayScreen();

            screen.gotoStarterScreen += (sender, args) => switchScreen("main");

            Text = "IMPRIMIR RESULTADOS DA AVALIAÇÃO";

            activeScreen.Controls.Add(screen);
            return;
        }
        private void loadExportScreen()
        {
            ExportScreen screen = new ExportScreen();

            screen.gotoStarterScreen += (sender, args) => switchScreen("main");

            Text = "EXPORTAR DADOS DA AVALIAÇÃO";

            activeScreen.Controls.Add(screen);
            return;
        }
    }
}
