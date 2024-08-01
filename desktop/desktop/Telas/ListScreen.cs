using Microsoft.VisualBasic;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace desktop
{
    public partial class ListScreen : UserControl
    {

        SocketAPI socket = new SocketAPI("Listas");
        private JArray staticList;
        private List<itemLista> items = new List<itemLista>();
        private itemLista selectedItem;
        public ListScreen()
        {
            InitializeComponent();
        }
        public event EventHandler gotoStarterScreen
        { add { buttonStarterScreen.Click += value; } remove { buttonStarterScreen.Click -= value; } }

        public event EventHandler gotoCreateScreen
        { add { buttonCreateScreen.Click += value; } remove { buttonCreateScreen.Click -= value; } }

        public event EventHandler gotoNewListScreen
        { add { buttonNewListScreen.Click += value; } remove { buttonNewListScreen.Click -= value; } }

        private void loadListItems(string filter)
        {
            if (panelTabela_Listas.InvokeRequired)
                panelTabela_Listas.Invoke((MethodInvoker)delegate
                {
                    panelTabela_Listas.Controls.Clear();
                });
            else
                panelTabela_Listas.Controls.Clear();

            foreach (JObject item in staticList)
            {
                string title = item["title"].ToString().ToLower();
                filter = filter.ToLower();
                if (title.Contains(filter))
                {

                    if (panelTabela_Listas.InvokeRequired)
                    {
                        panelTabela_Listas.Invoke((MethodInvoker)delegate
                        {
                            itemLista lista = new itemLista(item);
                            items.Add(lista);
                            panelTabela_Listas.Controls.Add(lista);
                        });
                    }
                    else
                    {
                        itemLista lista = new itemLista(item);
                        panelTabela_Listas.Controls.Add(lista);
                    }
                }
            }
        }
        private void OnResponse(object sender, MessageEventArgs e)
        {
            JObject response = JObject.Parse(e.Data);
            string task = response["task"].ToString();
            switch (task)
            {
                case "getListas":
                    staticList = JArray.Parse(response["data"].ToString());
                    loadListItems("");
                    MessageBox.Show(staticList.ToString());
                    break;
                case "deleteListByID":
                    MessageBox.Show(response["data"].ToString());
                    break;
            }
        }

        private void ListScreen_Load(object sender, EventArgs e)
        {
            main.Socket.OnMessage += OnResponse;
            main.Request(socket.Task("getListas").Body("{}"));
            buttonCreateScreen.Enabled = false;
            buttonCreateScreen.Click += (s, e) => { main.Socket.OnMessage -= OnResponse; };
            buttonNewListScreen.Click += (s, e) => { main.Socket.OnMessage -= OnResponse; };
            itemLista.OnItemChecked += ItemLista_OnItemChecked;
        }
        private void ItemLista_OnItemChecked(itemLista selected)
        {
            selectedItem = selected.CheckListItem ? selected : null;
            foreach (var item in items)
            {
                if (item != selected)
                {
                    item.Deselect();
                }
            }
            selectedItem = selected;
            buttonCreateScreen.Enabled = selected.CheckListItem;
        }
        private void textBoxFiltro_Listas_TextChanged(object sender, EventArgs e)
        {
            loadListItems(textBoxFiltro_Listas.Text);
        }

        private void buttonStarterScreen_Click(object sender, EventArgs e)
        {
            main.Socket.OnMessage -= OnResponse;
        }

        private void buttonCreateScreen_Click(object sender, EventArgs e)
        {
            main.LOCAL.Add("lista", selectedItem.ListID);
        }
    }
}
