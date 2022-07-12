using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataCuUtilizatorul
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ButtonStartJoc_Click(object sender, EventArgs e)
        {
            new AfisareCerinte().Show();
        }

        private void ButtonAdaugaSterge_Click(object sender, EventArgs e)
        {
            new AdaugaSterge().Show();
        }

        private void Ieșire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setări_Click(object sender, EventArgs e)
        {
            new Setari().Show();
        }
    }
}
