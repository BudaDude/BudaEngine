using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BudaEngine.Core
{
	public class GameObject
	{
		
		public GameObject ()
		{
			this.Active = true;
            this.Sprite = new Sprite();
			Scale = Vector2.One;
		}

		public Sprite Sprite{ get; protected set;}
	    public Vector2 Position;
	    public float Rotation;
		public Vector2 Scale;
		public Vector2 Velocity;

		public string Name{ get; set; }

		/// <summary>
		/// This game.
		/// </summary>

		public bool Active;

	    public virtual void Initialize()
	    {
	        
	    }

	    public virtual void Update()
	    {
	        
	    }

	    public virtual void Draw(SpriteBatch spriteBatch)
	    {
	        if (spriteBatch != null && Sprite.Texture != null)
	        {
				spriteBatch.Draw(Sprite.Texture, Position,null, Sprite.Color,Rotation,Sprite.Origin,Scale,Sprite.SpriteEffects,Sprite.Layer );
	        }

	    }
	}
}

