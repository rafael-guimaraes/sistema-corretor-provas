using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Enumeration;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.Componentes
{
    public partial class ImportStudents : UserControl
    {
        SocketAPI socket = new SocketAPI("Config");
        private string filePath;
        public ImportStudents()
        {
            InitializeComponent();
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

        private void ImportStudents_Load(object sender, EventArgs e)
        {
            buttonImportFile.Enabled = false;
            buttonImportFile.AutoSizeMode = AutoSizeMode.GrowOnly;
            buttonImportFile.Size = new Size(148, 36);
            buttonImportFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;

            labelSelectedFile.Text = "Nenhum arquivo selecionado.";

            buttonSelectFile.AutoSizeMode = AutoSizeMode.GrowOnly;
            buttonSelectFile.Size = new Size(148, 36);
        }

        private void buttonImportFile_Click(object sender, EventArgs e)
        {
            main.Request(socket.Task("importAlunosFile").Body(filePath));
            buttonImportFile.Enabled = false;
        }

        public void clearData()
        {
            if (listStudentItems.InvokeRequired)
                listStudentItems.Invoke((MethodInvoker)delegate
                {
                    listStudentItems.Controls.Clear();
                });
            else
                listStudentItems.Controls.Clear();
        }
        public void addStudentItem(JObject student)
        {
            if (listStudentItems.InvokeRequired)
            {
                listStudentItems.Invoke((MethodInvoker)delegate
                {
                    itemStudent listItem = new itemStudent(student);
                    listStudentItems.Controls.Add(listItem);
                });
            }
            else
            {
                itemStudent listItem = new itemStudent(student);
                listStudentItems.Controls.Add(listItem);
            }

            if (labelCount.InvokeRequired)
            {
                labelCount.Invoke((MethodInvoker)delegate
                {
                    labelCount.Text = (int.Parse(labelCount.Text) + 1).ToString();
                });
            }
            else
            {
                labelCount.Text = (int.Parse(labelCount.Text)+ 1).ToString();
            }
            
        }

    }
}
