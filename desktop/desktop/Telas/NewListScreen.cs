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

namespace desktop.Telas
{
    public partial class NewListScreen : UserControl
    {
        private string filePath;
        SocketAPI socket = new SocketAPI("Config");
        public NewListScreen()
        {
            InitializeComponent();
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject response = JObject.Parse(e.Data);
            string task = response["task"].ToString();
            switch (task)
            {
                case "importListFile":
                    MessageBox.Show(response["data"].ToString(),"NOVA LISTA");
                    break;
                case "getAlunosByID":
                    // Adicionar ao panelListAlunos um componente contendo MATRICULA + NOME

                    string matricula = response["data"]["matricula"].ToString();
                    string aluno = response["data"]["nome"].ToString();

                    MessageBox.Show(aluno, matricula);
                    break;
            }


            string data = response["task"].ToString();
        }

        public event EventHandler gotoListScreen
        { add { buttonListScreen.Click += value; } remove { buttonListScreen.Click -= value; } }
        private void NewListScreen_Load(object sender, EventArgs e)
        {
            main.Socket.OnMessage += OnResponse;

            buttonImportFile.AutoSizeMode = AutoSizeMode.GrowOnly;
            buttonImportFile.Size = new Size(324, 52);
            buttonImportFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            buttonImportFile.Enabled = false;

            buttonSelectFile.AutoSizeMode = AutoSizeMode.GrowOnly;
            buttonSelectFile.Size = new Size(324, 52);
        }

        private void buttonListScreen_Click(object sender, EventArgs e)
        {
            main.Socket.OnMessage -= OnResponse;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;


                labelSelectedFile.Text = "Arquivo selecionado: " + Path.GetFileName(filePath); ;
                buttonImportFile.Enabled = true;
                buttonImportFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                buttonSelectFile.Text = "ALTERAR ARQUIVO";

            }
            else
            {
                MessageBox.Show("Nenhum arquivo selecionado!", "Erro");

                labelSelectedFile.Text = "Nenhum arquivo selecionado.";
                buttonImportFile.Enabled = false;
                buttonImportFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
                buttonSelectFile.Text = "SELECIONAR ARQUIVO";
            }
        }

        private void buttonImportFile_Click(object sender, EventArgs e)
        {
            main.Request(socket.Context("Config").Task("importListFile").Body(filePath));
            buttonImportFile.Enabled = false;
        }

        private void textBoxInsertMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if(textBoxInsertMatricula.Text.Length == 8)
                    {
                        int int_matricula = int.Parse(textBoxInsertMatricula.Text);
                        main.Request(socket.Context("Alunos").Task("getAlunosByID").Body(textBoxInsertMatricula.Text));
                    }
                    else
                        MessageBox.Show(textBoxInsertMatricula.Text + " não é uma matrícula válida (len)", "ERRO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(textBoxInsertMatricula.Text + " não é uma matrícula válida ("+ ex.ToString() + ")", "ERRO");
                }
            }            
        }
    }
}
