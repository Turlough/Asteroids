﻿using System;
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

        protected static Random random = new Random(DateTime.Now.Millisecond);
        protected Vector randomVector(int minx, int maxx, int miny, int maxy)
        {
            Vector v = new Vector
            (
               random.Next(minx, maxx),
               random.Next(miny, maxy)
            );
            return v;
        }

        public Sprite()
        {
            pos = new Vector();
            vel = new Vector();
            acc = new Vector();
        }
        public void Update()
        {
            vel.Move(acc);
            pos.Move(vel);
        }
        public void Draw(Bitmap background)
        {
            using (Graphics gr = Graphics.FromImage(background))
                gr.DrawImage(image, pos.x, pos.y);
        }

    }


}
