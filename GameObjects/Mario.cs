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
        public float Speed { get; set; }                    // Скорость

        private Vector2 _velocity = new Vector2();

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
            Collision();

            base.Update(elapsedTime);
        }

        /// <summary>
        /// Перемещает Марио в зависимости от ввода игрока
        /// </summary>
        /// <param name="elapsedTime">Прошедшее время</param>
        public void Move(float elapsedTime) {
            _velocity.X = (Convert.ToInt32(Keyboard.IsKeyDown(_input["Right"])) - Convert.ToInt32(Keyboard.IsKeyDown(_input["Left"]))) * Speed;
            _velocity.Y += Variables.GRAVITY;

            Position += _velocity * elapsedTime;

            //Context.Camera.Move(Vector2.UnitX * elapsedTime * 100);
        }

        public void Collision() {
            if (Position.Y > Variables.WINDOW_HEIGHT)
                Position *= Vector2.UnitX;
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
