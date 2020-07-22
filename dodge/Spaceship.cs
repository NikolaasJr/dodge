using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace dodge
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x2, y2, width2, height2;//variables for the rectangle
        public Image spaceship;//variable for the planet's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x2 = 320;
            y2 = 360;
            width2 = 40;
            height2 = 40;
            spaceship = Properties.Resources.alien1;
            spaceRec = new Rectangle(x2, y2, width2, height2);
        }


        //methods
        public void DrawSpaceship(Graphics g)
        {

            g.DrawImage(spaceship, spaceRec);
        }
        public void MoveSpaceship(Direction move)
        {
            spaceRec.Location = new Point(x2, y2);

            if (move == Direction.Right)
            {

                x2 += 5;
                spaceRec.Location = new Point(x2, y2);
            }
            if (move == Direction.Left)
            {

                x2 -= 5;
                spaceRec.Location = new Point(x2, y2);
            }


        }


    }
}
