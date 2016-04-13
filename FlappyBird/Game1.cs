using BudaEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
namespace FlappyBird
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : BudaGame
    {



        public Game1(): base()
        {

            Content.RootDirectory = "Content";
            
        }
        protected override void Initialize()
        {
			ScoreManager.ResetScore();

            base.Initialize();
        }

        protected override void LoadContent()
        {

            Art.Load(this.Content);

            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
			
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            Graphics.GraphicsDevice.Clear(Color.DarkGray);

            SpriteBatch.Begin();
			//Background
			SpriteBatch.Draw (Art.Background,
				new Rectangle (0, 0, ViewPort.Width, ViewPort.Height), Color.White);
			SpriteBatch.DrawString (Art.Font, "Score: " + ScoreManager.Score, new Vector2 (550, 20), Color.Tomato);
            SpriteBatch.End();

            base.Draw(gameTime);
        }




    }
}
