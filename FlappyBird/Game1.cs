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
			this.SetResolution (720, 1280);
			ScoreManager.ResetScore();

            base.Initialize();
        }

        protected override void LoadContent()
        {

            Art.Load(this.Content);
			SceneManager.AddScene ("Game", new GameScene ());
			SceneManager.ChangeScene ("Game");
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
			SceneManager.Update ();
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            Graphics.GraphicsDevice.Clear(Color.DarkGray);

            SpriteBatch.Begin();
			//Background
			SpriteBatch.Draw (Art.Background,
				new Rectangle (0, 0, ViewPort.Width, ViewPort.Height), Color.White);
			SceneManager.Draw (SpriteBatch);
			SpriteBatch.DrawString (Art.Font, "Score: " + ScoreManager.Score, new Vector2 (500, 20), Color.Tomato);
            SpriteBatch.End();

            base.Draw(gameTime);
        }




    }
}
