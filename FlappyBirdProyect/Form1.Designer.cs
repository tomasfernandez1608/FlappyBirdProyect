namespace FlappyBirdProyect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PuntosText = new System.Windows.Forms.Label();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.RestartLabel = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.Duck = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeButtom = new System.Windows.Forms.PictureBox();
            this.StartGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).BeginInit();
            this.SuspendLayout();
            // 
            // PuntosText
            // 
            this.PuntosText.AutoSize = true;
            this.PuntosText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PuntosText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntosText.Location = new System.Drawing.Point(420, 468);
            this.PuntosText.Name = "PuntosText";
            this.PuntosText.Size = new System.Drawing.Size(80, 20);
            this.PuntosText.TabIndex = 4;
            this.PuntosText.Text = "Puntos:0";
            // 
            // gametime
            // 
            this.gametime.Enabled = true;
            this.gametime.Interval = 20;
            this.gametime.Tick += new System.EventHandler(this.gametimeEvent);
            // 
            // RestartLabel
            // 
            this.RestartLabel.AutoSize = true;
            this.RestartLabel.BackColor = System.Drawing.Color.Transparent;
            this.RestartLabel.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartLabel.Location = new System.Drawing.Point(235, 377);
            this.RestartLabel.Name = "RestartLabel";
            this.RestartLabel.Size = new System.Drawing.Size(222, 25);
            this.RestartLabel.TabIndex = 6;
            this.RestartLabel.Text = "Press R to RESTART";
            this.RestartLabel.Visible = false;
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Image = global::FlappyBirdProyect.Properties.Resources.Gameovergif;
            this.GameOver.Location = new System.Drawing.Point(-6, 0);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(709, 439);
            this.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOver.TabIndex = 5;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::FlappyBirdProyect.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(422, -18);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(78, 207);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // Duck
            // 
            this.Duck.BackColor = System.Drawing.Color.Transparent;
            this.Duck.Image = global::FlappyBirdProyect.Properties.Resources.duckV3;
            this.Duck.Location = new System.Drawing.Point(53, 179);
            this.Duck.Name = "Duck";
            this.Duck.Size = new System.Drawing.Size(52, 42);
            this.Duck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Duck.TabIndex = 0;
            this.Duck.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdProyect.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-6, 436);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(822, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeButtom
            // 
            this.pipeButtom.BackColor = System.Drawing.Color.Transparent;
            this.pipeButtom.Image = global::FlappyBirdProyect.Properties.Resources.pipe;
            this.pipeButtom.Location = new System.Drawing.Point(422, 315);
            this.pipeButtom.Name = "pipeButtom";
            this.pipeButtom.Size = new System.Drawing.Size(78, 181);
            this.pipeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeButtom.TabIndex = 1;
            this.pipeButtom.TabStop = false;
            // 
            // StartGame
            // 
            this.StartGame.AutoSize = true;
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(0, 402);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(241, 25);
            this.StartGame.TabIndex = 7;
            this.StartGame.Text = "Press SPACE to JUMP";
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(695, 508);
            this.Controls.Add(this.RestartLabel);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.Duck);
            this.Controls.Add(this.PuntosText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeButtom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Bird - CS50 Proyect Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Duck;
        private System.Windows.Forms.PictureBox pipeButtom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label PuntosText;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.PictureBox GameOver;
        private System.Windows.Forms.Label RestartLabel;
        private System.Windows.Forms.Label StartGame;
    }
}

