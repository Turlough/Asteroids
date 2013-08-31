using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using AsteroidsGame.Sprites;
using System.Threading;

namespace AsteroidsGame.GameEngines
{
    class GameManager : IGameEngine
    {
        Form form;
        public Graphics g { get; set; }
        Universe u;
        public List<Sprite> asteroids { get; set; }
        public Sprite ship { get; set; }
        
        public bool ended = false;
        public int Width { 
            get { return form.Width; } 
            set{}
        }
        public  int Height {
            get{return form.Height; }
            set { }
        }
        Bitmap background;

        public GameManager(Form f)
        {
            form = f;
            g = f.CreateGraphics();

            u = new Universe(form.Width, form.Height);
            background = u.image;
            asteroids = new List<Sprite>();

            form.Paint += new PaintEventHandler(form_Paint);
           
        }

        void form_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(u.image, 0, 0);
        }
        public void Setup()
        {
            asteroids.Add(new Asteroid());
            asteroids.Add(new Asteroid());
            asteroids.Add(new Asteroid());
            asteroids.Add(new Asteroid());

            u = new Universe(Width, Height);
            ship = new Ship();
        }
        public void GameLoop()
        {
            while (!ended)
            {
                //background
                u.Update();
                //asteroids
                foreach (Sprite s in asteroids)
                {
                    s.Update();
                    s.Draw(u.image);
                }
                //ship
                ship.Update();
                ship.Draw(u.image);
                //refresh screen
                form.Invalidate();
                Thread.Sleep(100);

            }
        }

    }
}
