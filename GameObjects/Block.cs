using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioDGE.GameObjects
{
    public class Block : GameObject
    {
        public Block(GameScreen context) : base(context)
        {

        }

        public override void Init()
        {
            Texture = _content.Load<Texture2D>("GameObjects/s_EmptyBlock");

            base.Init();
        }
    }
}
