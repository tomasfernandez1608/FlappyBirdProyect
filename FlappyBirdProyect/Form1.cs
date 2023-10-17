using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdProyect
{
    public partial class Form1 : Form
    {
        int Gravedad = 5;
        int VelocidadJuego = 4;
        int Puntos = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gametimeEvent(object sender, EventArgs e)
        {
            Start();
            Duck.Top += Gravedad;
            pipeButtom.Left -= VelocidadJuego;// Deplazo las tuberias por el eje X desde su posicion hacia la izquierda
            pipeTop.Left -= VelocidadJuego;
            PuntosText.Text = "Puntos:" + Puntos.ToString();

            if(pipeTop.Left < -100 ) //Regenero las estructuras una vez que hayan salido de la pantalla
            {
                pipeTop.Left = 700 + rnd.Next(-50,50);
                pipeTop.Height= pipeTop.Height + rnd.Next(-10,18);
                Puntos++;
            }
            if (pipeButtom.Left < -100)
            {
                pipeButtom.Left = 700 + rnd.Next(-50, 50);
                pipeButtom.Height = pipeButtom.Top + rnd.Next(-18, 10);
                Puntos++;
            }
            // Validar el GAMEOVER cuando el duck toca alguna estructura
            if(Duck.Bounds.IntersectsWith(pipeButtom.Bounds) || Duck.Bounds.IntersectsWith(pipeTop.Bounds) || Duck.Bounds.IntersectsWith(ground.Bounds) || Duck.Top < -25)
            {
                endGame();
            }
            //Cambio de velocidad segun puntaje
            if( Puntos==10 )
            {
                VelocidadJuego=6;
                
            }

        }
        private void Start()
        {
            
            StartGame.Visible = false;
        }
        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Space)
            {
                Gravedad = -10;
            }
            if(e.KeyCode == Keys.R)
            {
                RestartGame();
            }
        }
        
        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravedad = 5;
            }

        }
        
        private void duckUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Gravedad = 5;
            }
            
        }

        private void duckDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Gravedad = -10;
            }
        }

        private void endGame()
        {
            gametime.Stop();
            PuntosText.Text = "Tu Puntaje es de " + Puntos.ToString();
            pipeTop.Visible = false;
            pipeButtom.Visible = false;
            GameOver.Visible = true;
            RestartLabel.Visible = true;
            
        }

        private void RestartGame()
        {
            VelocidadJuego = 6;
            Duck.Top = 25;
            Duck.Left = 25;
            pipeButtom.Left = 500;
            pipeTop.Left = 500;
            Puntos = 0;
            GameOver.Visible = false;
            RestartLabel.Visible = false;
            pipeTop.Visible = true;
            pipeButtom.Visible = true;
            Start();
            gametime.Start();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

        }
    }
}
