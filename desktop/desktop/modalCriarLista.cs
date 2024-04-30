using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace desktop
{
    public partial class modalCriarLista : MaterialForm
    {
        MaterialSkinManager materialSkinManager;

        Color cinzaEscuro = Color.DarkGray;

        public modalCriarLista()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                              Primary.BlueGrey900,
                                                              Primary.BlueGrey900,
                                                              Accent.Cyan700,
                                                              TextShade.WHITE);

        }

        public void setPosition(int eixoX, int eixoY)
        {
            Location = new Point(eixoX, eixoY);
        }

    }
}
