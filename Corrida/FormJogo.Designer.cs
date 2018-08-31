namespace Corrida
{
    partial class FormJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            this.timerCorrida = new System.Windows.Forms.Timer(this.components);
            this.timerCont = new System.Windows.Forms.Timer(this.components);
            this.labelJog1 = new System.Windows.Forms.Label();
            this.labelJog2 = new System.Windows.Forms.Label();
            this.labelPontos1 = new System.Windows.Forms.Label();
            this.labelPontos2 = new System.Windows.Forms.Label();
            this.timerVerGanhador = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            this.pictureCronometro = new System.Windows.Forms.PictureBox();
            this.pictureMenu2 = new System.Windows.Forms.PictureBox();
            this.pictureMenu1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCarro5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCarro4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCarro3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCarro2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCarro1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGanhador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCronometro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGanhador)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCorrida
            // 
            this.timerCorrida.Interval = 1;
            this.timerCorrida.Tick += new System.EventHandler(this.timerCorrida_Tick);
            // 
            // timerCont
            // 
            this.timerCont.Enabled = true;
            this.timerCont.Interval = 1;
            this.timerCont.Tick += new System.EventHandler(this.timerCont_Tick);
            // 
            // labelJog1
            // 
            this.labelJog1.AutoSize = true;
            this.labelJog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(167)))));
            this.labelJog1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJog1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelJog1.Location = new System.Drawing.Point(357, 728);
            this.labelJog1.Name = "labelJog1";
            this.labelJog1.Size = new System.Drawing.Size(102, 26);
            this.labelJog1.TabIndex = 8;
            this.labelJog1.Text = "NameJog1";
            this.labelJog1.Visible = false;
            // 
            // labelJog2
            // 
            this.labelJog2.AutoSize = true;
            this.labelJog2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(100)))), ((int)(((byte)(27)))));
            this.labelJog2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJog2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelJog2.Location = new System.Drawing.Point(757, 728);
            this.labelJog2.Name = "labelJog2";
            this.labelJog2.Size = new System.Drawing.Size(102, 26);
            this.labelJog2.TabIndex = 9;
            this.labelJog2.Text = "NameJog2";
            this.labelJog2.Visible = false;
            // 
            // labelPontos1
            // 
            this.labelPontos1.AutoSize = true;
            this.labelPontos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(167)))));
            this.labelPontos1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPontos1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPontos1.Location = new System.Drawing.Point(506, 731);
            this.labelPontos1.Name = "labelPontos1";
            this.labelPontos1.Size = new System.Drawing.Size(83, 23);
            this.labelPontos1.TabIndex = 12;
            this.labelPontos1.Text = "Pontos: 0";
            this.labelPontos1.Visible = false;
            // 
            // labelPontos2
            // 
            this.labelPontos2.AutoSize = true;
            this.labelPontos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(100)))), ((int)(((byte)(27)))));
            this.labelPontos2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPontos2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPontos2.Location = new System.Drawing.Point(911, 729);
            this.labelPontos2.Name = "labelPontos2";
            this.labelPontos2.Size = new System.Drawing.Size(83, 23);
            this.labelPontos2.TabIndex = 15;
            this.labelPontos2.Text = "Pontos: 0";
            this.labelPontos2.Visible = false;
            // 
            // timerVerGanhador
            // 
            this.timerVerGanhador.Interval = 2500;
            this.timerVerGanhador.Tick += new System.EventHandler(this.timerVerGanhador_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Corrida.Properties.Resources.NovoJogo;
            this.pictureBox1.Location = new System.Drawing.Point(1284, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureNovoJogo_Click);
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSair.Image = global::Corrida.Properties.Resources.Fechar;
            this.pictureBoxSair.Location = new System.Drawing.Point(1323, 1);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(39, 41);
            this.pictureBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSair.TabIndex = 10;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.pictureBoxSair_Click);
            // 
            // pictureCronometro
            // 
            this.pictureCronometro.Image = global::Corrida.Properties.Resources.Num3;
            this.pictureCronometro.Location = new System.Drawing.Point(581, 235);
            this.pictureCronometro.Name = "pictureCronometro";
            this.pictureCronometro.Size = new System.Drawing.Size(204, 145);
            this.pictureCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCronometro.TabIndex = 7;
            this.pictureCronometro.TabStop = false;
            // 
            // pictureMenu2
            // 
            this.pictureMenu2.Image = global::Corrida.Properties.Resources.Menu2;
            this.pictureMenu2.Location = new System.Drawing.Point(683, 692);
            this.pictureMenu2.Name = "pictureMenu2";
            this.pictureMenu2.Size = new System.Drawing.Size(400, 196);
            this.pictureMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureMenu2.TabIndex = 6;
            this.pictureMenu2.TabStop = false;
            // 
            // pictureMenu1
            // 
            this.pictureMenu1.Image = global::Corrida.Properties.Resources.Menu1;
            this.pictureMenu1.Location = new System.Drawing.Point(283, 692);
            this.pictureMenu1.Name = "pictureMenu1";
            this.pictureMenu1.Size = new System.Drawing.Size(400, 196);
            this.pictureMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureMenu1.TabIndex = 5;
            this.pictureMenu1.TabStop = false;
            // 
            // pictureBoxCarro5
            // 
            this.pictureBoxCarro5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro5.Image")));
            this.pictureBoxCarro5.Location = new System.Drawing.Point(21, 538);
            this.pictureBoxCarro5.Name = "pictureBoxCarro5";
            this.pictureBoxCarro5.Size = new System.Drawing.Size(92, 67);
            this.pictureBoxCarro5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarro5.TabIndex = 4;
            this.pictureBoxCarro5.TabStop = false;
            this.pictureBoxCarro5.Click += new System.EventHandler(this.pictureBoxCarro5_Click);
            // 
            // pictureBoxCarro4
            // 
            this.pictureBoxCarro4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro4.Image")));
            this.pictureBoxCarro4.Location = new System.Drawing.Point(21, 437);
            this.pictureBoxCarro4.Name = "pictureBoxCarro4";
            this.pictureBoxCarro4.Size = new System.Drawing.Size(65, 80);
            this.pictureBoxCarro4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCarro4.TabIndex = 3;
            this.pictureBoxCarro4.TabStop = false;
            // 
            // pictureBoxCarro3
            // 
            this.pictureBoxCarro3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro3.Image")));
            this.pictureBoxCarro3.Location = new System.Drawing.Point(21, 332);
            this.pictureBoxCarro3.Name = "pictureBoxCarro3";
            this.pictureBoxCarro3.Size = new System.Drawing.Size(92, 69);
            this.pictureBoxCarro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarro3.TabIndex = 2;
            this.pictureBoxCarro3.TabStop = false;
            // 
            // pictureBoxCarro2
            // 
            this.pictureBoxCarro2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro2.Image")));
            this.pictureBoxCarro2.Location = new System.Drawing.Point(21, 222);
            this.pictureBoxCarro2.Name = "pictureBoxCarro2";
            this.pictureBoxCarro2.Size = new System.Drawing.Size(107, 80);
            this.pictureBoxCarro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarro2.TabIndex = 1;
            this.pictureBoxCarro2.TabStop = false;
            // 
            // pictureBoxCarro1
            // 
            this.pictureBoxCarro1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarro1.Image")));
            this.pictureBoxCarro1.Location = new System.Drawing.Point(10, 123);
            this.pictureBoxCarro1.Name = "pictureBoxCarro1";
            this.pictureBoxCarro1.Size = new System.Drawing.Size(150, 72);
            this.pictureBoxCarro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarro1.TabIndex = 0;
            this.pictureBoxCarro1.TabStop = false;
            // 
            // pictureBoxGanhador
            // 
            this.pictureBoxGanhador.Image = global::Corrida.Properties.Resources.Ganhou3;
            this.pictureBoxGanhador.Location = new System.Drawing.Point(456, 228);
            this.pictureBoxGanhador.Name = "pictureBoxGanhador";
            this.pictureBoxGanhador.Size = new System.Drawing.Size(455, 153);
            this.pictureBoxGanhador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGanhador.TabIndex = 16;
            this.pictureBoxGanhador.TabStop = false;
            this.pictureBoxGanhador.Visible = false;
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.labelPontos2);
            this.Controls.Add(this.labelPontos1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxSair);
            this.Controls.Add(this.labelJog2);
            this.Controls.Add(this.labelJog1);
            this.Controls.Add(this.pictureCronometro);
            this.Controls.Add(this.pictureMenu2);
            this.Controls.Add(this.pictureMenu1);
            this.Controls.Add(this.pictureBoxCarro5);
            this.Controls.Add(this.pictureBoxCarro4);
            this.Controls.Add(this.pictureBoxCarro3);
            this.Controls.Add(this.pictureBoxCarro2);
            this.Controls.Add(this.pictureBoxCarro1);
            this.Controls.Add(this.pictureBoxGanhador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJogo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCronometro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGanhador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCarro1;
        private System.Windows.Forms.PictureBox pictureBoxCarro2;
        private System.Windows.Forms.PictureBox pictureBoxCarro3;
        private System.Windows.Forms.PictureBox pictureBoxCarro4;
        private System.Windows.Forms.PictureBox pictureBoxCarro5;
        private System.Windows.Forms.Timer timerCorrida;
        private System.Windows.Forms.Timer timerCont;
        private System.Windows.Forms.PictureBox pictureCronometro;
        private System.Windows.Forms.Label labelJog1;
        private System.Windows.Forms.Label labelJog2;
        private System.Windows.Forms.PictureBox pictureBoxSair;
        private System.Windows.Forms.PictureBox pictureMenu2;
        private System.Windows.Forms.PictureBox pictureMenu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPontos1;
        private System.Windows.Forms.Label labelPontos2;
        private System.Windows.Forms.PictureBox pictureBoxGanhador;
        private System.Windows.Forms.Timer timerVerGanhador;
    }
}

