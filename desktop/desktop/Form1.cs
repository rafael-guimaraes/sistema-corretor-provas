using MaterialSkin;
using MaterialSkin.Controls;
using Siticone;
using Siticone.Desktop.UI;
namespace desktop

{
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;

        int contador = 1;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey900,
                                                              Accent.Cyan700,
                                                              TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
