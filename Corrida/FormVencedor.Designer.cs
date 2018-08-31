namespace Corrida
{
    partial class FormVencedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVencedor));
            this.labelNome = new System.Windows.Forms.Label();
            this.labelGanhou = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureSair = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelNome.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(487, 74);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "NomeJogador";
            // 
            // labelGanhou
            // 
            this.labelGanhou.AutoSize = true;
            this.labelGanhou.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelGanhou.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanhou.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelGanhou.Location = new System.Drawing.Point(177, 79);
            this.labelGanhou.Name = "labelGanhou";
            this.labelGanhou.Size = new System.Drawing.Size(347, 74);
            this.labelGanhou.TabIndex = 1;
            this.labelGanhou.Text = "Ganhou!!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Corrida.Properties.Resources.Bnovo;
            this.pictureBox1.Location = new System.Drawing.Point(347, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureNovoJogo_Click);
            // 
            // pictureSair
            // 
            this.pictureSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSair.Image = global::Corrida.Properties.Resources.BSair;
            this.pictureSair.Location = new System.Drawing.Point(19, 156);
            this.pictureSair.Name = "pictureSair";
            this.pictureSair.Size = new System.Drawing.Size(152, 52);
            this.pictureSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureSair.TabIndex = 3;
            this.pictureSair.TabStop = false;
            this.pictureSair.Click += new System.EventHandler(this.pictureSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(535, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FormVencedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(537, 223);
            this.Controls.Add(this.pictureSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelGanhou);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVencedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVencedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGanhou;
        public System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureSair;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}