using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace AsteroidsGame.Sprites
{


    public abstract class Sprite
    {
        public Vector pos { get; set; }
        public Vector vel { get; set; }
        public Vector acc { get; set; }
        public Bitmap image { get; set; }

        public Sprite()
        {
            pos = new Vector();
            vel = new Vector();
            acc = new Vector();
        }
        public void Update()
        {
            pos.Move(vel);
        }
        public void Draw(Bitmap background)
        {
            using (Graphics gr = Graphics.FromImage(background))
                gr.DrawImage(image, pos.x, pos.y);
        }

    }


}
