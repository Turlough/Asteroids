using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace AsteroidsGame.Sprites
{
    public class Universe
    {
        public Bitmap image { get; private set; }
        public List<Sprite> sprites { get; set; }
        public Graphics g { get; set; }
        public bool ended = false;
        public static int x;
        public static int y;

        public Form form;

        public Universe(Form form)
        {
            sprites = new List<Sprite>();
            this.form = form;
            //g = form.CreateGraphics();
            x = form.Width;
            y = form.Height;

            image = new Bitmap(x, y);
 
            g = Graphics.FromImage(image);
            g.Clear(Color.Black);
        }
        public void Setup()
        {
            sprites.Add(new Rock());
            sprites.Add(new Rock());
            sprites.Add(new Rock());
        }
        public void GameLoop()
        {
            while (!ended)
            {
                g.Clear(Color.Black);
                foreach (Sprite s in sprites)
                {
                    s.Update();
                    s.Draw(image);
                }
                form.Invalidate();
                Thread.Sleep(100);
                
            }
        }
        public void Refresh()
        {

        }
    }
}
