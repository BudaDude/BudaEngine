using BudaEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : BudaGame
    {
        private Plane plane;

		private int score;


        public Game1(): base()
        {
			score = 0;
            Content.RootDirectory = "Content";
            
        }
        protected override void Initialize()
        {
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Art.Load(this.Content);
            plane = new Plane();
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            plane.Update();
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            Graphics.GraphicsDevice.Clear(Color.DarkGray);

            SpriteBatch.Begin();
			//Background
			SpriteBatch.Draw (Art.Background,
				new Rectangle (0, 0, ViewPort.Width, ViewPort.Height), Color.White);
            plane.Draw(SpriteBatch);
			SpriteBatch.DrawString (Art.Font, "Score: " + score, new Vector2 (550, 20), Color.Tomato);
            SpriteBatch.End();

            base.Draw(gameTime);
        }

		public void GameOver(){

		}


    }
}
