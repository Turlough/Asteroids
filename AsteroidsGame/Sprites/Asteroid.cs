using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AsteroidsGame.Sprites
{
    public class Asteroid : Sprite
    {
        public Asteroid ()
	{
            image = new Bitmap(@"Images/Asteroid.png");

            pos.x = random.Next(400,500);
            pos.y = random.Next(400, 500);
            vel.x = random.Next(-5, 5);
            vel.y = random.Next(-5, 5);
	}
        

    }
}
