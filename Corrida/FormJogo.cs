using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;


namespace Corrida
{
    public partial class FormJogo : Form
    {
        Stopwatch Cronometro = new Stopwatch();
        SoundPlayer SomContRegre = new SoundPlayer(Properties.Resources.Countdown);
        Random Sorteio = new Random();
        byte NumGanhou = 0, Aposta1, Aposta2, Pontos1 = 0, Pontos2 = 0, Termina = 0;
        bool FimdeJogo = false;
        byte rodadas = 0;





        //Construtor
        public FormJogo()
        {
            InitializeComponent();
        }

        //LOAD
        private void FormJogo_Load(object sender, EventArgs e)
        {
            FormNomeJogadores FNome = new FormNomeJogadores();
            FNome.ShowDialog();
            
            Termina = byte.Parse(FNome.numericMelhorde.Value.ToString());

            if (!FNome.Jogar)
                Application.Exit();
            FormAposta FAposta = new FormAposta();
            FAposta.labelNome1.Text = labelJog1.Text = FNome.textBoxJog1.Text;
            FAposta.labelNome2.Text = labelJog2.Text = FNome.textBoxJog2.Text;
            FAposta.ShowDialog();
            Aposta1 = FAposta.Aposta1; Aposta2 = FAposta.Aposta2;
            labelJog1.Visible = labelJog2.Visible = labelPontos1.Visible = labelPontos2.Visible = true;
            DesparaCronometro();
            rodadas++;
        }

        // Responsalvel pela contagem | 3 | 2 | 1 | GO |
        private void DesparaCronometro()
        {
            pictureCronometro.Visible = true;
            Cronometro.Start();
            SomContRegre.Play();
            timerCont.Enabled = true;
        }

        // Coloca os carro no linha inicial
        private void LocalizacaoPadraoCarros()
        {
            pictureBoxCarro1.Location = new Point(21, 112);
            pictureBoxCarro2.Location = new Point(21, 201);
            pictureBoxCarro3.Location = new Point(21, 311);
            pictureBoxCarro4.Location = new Point(21, 416);
            pictureBoxCarro5.Location = new Point(21, 529);
        }

        // Nova Corrida
        private void DeNovo()
        {
            NumGanhou = 0;
            FormAposta FAposta = new FormAposta();
            FAposta.labelNome1.Text = labelJog1.Text;
            FAposta.labelNome2.Text = labelJog2.Text;
            FAposta.ShowDialog();
            Aposta1 = FAposta.Aposta1;
            Aposta2 = FAposta.Aposta2;
            LocalizacaoPadraoCarros();
            DesparaCronometro();
        }

        // Verifica qual jogador ganhou ou nao
        private void QualJogGanhou()
        {
            if (Aposta1 == NumGanhou)
            {
                Pontos1++;
                labelPontos1.Text = "Pontos: " + Pontos1;
            }
            if (Aposta2 == NumGanhou)
            {
                Pontos2++;
                labelPontos2.Text = "Pontos: " + Pontos2;
            }
            if (Pontos1 >= Termina || Pontos2 >= Termina)
            {
                FimdeJogo = true;
            }
        }

        // Verifica se alguem Ganhou
        private void Ganhou()
        {
            if (int.Parse(pictureBoxCarro1.Location.X.ToString()) >= 1230)
            {
                timerCorrida.Enabled = false;
                MostraGanhador(1);
                NumGanhou = 1;
            }
            else if (pictureBoxCarro2.Location.X >= 1230)
            {
                timerCorrida.Enabled = false;
                MostraGanhador(2);
                NumGanhou = 2;
            }
            else if (pictureBoxCarro3.Location.X >= 1230)
            {
                timerCorrida.Enabled = false;
                MostraGanhador(3);
                NumGanhou = 3;
            }
            else if (pictureBoxCarro4.Location.X >= 1230)
            {
                timerCorrida.Enabled = false;
                MostraGanhador(4);
                NumGanhou = 4;
            }
            else if (pictureBoxCarro5.Location.X >= 1230)
            {
                timerCorrida.Enabled = false;
                MostraGanhador(5);
                NumGanhou = 5;
            }

            QualJogGanhou();
        }

