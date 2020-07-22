using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodge
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Planet[] planet = new Planet[9];
        Random yspeed = new Random();
        Spaceship spaceship = new Spaceship();
        bool left, right;
        int score, lives;
        Direction move;



        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                int x = 10 + (i * 75);
                planet[i] = new Planet(x);
            }


        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 9; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                planet[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);

            }
            spaceship.DrawSpaceship(g);

        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {


            for (int i = 0; i < 9; i++)
            {
                planet[i].MovePlanet();
                if (spaceship.spaceRec.IntersectsWith(planet[i].planetRec))
                {
                    //reset planet[i] back to top of panel
                    planet[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (planet[i].y >= PnlGame.Height)
                {
                    planet[i].y = -20;
                    score += 1;//update the score
                    lblScore.Text = score.ToString();// display scor

                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Right) { right = true; }

        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = Direction.Right;
                spaceship.MoveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = Direction.Left;
                spaceship.MoveSpaceship(move);
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Right) { right = false; }

        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

        private void FrmDodge_Load(object sender, EventArgs e)
        {
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
        }



    }
}

