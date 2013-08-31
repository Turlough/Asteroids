using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;



namespace AsteroidsGame.Sprites
{
    public class GreenSquare : Sprite
    {
        static Random random = new Random(DateTime.Now.Millisecond);

        public GreenSquare()
        {
            image = new Bitmap(50, 50);
          using (Graphics g = Graphics.FromImage(image)) 
            g.Clear(Color.Green);



            pos.x = random.Next(400,500);
            pos.y = random.Next(400, 500);
            vel.x = random.Next(-5, 5);
            vel.y = random.Next(-5, 5);
        }
        
    }
}
