using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class listaBarra : UserControl
    {

        String fundo = "50, 65, 72";

        MaterialSkinManager materialSkinManager;

        public listaBarra()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey900,
                                                              Accent.Cyan700,
                                                              TextShade.WHITE);
        }

        public String Titulo
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;


            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
