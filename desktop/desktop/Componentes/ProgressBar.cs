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
    public partial class ProgressBar : UserControl
    {
        public ProgressBar(int width, int height)
        {
            InitializeComponent(width, height);
        }

        public void updateValue(int total, int progress)
        {
            progressText.Text = progress.ToString() + "/" + total.ToString();
            progressBarItem.Value = (int)((progress * 100 / total));
        }
    }
}
