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
using AsteroidsGame.GameEngines;

namespace AsteroidsGame
{
    public partial class MainWindow : Form
    {

        IGameEngine game;

        public MainWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            game = new GameManager(this);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            game.Setup();
            Thread t = new Thread(game.GameLoop);
           t.Start();
        }

    }
}
