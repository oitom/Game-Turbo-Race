namespace Corrida
{
    partial class FormNomeJogadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNomeJogadores));
            this.textBoxJog1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJog2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericMelhorde = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            this.pictureBoxJogar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericMelhorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxJog1
            // 
            this.textBoxJog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJog1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(167)))));
            this.textBoxJog1.Location = new System.Drawing.Point(52, 61);
            this.textBoxJog1.Name = "textBoxJog1";
            this.textBoxJog1.Size = new System.Drawing.Size(231, 27);
            this.textBoxJog1.TabIndex = 0;
            this.textBoxJog1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogador 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(100)))), ((int)(((byte)(27)))));
            this.label2.Location = new System.Drawing.Point(48, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jogador 2:";
            // 
            // textBoxJog2
            // 
            this.textBoxJog2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJog2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(100)))), ((int)(((byte)(27)))));
            this.textBoxJog2.Location = new System.Drawing.Point(52, 130);
            this.textBoxJog2.Name = "textBoxJog2";
            this.textBoxJog2.Size = new System.Drawing.Size(231, 27);
            this.textBoxJog2.TabIndex = 2;
            this.textBoxJog2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Melhor de: ";
            // 
            // numericMelhorde
            // 
            this.numericMelhorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMelhorde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.numericMelhorde.Location = new System.Drawing.Point(130, 177);
            this.numericMelhorde.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericMelhorde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMelhorde.Name = "numericMelhorde";
            this.numericMelhorde.Size = new System.Drawing.Size(38, 20);
            this.numericMelhorde.TabIndex = 8;
            this.numericMelhorde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMelhorde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMelhorde.ValueChanged += new System.EventHandler(this.numericMelhorde_ValueChanged);
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSair.Image = global::Corrida.Properties.Resources.BSair;
            this.pictureBoxSair.Location = new System.Drawing.Point(12, 233);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(152, 52);
            this.pictureBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSair.TabIndex = 5;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // pictureBoxJogar
            // 
            this.pictureBoxJogar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxJogar.Image = global::Corrida.Properties.Resources.Bjogar;
            this.pictureBoxJogar.Location = new System.Drawing.Point(170, 233);
            this.pictureBoxJogar.Name = "pictureBoxJogar";
            this.pictureBoxJogar.Size = new System.Drawing.Size(152, 52);
            this.pictureBoxJogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxJogar.TabIndex = 4;
            this.pictureBoxJogar.TabStop = false;
            this.pictureBoxJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(330, 295);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // FormNomeJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(335, 297);
            this.Controls.Add(this.numericMelhorde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxJog2);
            this.Controls.Add(this.pictureBoxSair);
            this.Controls.Add(this.pictureBoxJogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJog1);
            this.Controls.Add(this.pictureBox3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNomeJogadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNomeJogadores";
            ((System.ComponentModel.ISupportInitialize)(this.numericMelhorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxJogar;
        private System.Windows.Forms.PictureBox pictureBoxSair;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox textBoxJog1;
        public System.Windows.Forms.TextBox textBoxJog2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numericMelhorde;
    }
}