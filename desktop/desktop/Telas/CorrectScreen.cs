using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.Telas
{
    public partial class CorrectScreen : UserControl
    {
        public CorrectScreen()
        {
            InitializeComponent();
        }
        public event EventHandler gotoStarterScreen
        {
            add { buttonStarterScreen.Click += value; } remove { buttonStarterScreen.Click -= value; }
        }
    }
}
