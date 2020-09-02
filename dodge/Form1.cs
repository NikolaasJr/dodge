using dodge.Resources;
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
        bool left, right, up, down;
        int score;
        int lives = 3;
        string move;
        bool startgame = false;
        int countdown = 3;
        int countdown2 = 1;
        int countdown3 = 3;
        int countdown4 = 1;
        int countdownTimer = 3;


        public Form1()
        {

            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            

            for (int i = 0; i < 9; i++)
            {
                int x = 10 + (i * 75);
                planet[i] = new Planet(x);
            }


        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            if (startgame == true)
            {
                

                //get the graphics used to paint on the panel control
                g = e.Graphics;
                //call the Planet class's DrawPlanet method to draw the image planet1 
                for (int i = 0; i < 9; i++)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    int rndmspeed = yspeed.Next(15, 40);
                    planet[i].y += rndmspeed;

                    //call the Planet class's drawPlanet method to draw the images
                    planet[i].DrawPlanet(g);

                }
                spaceship.DrawSpaceship(g);
            }
        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {


            
            
             

                for (int i = 0; i < 9; i++)
                {
                    planet[i].MovePlanet();
                    if (spaceship.spaceRec.IntersectsWith(planet[i].planetRec))
                    {
                        //reset planet[i] back to top of panel
                       // planet[i].y = 0; // set  y value of planetRec
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
                    if (score == 20)
                    {
                        TmrPlanet.Enabled = false;
                        textBox2.Visible = true;
                        timer1.Enabled = true;
                        TmrShip.Enabled = false;
                        TmrPlanet.Enabled = false;
                        startgame = false;
                        timer5.Enabled = true;


                    }


                    }


                }
            
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Up) { up = true; }
            if (e.KeyCode == Keys.Down) { down = true; }



        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
              
                spaceship.MoveSpaceship("right");
            }
            if (left) // if left arrow key pressed
            {
               
                spaceship.MoveSpaceship("left");
            }
            if (up) // if left arrow key pressed
            {
             
                spaceship.MoveSpaceship("up");
            }
            if (down) // if left arrow key pressed
            {
                
                spaceship.MoveSpaceship("down");
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Up) { up = false; }
            if (e.KeyCode == Keys.Down) { down = false; }




        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("HAHHAHAHHAHAH you lost lol");
                this.Close();

            }
        }

        private void FrmDodge_Load(object sender, EventArgs e)
        {
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
        }

        private void b1_Click(object sender, EventArgs e)
        {
            
            b1.Visible = false;
            b1.Enabled = false;
            
            pictureBox1.Visible = true;
            timer2.Enabled = true;
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            countdown2 -= 1;

            if (countdown2 == 0)
            {

                countdownLbl.Visible = true;
                countdownLbl.Enabled = true;
                countdowntimer.Enabled = true;
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown -= 1;

            if (countdown == 0)
            {
                textBox2.Visible = false;
               
                button2.Visible = true;
                button2.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Visible = false;
            click2.Visible = true;
            click2.Enabled = true;
            timer3.Enabled = true;
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            countdown3 -= 1;
                if (countdown3 == 0)
            {
                click2.Visible = false;
                click1.Enabled = false;
                timer4.Enabled = true;
                click1.Visible = true;
                click1.Enabled = true;

                countdown4 = 1;
                
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            countdown4 -= 1;

            if (countdown4 == 0)
            {
                click1.Enabled = false;
                click1.Visible = false;
                click2.Visible = true;
                click1.Enabled = false;
                timer3.Enabled = true;
                countdown3 = 3;

            }
        }

        private void click2_Click(object sender, EventArgs e)
        {
            lives -= 1;// lose a life
            txtLives.Text = lives.ToString();// display number of lives
            CheckLives();

        }

        private void click1_Click(object sender, EventArgs e)
        {
            score += 3;//update the score
            lblScore.Text = score.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void level2b_Click(object sender, EventArgs e)
        {
            level2b2.Visible = true;
            level2b2.Enabled = true;
            level2b.Enabled = false;
            level2b.Visible = false;
            timer5.Enabled = false;
        }

        private void level2b2_Click(object sender, EventArgs e)
        {
            level2b2.Visible = false;
            level2b2.Enabled = false;
            level2b3.Enabled = true;
            level2b3.Visible = true;
        }

        private void level2b3_Click(object sender, EventArgs e)
        {
            level2b3.Visible = false;
            level2b3.Enabled = false;
            txtAnswer.Enabled = true;
            textBox5.Enabled = true;
            txtAnswer.Visible = true;
            textBox5.Visible = true;
            txtAnswer.Focus();
        }

      private void timer5_Tick(object sender, EventArgs e)
        {
          lblScore.Text = score.ToString();// displ
            if (score >= 40)
            {
                click1.Enabled = false;
                click1.Visible = false;
               click2.Enabled = false;
                click2.Visible = false;
                timer3.Enabled = false;
             timer4.Enabled = false;
               level2b.Visible = true;
           level2b.Enabled = true;



           }
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtAnswer.Text == "yes")
                {

                    textBox5.Enabled = false;
                    textBox5.Visible = false;
                    textBox6.Visible = true;
                    textBox6.Enabled = true;
                    txtAnswer.Visible = false;
                    txtAnswer.Enabled = false;
                    txtAnswer2.Visible = true;
                    txtAnswer2.Enabled = true;
                    txtAnswer2.Focus();



                    // txtAnswer.Visible = false;
                    //txtAnswer.Enabled = false;
                }
                else
                {
                    MessageBox.Show("WRONG !! \n \n \n you lose life");
                         
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                    txtAnswer.Text = "";
                    txtAnswer.Focus(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Visible = false;
            button1.Enabled = false;

            level5 FormS = new level5();
            Hide();
            FormS.ShowDialog();


        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer2_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter && textBox6.Visible == true)
            { 
                if (txtAnswer2.Text == "care")
                {


                    textBox6.Visible = false;
                    textBox6.Enabled = false;
                    txtAnswer2.Visible = false;
                    txtAnswer2.Enabled = false;
                    button1.Visible = true;
                    button1.Enabled = true;


                    // txtAnswer.Visible = false;
                    //txtAnswer.Enabled = false;
                }
                else
                {
                    MessageBox.Show("WRONG !! \n \n \n you lose life");

                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                    txtAnswer.Text = "";
                    txtAnswer.Focus();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void countdowntimer_Tick(object sender, EventArgs e)
        {
            countdownTimer -= 1;
            countdownLbl.Text = countdownTimer.ToString();

            if (countdownTimer == 3)
            {
                  textBox1.Visible = true;
                  textBox3.Visible = true;
                  textBox4.Visible = true;
                  textBox1.Enabled = true;
                  textBox3.Enabled = true;
                  textBox4.Enabled = true;
            }



            else if (countdownTimer == 1)
            {
                countdownLbl.Visible = false;
                countdownLbl.Enabled = false;              
                TmrShip.Enabled = true;
                TmrPlanet.Enabled = true;
                txtLives.Text = lives.ToString();
                // textBox1.Visible = true;
                //  textBox3.Visible = true;
                //  textBox4.Visible = true;

            }
            else if (countdownTimer == 0)
            {
                startgame = true;
                countdowntimer.Enabled = false;
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox1.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }



        private void MnuStart_Click_1(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = score.ToString();
            lives = 3;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {

        }


        private void MnuStop_Click_1(object sender, EventArgs e)
        {
            TmrShip.Enabled = true;
            TmrPlanet.Enabled = true;
            txtLives.Text = lives.ToString();
            textBox1.Visible = false;
            startgame = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;


        }



    }
}

