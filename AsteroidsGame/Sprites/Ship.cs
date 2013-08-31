using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AsteroidsGame.Sprites
{
    public class Ship : Sprite
    {
         
        public Ship()
        {
            image = new Bitmap("Images/YellowShip.png");

            pos = new Vector(400,500);
            vel = new Vector(0, 0);
            acc = new Vector(1, 1);
        }
    }
}
