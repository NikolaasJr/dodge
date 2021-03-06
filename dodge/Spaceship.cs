﻿using System;
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
            width2 = 60;
            height2 = 45;
            spaceship = Properties.Resources.alien1;
            spaceRec = new Rectangle(x2, y2, width2, height2);
        }


        //methods
        public void DrawSpaceship(Graphics g)
        {

            g.DrawImage(spaceship, spaceRec);
        }
        public void MoveSpaceship(string move)
        {
            spaceRec.Location = new Point(x2, y2);

            if (move == "right")
            {

                x2 += 10;
                spaceRec.Location = new Point(x2, y2);
            }
            if (move =="left")
            {

                x2 -= 10;
                spaceRec.Location = new Point(x2, y2);
            }
            if (move == "down")
            {

                y2 += 10;
                spaceRec.Location = new Point(x2, y2);
            }
            if (move == "up")
            {

                y2 -= 10;
                spaceRec.Location = new Point(x2, y2);
            }


        }


    }
}
