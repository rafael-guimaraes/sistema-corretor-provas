using MaterialSkin;
using MaterialSkin.Controls;
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

namespace desktop
{
    public partial class itemLista : UserControl
    {
        private string listID;
        private string listType;
        public string listTitle;

        MaterialSkinManager materialSkinManager;
        SocketAPI socket = new SocketAPI("Listas");
        public static event Action<itemLista> OnItemChecked;

        public itemLista(JObject lista)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey900,
                                                              Accent.Cyan700,
                                                              TextShade.WHITE);
            listTitle = lista["title"].ToString();
            checkListItem.Text = listTitle;
            listID = lista["_id"].ToString();
            listType = lista["type"].ToString();
        }

        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            main.Request(socket.Task("deleteListByID").Body(listID));
            main.Request(socket.Task("getListas").Body());
        }

        private void checkListItem_CheckedChanged(object sender, EventArgs e)
        {
            OnItemChecked?.Invoke(this);
        }

        public void Deselect()
        {
            checkListItem.Checked = false;
        }
        public bool CheckListItem
        {
            get { return checkListItem.Checked; }
        }
        public string ListID
        {
            get { return listID; }
        }
    }
}
