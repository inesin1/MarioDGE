using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using DoubleGameEngine.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace MarioDGE.GameObjects
{
    /// <summary>
    /// Марио
    /// </summary>
    public class Mario : GameObject
    {
        public MarioType Type { get; set; }                 // Тип Марио

        public Mario(GameScreen context) : base(context)
        {

        }

        public override void Init()
        {
            Texture = Context.Content.Load<Texture2D>("GameObjects/s_Mario");
            Type = MarioType.DEFAULT;
            Speed = 200f;

            base.Init();
        }

        public override void Update(float elapsedTime)
        {
            Move(elapsedTime);

            base.Update(elapsedTime);
        }

        /// <summary>
        /// Перемещает Марио в зависимости от ввода игрока
        /// </summary>
        /// <param name="elapsedTime">Прошедшее время</param>
        public void Move(float elapsedTime) {
            Velocity = new Vector2((Convert.ToInt32(Keyboard.IsKeyDown(_input["Right"])) - Convert.ToInt32(Keyboard.IsKeyDown(_input["Left"]))) * Speed, Velocity.Y);

            if (Keyboard.IsKeyDown(_input["Jump"]) &&
                IsGrounded == true
                ) 
            {
                Console.WriteLine("Прыжок");
                Velocity = new Vector2(Velocity.X, Velocity.Y - 1000);
            }

            if (Position.Y >= Variables.WINDOW_HEIGHT)
                Position = new Vector2(Position.X, 0);
        }

        public enum MarioType
        {
            DEFAULT,
            BIG,
            FIREBALL,
            STAR
        }
    }
}
