﻿using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioDGE.GameObjects
{
    public class Coin : GameObject
    {
        public Coin(GameScreen context) : base(context)
        {
        }

        public override void Init()
        {
            base.Init();
            IsFixed = true;
            Scale = new Microsoft.Xna.Framework.Vector2(0.5f, 0.5f);
        }
    }
}
