using MarioDGE.GameScreens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Screens;

namespace MarioDGE
{
    public class MarioGame : DoubleGameEngine.Game
    {
        public MarioGame()
        {

        }

        protected override void Initialize()
        {
            base.Initialize();
            ScreenManager.LoadScreen(new Level_1(this));
            //ScreenManager.LoadScreen(new TestScreen(this));


        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}