        // Mostra a IMG de quem ganhou!
        private void MostraGanhador(byte num)
        {
            if (num == 1)
                pictureBoxGanhador.Image = Properties.Resources.Ganhou1;
            else if (num == 2)
                pictureBoxGanhador.Image = Properties.Resources.Ganhou2;
            else if (num == 3)
                pictureBoxGanhador.Image = Properties.Resources.Ganhou3;
            else if (num == 4)
                pictureBoxGanhador.Image = Properties.Resources.Ganhou4;
            else if (num == 5)
                pictureBoxGanhador.Image = Properties.Resources.Ganhou5;
            timerVerGanhador.Enabled = true;
            pictureBoxGanhador.Visible = true;
        }

        private void NovoJogo()
        {
            Pontos1 = Pontos2 = 0;
            labelPontos1.Text = labelPontos2.Text = "Pontos: 0";
            NumGanhou = Aposta1 = Aposta2 = 0;
            FimdeJogo = false;
            timerCont.Enabled = false;
            SomContRegre.Stop();
            Cronometro.Reset();
            timerVerGanhador.Enabled = false;
            timerCorrida.Enabled = false;
            LocalizacaoPadraoCarros();
            DeNovo();

        }

        // Sair
        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Timer Corrida
        private void timerCorrida_Tick(object sender, EventArgs e)
        {
            Point Posicao = new Point();
            int Sorte = Sorteio.Next(1, 6);

            switch (Sorte)
            {
                case 1:
                    Posicao = pictureBoxCarro1.Location;
                    Posicao.X += 5;
                    pictureBoxCarro1.Location = Posicao;
                    break;
                case 2:
                    Posicao = pictureBoxCarro2.Location;
                    Posicao.X += 5;
                    pictureBoxCarro2.Location = Posicao;
                    break;
                case 3:
                    Posicao = pictureBoxCarro3.Location;
                    Posicao.X += 5;
                    pictureBoxCarro3.Location = Posicao;
                    break;
                case 4:
                    Posicao = pictureBoxCarro4.Location;
                    Posicao.X += 5;
                    pictureBoxCarro4.Location = Posicao;
                    break;
                case 5:
                    Posicao = pictureBoxCarro5.Location;
                    Posicao.X += 5;
                    pictureBoxCarro5.Location = Posicao;

                    break;
            }
            Ganhou();
        }

        //Timer Contagem 
        private void timerCont_Tick(object sender, EventArgs e)
        {
            if (int.Parse(Cronometro.Elapsed.Seconds.ToString()) <= 3)
            {

                if (int.Parse(Cronometro.Elapsed.Seconds.ToString()) == 0)
                    pictureCronometro.Image = Properties.Resources.Num3;
                else if (int.Parse(Cronometro.Elapsed.Seconds.ToString()) == 1)
                    pictureCronometro.Image = Properties.Resources.Num2;
                else if (int.Parse(Cronometro.Elapsed.Seconds.ToString()) == 2)
                    pictureCronometro.Image = Properties.Resources.Num1;
                else if (int.Parse(Cronometro.Elapsed.Seconds.ToString()) == 3)
                    pictureCronometro.Image = Properties.Resources.GO;
            }
            else
            {
                Cronometro.Reset();
                pictureCronometro.Visible = false;
                timerCont.Enabled = false;
                timerCorrida.Enabled = true;
            }

        }

        // VerGanhador
        private void timerVerGanhador_Tick(object sender, EventArgs e)
        {
            pictureBoxGanhador.Visible = false;
            timerVerGanhador.Enabled = false;
            if (!FimdeJogo)
                DeNovo();
            else
            {
                FormVencedor FVencedor = new FormVencedor();
                if (Pontos1 > Pontos2)
                    FVencedor.labelNome.Text = labelJog1.Text;
                else
                    FVencedor.labelNome.Text = labelJog2.Text;
                FVencedor.ShowDialog();
            }
        }

        private void pictureNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void pictureBoxCarro5_Click(object sender, EventArgs e)
        {

        }

    }
}
