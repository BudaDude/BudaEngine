using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Core
{
	public class BudaGame: Game
	{
		//Static
		public static BudaGame Instance{ get; private set;}
		public static Viewport ViewPort { get{ return Instance.GraphicsDevice.Viewport; }}
		public static Vector2 ScreenSize{ get { return new Vector2 (ViewPort.Width, ViewPort.Height); } }
		public static GameTime GameTime { get; private set;}


        protected GraphicsDeviceManager Graphics;
	    protected SpriteBatch SpriteBatch;


        public BudaGame ()
		{
			Instance = this;
            Graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
		}


		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize ()
		{
			base.Initialize ();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
            SpriteBatch = new SpriteBatch(GraphicsDevice);

			//TODO: use this.Content to load your game content here 
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update (GameTime gameTime)
		{
			GameTime = gameTime;
			Input.Update ();
			base.Update (gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw (GameTime gameTime)
		{
            base.Draw (gameTime);
		}

		public void ResetGame(){
			Initialize ();
			LoadContent ();
		}

	}
}

