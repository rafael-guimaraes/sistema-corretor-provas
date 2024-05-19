using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop.Componentes;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace desktop.Telas
{
    public partial class ConfigScreen : UserControl
    {
        public ConfigScreen()
        {
            InitializeComponent();
        }

        private void OnResponse(object sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Data);
            JObject response = JObject.Parse(e.Data);
            string task = response["task"].ToString();

            switch (task)
            {
                case "importAlunosFile":
                    JArray data = JArray.Parse(response["data"].ToString());
                    foreach (JObject item in data)
                    {
                        ImportStudents display = (ImportStudents) panelConfigOption.Controls[0];
                        display.addStudentItem(item);
                    }
                    break;
            }
            MessageBox.Show(response["task"].ToString());
            MessageBox.Show(response["data"].ToString());
        }

        public event EventHandler gotoStarterScreen
        { add { buttonStarterScreen.Click += value; } remove { buttonStarterScreen.Click -= value; } }

        private void disableAllButtons()
        {
            buttonImportStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            buttonImportClasses.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            buttonTranslateOutput.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        }
        private void updateConfigContext(string config_context)
        {
            panelConfigOption.Controls.Clear();

            disableAllButtons();

            switch (config_context)
            {
                case "ImportStudents":
                    buttonImportStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                    ImportStudents import_students_component = new ImportStudents();
                    panelConfigOption.Controls.Add(import_students_component);
                    break;
                case "ImportClasses":
                    buttonImportClasses.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                    ImportClasses import_classes_component = new ImportClasses();
                    panelConfigOption.Controls.Add(import_classes_component);
                    break;
                case "TranslateOutput":
                    buttonTranslateOutput.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                    TranslateOutput translate_output_component = new TranslateOutput();
                    panelConfigOption.Controls.Add(translate_output_component);
                    break;
                default:
                    panelConfigOption.Controls.Clear();
                    break;

            }

        }

        private void loadButtons()
        {
            buttonImportClasses.AutoSizeMode = AutoSizeMode.GrowOnly;
            buttonImportClasses.Size = new Size(214, 56);
            buttonImportStudents.AutoSizeMode = AutoSizeMode.GrowOnly;
            buttonImportStudents.Size = new Size(214, 56);
            buttonTranslateOutput.Size = new Size(214, 56);
            buttonTranslateOutput.AutoSizeMode = AutoSizeMode.GrowOnly;
        }
        private void ConfigScreen_Load(object sender, EventArgs e)
        {
            loadButtons();
            updateConfigContext("ImportStudents");

            main.Socket.OnMessage += OnResponse;


            buttonImportStudents.Click += (s, e) => updateConfigContext("ImportStudents");
            buttonImportClasses.Click += (s, e) => updateConfigContext("ImportClasses");
            buttonTranslateOutput.Click += (s, e) => updateConfigContext("TranslateOutput");
        }

        private void buttonStarterScreen_Click(object sender, EventArgs e)
        {
            main.Socket.OnMessage -= OnResponse;
        }
    }
}
