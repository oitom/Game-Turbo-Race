using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Corrida
{
    public partial class FormVencedor : Form
    {
        public bool NovoJogo = false;
        public FormVencedor()
        {
            InitializeComponent();
        }

        private void pictureNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo = true;
            Close();
        }

        private void pictureSair_Click(object sender, EventArgs e)
        {
            NovoJogo = false;
            Close();
        }
    }
}
