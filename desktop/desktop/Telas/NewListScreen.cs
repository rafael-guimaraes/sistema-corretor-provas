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
using WebSocketSharp;

namespace desktop.Telas
{
    public partial class NewListScreen : UserControl
    {
        public NewListScreen()
        {
            InitializeComponent();
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Data);
            JObject response = JObject.Parse(e.Data);
            MessageBox.Show(response["task"].ToString());
            MessageBox.Show(response["data"].ToString());
        }

        public event EventHandler gotoListScreen
        { add { buttonListScreen.Click += value; } remove { buttonListScreen.Click -= value; } }
        private void NewListScreen_Load(object sender, EventArgs e)
        {
            main.Socket.OnMessage += OnResponse;
        }

        private void buttonListScreen_Click(object sender, EventArgs e)
        {
            main.Socket.OnMessage -= OnResponse;
        }

        private void textBoxListName_Click(object sender, EventArgs e)
        {

        }
    }
}
