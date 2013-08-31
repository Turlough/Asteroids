using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsteroidsGame.Sprites
{
    public class Vector
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector():this(0,0)
        {
        }
        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(float x,float y)
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
