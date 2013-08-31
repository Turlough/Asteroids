using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsteroidsGame.Sprites
{
    public class Vector
    {
        public int x { get; set; }
        public int y { get; set; }

        public Vector():this(0,0)
        {
        }
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x,int y)
        {
            this.x +=  x;
            this.y +=  y;
        }
        public void Move(Vector v)
        {
            Move( v.x,   v.y );
        }
    }
}
