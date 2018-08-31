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
    public partial class FormAposta : Form
    {
        public byte Aposta1, Aposta2, NumClick = 1;

        public FormAposta()
        {
            InitializeComponent();
            NumClick = 1;
        }

        private void DesabilitaCarros1(int Num)
        {
            if (Num != 1)
            {
                pictureBoxCarro1Jog1.Image = Properties.Resources.burn_preto;
                pictureBoxCarro1Jog1.Enabled = false;
            }
            if (Num != 2)
            {
                pictureBoxCarro2Jog1.Image = Properties.Resources.skidmark_preto;
                pictureBoxCarro2Jog1.Enabled = false;
            }
            if (Num != 3)
            {
                pictureBoxCarro3Jog1.Image = Properties.Resources.turbo_preto;
                pictureBoxCarro3Jog1.Enabled = false;
            }
            if (Num != 4)
            {
                pictureBoxCarro4Jog1.Image = Properties.Resources.smoove_preto;
                pictureBoxCarro4Jog1.Enabled = false;

            }
            if (Num != 5)
            {
                pictureBoxCarro5Jog1.Image = Properties.Resources.whiteShadow_preto;
                pictureBoxCarro5Jog1.Enabled = false;
            }

            pictureBoxCarro1Jog1.Cursor = pictureBoxCarro2Jog1.Cursor = pictureBoxCarro3Jog1.Cursor = pictureBoxCarro4Jog1.Cursor = pictureBoxCarro5Jog1.Cursor = Cursors.Default;
        }

        private void DesabilitaCarros2(int Num)
        {
            if (Num != 1)
            {
                pictureBoxCarro1Jog2.Image = Properties.Resources.burn_preto;
                pictureBoxCarro1Jog2.Enabled = false;
            }
            if (Num != 2)
            {
                pictureBoxCarro2Jog2.Image = Properties.Resources.skidmark_preto;
                pictureBoxCarro2Jog2.Enabled = false;
            }
            if (Num != 3)
            {
                pictureBoxCarro3Jog2.Image = Properties.Resources.turbo_preto;
                pictureBoxCarro3Jog2.Enabled = false;
            }
            if (Num != 4)
            {
                pictureBoxCarro4Jog2.Image = Properties.Resources.smoove_preto;
                pictureBoxCarro4Jog2.Enabled = false;

            }
            if (Num != 5)
            {
                pictureBoxCarro5Jog2.Image = Properties.Resources.whiteShadow_preto;
                pictureBoxCarro5Jog2.Enabled = false;
            }

            pictureBoxCarro1Jog2.Cursor = pictureBoxCarro2Jog2.Cursor = pictureBoxCarro3Jog2.Cursor = pictureBoxCarro4Jog2.Cursor = pictureBoxCarro5Jog2.Cursor = Cursors.Default;

        }

        private void HabilitaCarros2()
        {
            pictureBoxCarro1Jog2.Enabled = pictureBoxCarro2Jog2.Enabled = pictureBoxCarro3Jog2.Enabled = pictureBoxCarro4Jog2.Enabled = pictureBoxCarro5Jog2.Enabled = true;
        }

        private void CarregaImgNoAposta2()
        {
            if (Aposta1 != 1)
                pictureBoxCarro1Jog2.Image = Properties.Resources.burn;
            if (Aposta1 != 2)
                pictureBoxCarro2Jog2.Image = Properties.Resources.skidmark;
            if (Aposta1 != 3)
                pictureBoxCarro3Jog2.Image = Properties.Resources.turbo;
            if (Aposta1 != 4)
                pictureBoxCarro4Jog2.Image = Properties.Resources.smoove;
            if (Aposta1 != 5)
                pictureBoxCarro5Jog2.Image = Properties.Resources.whiteShadow;
            return;

        }

        private void ClickIMG1(object sender, EventArgs e)
        {
            if (NumClick == 1)
            {
                PictureBox Img = ((PictureBox)sender);
                if (int.Parse(Img.Tag.ToString()) == 1)
                    Aposta1 = 1;
                else if (int.Parse(Img.Tag.ToString()) == 2)
                    Aposta1 = 2;
                else if (int.Parse(Img.Tag.ToString()) == 3)
                    Aposta1 = 3;
                else if (int.Parse(Img.Tag.ToString()) == 4)
                    Aposta1 = 4;
                else if (int.Parse(Img.Tag.ToString()) == 5)
                    Aposta1 = 5;
                DesabilitaCarros1(Aposta1);
                HabilitaCarros2();
                CarregaImgNoAposta2();
                NumClick++;
            }
        }

        private void ClickIMG2(object sender, EventArgs e)
        {
            if (NumClick == 2)
            {
                PictureBox Img = ((PictureBox)sender);
                if (int.Parse(Img.Tag.ToString()) != Aposta1)
                {
                    if (int.Parse(Img.Tag.ToString()) == 1)
                        Aposta2 = 1;
                    else if (int.Parse(Img.Tag.ToString()) == 2)
                        Aposta2 = 2;
                    else if (int.Parse(Img.Tag.ToString()) == 3)
                        Aposta2 = 3;
                    else if (int.Parse(Img.Tag.ToString()) == 4)
                        Aposta2 = 4;
                    else if (int.Parse(Img.Tag.ToString()) == 5)
                        Aposta2 = 5;
                    NumClick++;
                    DesabilitaCarros2(Aposta2);
                    timer1.Enabled = true;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
