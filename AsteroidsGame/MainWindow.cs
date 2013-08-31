using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AsteroidsGame.Sprites;
using System.Threading;

namespace AsteroidsGame
{
    public partial class MainWindow : Form
    {

        GameManager game;
        Graphics g;
        Pen p;
        Universe u;
        public MainWindow()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            u = new Universe(this);
            u.Setup();
            g.DrawImage(u.image, 0, 0);
            this.DoubleBuffered = true;
        }
        public void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(u.image, 0, 0);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(u.GameLoop);
           t.Start();
           this.Paint += new PaintEventHandler(OnPaint);
            
            //u.GameLoop();
        }

    }
}
