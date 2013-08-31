using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace AsteroidsGame.Sprites
{
    public class Universe : Sprite
    {
        public  int x { get; set; }
        public  int y { get; set; }

        public Form form;

        public Universe(int x, int y)
        {
            this.x=x;
            this.y=y;
            Update();
        }
        public void Update()
        {
            image = new Bitmap(x, y);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.Black);
        }
      
    }
}
