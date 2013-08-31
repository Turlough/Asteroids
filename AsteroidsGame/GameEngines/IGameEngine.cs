using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsteroidsGame.GameEngines
{
    interface IGameEngine
    {
        int Width { get; set; }
        int Height { get; set; }

        void Setup();
        void GameLoop();
    }
}
