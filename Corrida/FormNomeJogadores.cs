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
    public partial class FormNomeJogadores : Form
    {
        public bool Jogar = false;
        public FormNomeJogadores()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            Jogar = true;
            Close();
        }

        private void numericMelhorde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
