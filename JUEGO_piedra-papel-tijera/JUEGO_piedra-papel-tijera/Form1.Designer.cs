namespace JUEGO_piedra_papel_tijera
{
    partial class Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.picPiedra = new System.Windows.Forms.PictureBox();
            this.picPapel = new System.Windows.Forms.PictureBox();
            this.picTijera = new System.Windows.Forms.PictureBox();
            this.picJugador = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.computerChoise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPiedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTijera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // picPiedra
            // 
            this.picPiedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPiedra.Image = ((System.Drawing.Image)(resources.GetObject("picPiedra.Image")));
            this.picPiedra.Location = new System.Drawing.Point(125, 113);
            this.picPiedra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPiedra.Name = "picPiedra";
            this.picPiedra.Size = new System.Drawing.Size(177, 149);
            this.picPiedra.TabIndex = 0;
            this.picPiedra.TabStop = false;
            this.picPiedra.Click += new System.EventHandler(this.Jugador_click);
            // 
            // picPapel
            // 
            this.picPapel.Image = ((System.Drawing.Image)(resources.GetObject("picPapel.Image")));
            this.picPapel.Location = new System.Drawing.Point(388, 113);
            this.picPapel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPapel.Name = "picPapel";
            this.picPapel.Size = new System.Drawing.Size(177, 149);
            this.picPapel.TabIndex = 1;
            this.picPapel.TabStop = false;
            this.picPapel.Click += new System.EventHandler(this.Jugador_click);
            // 
            // picTijera
            // 
            this.picTijera.Image = ((System.Drawing.Image)(resources.GetObject("picTijera.Image")));
            this.picTijera.Location = new System.Drawing.Point(637, 113);
            this.picTijera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTijera.Name = "picTijera";
            this.picTijera.Size = new System.Drawing.Size(200, 138);
            this.picTijera.TabIndex = 2;
            this.picTijera.TabStop = false;
            this.picTijera.Click += new System.EventHandler(this.Jugador_click);
            // 
            // picJugador
            // 
            this.picJugador.Location = new System.Drawing.Point(225, 300);
            this.picJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picJugador.Name = "picJugador";
            this.picJugador.Size = new System.Drawing.Size(200, 138);
            this.picJugador.TabIndex = 3;
            this.picJugador.TabStop = false;
            this.picJugador.Click += new System.EventHandler(this.picJugador_Click);
            // 
            // picComputer
            // 
            this.picComputer.Location = new System.Drawing.Point(510, 300);
            this.picComputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(200, 138);
            this.picComputer.TabIndex = 4;
            this.picComputer.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(229, 32);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(556, 43);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "JUEGO PIEDRA - PAPEL - TIJERA";
            // 
            // computerChoise
            // 
            this.computerChoise.AccessibleName = "Jugador_click";
            this.computerChoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.computerChoise.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoise.ForeColor = System.Drawing.Color.White;
            this.computerChoise.Location = new System.Drawing.Point(402, 455);
            this.computerChoise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.computerChoise.Name = "computerChoise";
            this.computerChoise.Size = new System.Drawing.Size(136, 39);
            this.computerChoise.TabIndex = 7;
            this.computerChoise.Text = "Jugar";
            this.computerChoise.UseVisualStyleBackColor = false;
            this.computerChoise.Click += new System.EventHandler(this.RandomNr_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "Jugador_click";
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(402, 502);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(983, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.computerChoise);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.picJugador);
            this.Controls.Add(this.picTijera);
            this.Controls.Add(this.picPapel);
            this.Controls.Add(this.picPiedra);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPiedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTijera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPiedra;
        private System.Windows.Forms.PictureBox picPapel;
        private System.Windows.Forms.PictureBox picTijera;
        private System.Windows.Forms.PictureBox picJugador;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button computerChoise;
        private System.Windows.Forms.Button button1;
    }
}

