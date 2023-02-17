using DoubleGameEngine.GameScreens;
using MarioDGE.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioDGE.GameScreens
{
    public class TestScreen : GameScreen
    {
        public TestScreen(DoubleGameEngine.Game game) : base(game)
        {
            
        }

        public override void Initialize()
        {
            base.Initialize();

            GameObjects.Add("Mario", new Mario(this) { Position = Vector2.UnitX * 192});
            for (int i = 0; i < 5; i++) {
                GameObjects.Add("EmptyBlock_" + i, new Block(this) { Position = Vector2.One * i * 64});
            }
        }
    }
}
