using MaterialSkin;
using MaterialSkin.Controls;
using Siticone;
using Siticone.Desktop.UI;
using WebSocketSharp;


namespace desktop

{
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        int contador = 1;
        static WebSocket ws;

        public static WebSocket websocket
        {
            get { return ws; }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                                Primary.BlueGrey900,
                                                                Primary.BlueGrey900,
                                                                Accent.Cyan700,
                                                                TextShade.WHITE);
            ws = new WebSocket("ws://localhost:5000");
            ws.Connect();
           
            trocarTela("telaInicial");

        }

       
        
        public void trocarTela(String tela)
        {
            panel1.Controls.Clear();

            telaInicial inicial = new telaInicial();
            inicial.criarLista += (s, args) => trocarTela("criarLista");

            Listas telaListas = new Listas();
            telaListas.criarProva += (s, args) => trocarTela("criarProva");


            criarProva criarP = new criarProva();
            criarP.voltarInicio += (s, args) => trocarTela("telaInicial");
            

            if (tela == "criarLista")
            {
                Text = "SELECIONAR EXISTENTE";
                panel1.Controls.Add(telaListas);

            }
            else if (tela == "criarProva")
            {
                Text = "";
                panel1.Controls.Add(criarP);

            }else if (tela == "telaInicial")
            {
                Text = "ACOMPANHAMENTO DAS AVALIAÇÕES";
                panel1.Controls.Add(inicial);
            }
        }

    }
}
