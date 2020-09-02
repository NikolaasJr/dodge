using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodge
{
    class Planet
    {
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score = 3;
        //Create a constructor (initialises the values of the fields)
        public Planet(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            planetImage = Properties.Resources.planet1;
            planetRec = new Rectangle(x, y, width, height);
        }

        public void DrawPlanet(Graphics g)
        {
          planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
        }
        public void MovePlanet()
        {
            planetRec.Location = new Point(x, y);
        }


    }
}
