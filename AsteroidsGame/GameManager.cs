using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AsteroidsGame
{
    class GameManager
    {
        Graphics g;
        Rectangle rect=new Rectangle(new Point(50,50),new Size (50,50));
        public GameManager(Graphics g)
        {
            this.g = g;
        }
        public void Setup()
        {
            Rectangle rect = new Rectangle(new Point(50, 50), new Size(50, 50));
           
        }

        public void Repaint()
        {
            Rectangle rect = new Rectangle(new Point(50, 50), new Size(50, 50));
            Pen p = new Pen(Color.Green);
            g.DrawRectangle(p, rect);
        }

        public void Run()
        {
            while (true)
            {
                Repaint();
            }
        }
    }
}
