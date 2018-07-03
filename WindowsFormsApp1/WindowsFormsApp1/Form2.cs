using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        bool goup, godown, goizq, goder;
        int speed = 5;
        int Score = 0;
        int ghostm = 2;
        public string name;
        public List<Player> JUG;

        Random rd = new Random();
        public Form2()
        {
            InitializeComponent();
            Cherry.Hide();
            Uva.Hide();
            Cherry.Top = rd.Next(0, 300);
            Cherry.Left = rd.Next(0,560);
            Uva.Top = rd.Next(0, 300);
            Uva.Left = rd.Next(0, 560);
            Cherry.Show();
            Uva.Show();
            ghostRed.Hide();
            ghostPink.Hide();
            ghostRed.Top = rd.Next(0, 300);
            ghostRed.Left = rd.Next(0, 560);
            ghostRed.Show();
            ghostPink.Top = rd.Next(0, 300);
            ghostPink.Left = rd.Next(0, 560);
            ghostPink.Show();
            
        }
        private void Movimiento(object sender, EventArgs e)
        {
    
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goizq = true;
                
            }
            if (e.KeyCode == Keys.Right)
            {
                goder = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }

        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goizq = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goder = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
        }

        private void TimerGame(object sender, EventArgs e)
        {


            //List<Player> JUG;
            Lscore.Text = "Puntos: " + Score.ToString();
            if (goizq == true && pacman.Left >0)
            {
                pacman.Left -= speed;
            }
            if (goder == true && pacman.Left <560)
            {
                pacman.Left += speed;
            }
            if (godown == true && pacman.Top <300)
            {
                pacman.Top += speed; 
            }
            if (goup == true && pacman.Top >0)
            {
                pacman.Top -= speed;
            }
            if (pacman.Bounds.IntersectsWith(Cherry.Bounds))
            {
                Score += 10;
                Cherry.Hide();
                Cherry.Top = rd.Next(0, 300);
                Cherry.Left = rd.Next(0, 560);
                Cherry.Show();

            }
            if (pacman.Bounds.IntersectsWith(Uva.Bounds))
            {
                Score += 15;
                Uva.Hide();
                Uva.Top = rd.Next(0, 300);
                Uva.Left = rd.Next(0, 560);
                Uva.Show();
            }
            if (pacman.Bounds.IntersectsWith(ghostRed.Bounds))
            {
                Tiempo.Stop();
                string m = "Perdiste "+ name+ " PUNTAJE: " + Score.ToString();
                MessageBox.Show(m);
                Player p1 = new Player(name, Score);
                //JUG.Add(p1);
                //Metodos.serializarPlayers(jugadores);
                Form1 f = new Form1();
                f.Show();

                this.Close();
            }
            if (pacman.Bounds.IntersectsWith(ghostPink.Bounds))
            {
                
                Tiempo.Stop();
                string m = "Perdiste, PUNTAJE: " + Score.ToString();
                MessageBox.Show(m);
                Player p1 = new Player(name, Score);
                //JUG.Add(p1);
                //Metodos.serializarPlayers(JUG);
                Form1 f = new Form1();
                f.Show();
                
                this.Close();
            }
            if (ghostPink.Left > 0 && ghostPink.Left < 560)
            {
                if (ghostPink.Left - pacman.Left <0)
                {
                    ghostPink.Left += ghostm;
                }
                else if (ghostPink.Left - pacman.Left > 0)
                {
                    ghostPink.Left -= ghostm;
                }
            }

            if (ghostPink.Top > 0 && ghostPink.Top < 300)
            {
                if (ghostPink.Top - pacman.Top < 0)
                {
                    ghostPink.Top += ghostm;
                }
                else if (ghostPink.Top - pacman.Top > 0)
                {
                    ghostPink.Top -= ghostm;
                }
            }
            if (ghostRed.Left > 0 && ghostPink.Left < 560)
            {
                if (ghostRed.Left - pacman.Left < 0)
                {
                    ghostRed.Left += ghostm;
                }
                else if (ghostRed.Left - pacman.Left > 0)
                {
                    ghostRed.Left -= ghostm;
                }
            }

            if (ghostRed.Top > 0 && ghostPink.Top < 300)
            {
                if (ghostRed.Top - pacman.Top < 0)
                {
                    ghostRed.Top += ghostm;
                }
                else if (ghostRed.Top - pacman.Top > 0)
                {
                    ghostRed.Top -= ghostm;
                }
            }




        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ghostRed_Click(object sender, EventArgs e)
        {

        }
    }
}
