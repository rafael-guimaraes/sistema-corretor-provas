using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.Componentes
{
    public partial class itemStudent : UserControl
    {
        private string StudentData;
        JObject translateField = new JObject(
            new JProperty("matricula", "Matrícula"),
            new JProperty("nome", "Nome"),
            new JProperty("serie", "Série"),
            new JProperty("turma", "Turma"),
            new JProperty("situacao", "Situação"),
            new JProperty("email", "Email"),
            new JProperty("legal_email", "Email do Responsável")
        );
        public itemStudent(JObject info)
        {
            string student_info = "";

            foreach(JProperty field in info.Properties())
            {
                
                student_info += field.Name != "_id"?
                    translateField[field.Name] + ": " + field.Value + "\n"
                    : "";
            }
            StudentData = student_info.Substring(0,student_info.Length - 1);

            InitializeComponent();

            label1.Text = info["matricula"] + " - " + info["nome"] + " - " + info["turma"];
        }


        private void itemStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StudentData,"DADOS DO ALUNO");
        }
    }
}
